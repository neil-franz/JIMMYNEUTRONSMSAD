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
using iTextSharp.text.pdf;
using iTextSharp.text;
using iText = iTextSharp.text;

namespace NECOApp
{
    public partial class GenerateKiosk : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\NECOdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet? ds;

        public GenerateKiosk()
        {
            InitializeComponent();
        }

        private void btnCloseRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogoutUI_MouseClick(object sender, MouseEventArgs e)
        {
            PaymentMenu paymentMenu = new PaymentMenu();
            this.Hide();
            paymentMenu.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = string.Empty;
            tbxAddress.Text = string.Empty;
            tbxAccNum.Text = string.Empty;
            tbxAmount.Text = string.Empty;
            tbxDate.Text = string.Empty;
            tbxKWH.Text = string.Empty;
            tbxMeterNo.Text = string.Empty;
            tbxTime.Text = string.Empty;
            LoadtoOTC();
            tbxAmount.Focus();
        }

        private void ClearFields()
        {
            tbxName.Text = string.Empty;
            tbxAddress.Text = string.Empty;
            tbxAccNum.Text = string.Empty;
            tbxAmount.Text = string.Empty;
            tbxDate.Text = string.Empty;
            tbxKWH.Text = string.Empty;
            tbxMeterNo.Text = string.Empty;
            tbxTime.Text = string.Empty;
            LoadtoOTC();
            tbxAmount.Focus();
        }

        private void btnCloseRegister_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string pdfFilePath = "D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\OTCReceipt.pdf";
            string mn = tbxMeterNo.Text;
            string un = tbxName.Text;
            string add = tbxAddress.Text;
            string tndramt = tbxAmount.Text;
            string kwh = tbxKWH.Text;
            decimal atp = GetATP();
            DateTime dateTime = DateTime.Now;

            MessageBox.Show("An email has been sent.", "Present the contents of your email to your nearest branch.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sendEmail(pdfFilePath, mn, un, add, tndramt, kwh, atp, dateTime);
            ClearFields();
            LoadtoOTC();
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

        private void SendEmailNotification(string toEmail, string subject, string body, string filePath)
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
                    Attachment attach = new Attachment(filePath);
                    mailMessage.Attachments.Add(attach);
                    client.Send(mailMessage);
                }
            }
        }

        private void GenerateKiosk_Load(object sender, EventArgs e)
        {
            LoadtoOTC();
        }

        private void LoadtoOTC()
        {
            string? mn = Form1.Ref.MeterNumber;
            tbxMeterNo.Text = mn;
            string query = "SELECT UserInfo.FullName, Bill.Killowatts, UserInfo.Address " +
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
                            tbxAddress.Text = reader["Address"].ToString();
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

        private void sendEmail(string fileName, string mn, string un, string add, string tndramnt, string kwh, decimal atp, DateTime datetime)
        {
            string subject = "Registration Pending";
            string body = "Dear " + tbxName.Text + ",\n\n" +
                          "Present this OTC receipt to your nearest NECO branch or affiliated stores." +
                          "\n\n" +
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
            PDFReceipt(fileName, mn, un, add, tndramnt, kwh, atp, datetime);
            SendEmailNotification(email, subject, body, fileName);
        }

        private void PDFReceipt(string fileName, string mn, string un, string add, string tndramnt, string kwh, decimal atp, DateTime datetime)
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

                Paragraph heading = new Paragraph("NECO Over-the-Counter Receipt");
                heading.Alignment = Element.ALIGN_CENTER;
                heading.SpacingBefore = 10f;
                docs.Add(heading);

                Paragraph customerMN = new Paragraph($"Customer Meter Number Name: {mn}");
                docs.Add(customerMN);

                Paragraph customerName = new Paragraph($"Customer Name: {un}");
                docs.Add(customerName);

                Paragraph customerAdd = new Paragraph($"Customer Address: {add}");
                docs.Add(customerAdd);

                Paragraph tenderedAmount = new Paragraph($"Tendered Amount: {tndramnt}");
                docs.Add(tenderedAmount);

                Paragraph KWH = new Paragraph($"Kilowatts per Hour for the Month: {kwh}");
                docs.Add(KWH);

                Paragraph amountToPay = new Paragraph($"Amount to Pay: {atp:C}");
                docs.Add(amountToPay);

                Paragraph paymentDateTime = new Paragraph($"Date Receipt is Generated: {datetime}");
                docs.Add(paymentDateTime);

                docs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
