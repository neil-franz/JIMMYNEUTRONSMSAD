using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iText = iTextSharp.text;

namespace NECOApp
{
    public partial class GCASH : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\NECOdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet? ds;

        public GCASH()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string pdfFilePath = "D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\Receipt.pdf";
            string un = tbxName.Text;
            decimal payment = decimal.Parse(tbxAmount.Text);
            DateTime dateTime = DateTime.Now;
            decimal atp = GetATP();
            DateTime dd = getdd();

            decimal change = payment - atp;
            if (DateTime.Now > dd && !IsPaymentMade())
            {
                atp += atp * 0.02m;
            }

            if (payment >= atp)
            {
                PaidStatus();
                DisplayReceipt(un, payment, atp, change, DateTime.Now);
                toHistory();
                MessageBox.Show("You have successfully paid for your account.", "A receipt will be sent through your email.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sendEmail(pdfFilePath, un, payment, atp, change, dateTime);
            }
            else
            {
                MessageBox.Show("Payment is insufficient. Please enter the correct amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
            LoadtoGCASH();
        }

        private void ClearFields()
        {
            tbxName.Text = "";
            tbxAmount.Text = "";
            tbxNumber.Text = "";
            tbxDate.Text = "";
            tbxKWH.Text = "";
            tbxMeterNo.Text = "";
            tbxTime.Text = "";
            tbxAmount.Focus();
            LoadtoGCASH();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogoutUI_MouseClick(object sender, MouseEventArgs e)
        {
            OnlineBanking onlineBanking = new OnlineBanking();
            this.Hide();
            onlineBanking.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            tbxAmount.Text = "";
            tbxNumber.Text = "";
            tbxDate.Text = "";
            tbxKWH.Text = "";
            tbxMeterNo.Text = "";
            tbxTime.Text = "";
            tbxAmount.Focus();
            LoadtoGCASH();
        }

        private void btnCloseApp_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void SendEmailNotification(string toEmail, string subject, string body, string fileName)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "neutronsnecoelectronics@gmail.com";
            string smtpPassword = "pzboeumvalghalxl";

            using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                using (MailMessage mailMessage = new MailMessage("neutronsnecoelectronics@gmail.com", toEmail, subject, body))
                {
                    mailMessage.IsBodyHtml = false;
                    Attachment attach = new Attachment(fileName);
                    mailMessage.Attachments.Add(attach);
                    client.Send(mailMessage);
                }
            }
        }

        private decimal GetATP()
        {
            decimal atp = 0;

            string? mn = Form1.Ref.MeterNumber;

            string query = "SELECT ATP FROM Bill WHERE MeterNo = @mn";

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@mn", mn);

                try
                {
                    conn.Open();
                    object? result = cmd.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal amount))
                    {
                        atp = amount;
                    }
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error retrieving amount to pay: " + ex.Message);
                }
            }

            return atp;
        }

        private DateTime getdd()
        {
            DateTime dd = DateTime.MinValue;
            string? mn = Form1.Ref.MeterNumber;

            string getdd = "SELECT DueDate From DueDate WHERE Key = @Key";
            using (OleDbCommand command = new OleDbCommand(getdd, conn))
            {
                command.Parameters.AddWithValue("@Key", 99);
                try
                {
                    conn.Open();
                    object? res = command.ExecuteScalar();
                    if (res != null && DateTime.TryParse(res.ToString(), out DateTime d))
                    {
                        dd = d;
                    }
                    conn.Close();
                }
                catch (OleDbException e)
                {
                    MessageBox.Show("Error retrieving date: " + e.Message);
                }
            }
            return dd;
        }

        private bool IsPaymentMade()
        {
            bool paid = false;

            string? meterNumber = Form1.Ref.MeterNumber;

            string query = "SELECT Paid FROM Bill WHERE MeterNumber = @MeterNumber";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MeterNumber", meterNumber);
                try
                {
                    conn.Open();
                    object? result = cmd.ExecuteScalar();

                    if (result != null && result.ToString().Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        paid = true;
                    }
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    Console.WriteLine("Error checking payment status: " + ex.Message);
                }
            }
            return paid;
        }

        private void PaidStatus()
        {
            string? mn = Form1.Ref.MeterNumber;
            string query = "UPDATE Bill SET Paid = 'Yes', ATP = '0', Killowatts = '0' WHERE MeterNo = @mn";

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@mn", mn);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Payment status and ATP field updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No records updated. Meter number not found.");
                    }
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    Console.WriteLine("Error updating payment status and ATP field: " + ex.Message);
                }
            }
        }

        private void DisplayReceipt(string un, decimal payment, decimal atp, decimal change, DateTime dd)
        {
            string receiptMessage = $"Payment Receipt\n\n" +
                                    $"User Name: {un}\n" +
                                    $"Amount Given: {payment}\n" +
                                    $"Amount to Pay: {atp}\n" +
                                    $"Change: {change}\n" +
                                    $"Payment Date: {dd}\n\n" +
                                    $"Thank you for your payment.";

            MessageBox.Show(receiptMessage, "Payment Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadtoGCASH()
        {
            string? mn = Form1.Ref.MeterNumber;
            tbxMeterNo.Text = mn;
            string query = "SELECT UserInfo.FullName, Bill.Killowatts " +
                           "FROM UserInfo INNER JOIN Bill ON UserInfo.MeterNo = Bill.MeterNo " +
                           "WHERE UserInfo.MeterNo = @mn";


            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@mn", mn);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (reader.Read())
                        {
                            tbxName.Text = reader["FullName"].ToString();
                            tbxKWH.Text = reader["Killowatts"].ToString();
                        }
                        else
                        {
                            Console.WriteLine("There is an error");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                conn.Close();
            }

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            string formattedTime = currentDate.ToString("h:mm tt");
            tbxDate.Text = formattedDate;
            tbxTime.Text = formattedTime;
        }

        private void toHistory()
        {
            try
            {
                conn.Open();
                string register = "INSERT INTO HistorySubsystem VALUES ('" + tbxMeterNo.Text + "', '" + tbxName.Text + "', '" + tbxAmount.Text + "', '" + tbxDate.Text + "', '" + tbxTime.Text + "', '" + tbxKWH.Text + "')";
                cmd = new OleDbCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendEmail(string fileName, string un, decimal amountPaid, decimal atp, decimal change, DateTime paymentDate)
        {
            string subject = "Registration Pending";
            string body = "Dear " + tbxName.Text + ",\n\n" +
                          "Your payment is successful. Thank you for your payment." +
                          ".\n\n" +
                          "At your service,\n" +
                          "NECOapp";

            string? meternoLI = Form1.Ref.MeterNumber;
            string query = "SELECT Email FROM UserIn WHERE MeterNo = @MeterNo";
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@MeterNo", meternoLI);

            string? email = string.Empty;

            try
            {
                conn.Open();
                object? result = cmd.ExecuteScalar();
                if (result != null)
                {
                    email = result.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving customer email: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            PDFReceipt(fileName, un, amountPaid, atp, change, paymentDate);
            SendEmailNotification(email, subject, body, fileName);
        }

        private void PDFReceipt(string fileName, string un, decimal amountPaid, decimal atp, decimal change, DateTime paymentDate)
        {
            iText.Rectangle pageSize = PageSize.A6.Rotate();
            iText.Document docs = new iText.Document(pageSize, 10f, 10f, 10f, 10f);

            try
            {
                PdfWriter.GetInstance(docs, new FileStream(fileName, FileMode.Create));

                PdfPTable headerTable = new PdfPTable(2);
                headerTable.DefaultCell.Border = iText.Rectangle.NO_BORDER;
                headerTable.DefaultCell.Padding = 5f;
                headerTable.WidthPercentage = 100f;

                iText.Image logoImage = iText.Image.GetInstance("D:\\CIT-U\\Webp.net-resizeimage.png");
                logoImage.ScaleAbsolute(60f, 60f);

                PdfPCell logoCell = new PdfPCell(logoImage);
                logoCell.Border = iText.Rectangle.NO_BORDER;
                logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
                headerTable.AddCell(logoCell);

                PdfPCell companyInfoCell = new PdfPCell(new Phrase("NECO Electronics\n6969 Anti-silos Ave., Cebu\nPhilippines\nPhone: 09 09 090 9090\nEmail: neutronsnecoelectronics@gmail.com", new iText.Font(iText.Font.FontFamily.HELVETICA, 10f, iText.Font.NORMAL)));
                companyInfoCell.Border = iText.Rectangle.NO_BORDER;
                companyInfoCell.HorizontalAlignment = Element.ALIGN_LEFT;
                headerTable.AddCell(companyInfoCell);

                docs.Open();

                docs.Add(headerTable);

                docs.Add(new iText.pdf.draw.LineSeparator(0.5f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1));

                Paragraph heading = new Paragraph("NECO Payment Receipt");
                heading.Alignment = Element.ALIGN_CENTER;
                heading.SpacingBefore = 10f;
                docs.Add(heading);

                Paragraph customerInfo = new Paragraph($"Customer Name: {un}");
                docs.Add(customerInfo);

                Paragraph paidAmount = new Paragraph($"Amount Paid: {amountPaid:C}");
                docs.Add(paidAmount);

                Paragraph amountToPay = new Paragraph($"Amount to Pay: {atp:C}");
                docs.Add(amountToPay);

                Paragraph changeAmount = new Paragraph($"Change: {change:C}");
                docs.Add(changeAmount);

                Paragraph paymentDateTime = new Paragraph($"Payment Date: {paymentDate}");
                docs.Add(paymentDateTime);

                docs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GCASH_Load(object sender, EventArgs e)
        {
            LoadtoGCASH();
        }
    }
}
