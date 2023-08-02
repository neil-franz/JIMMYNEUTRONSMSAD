using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NECOApp
{
    public partial class UserInterface : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\NECOdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet? ds;

        public UserInterface()
        {
            InitializeComponent();

        }

        private void btnCloseUI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoutUI_Click(object sender, EventArgs e)
        {
            BillMenu billmenu = new BillMenu();
            this.Hide();
            billmenu.Show();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            string? MeterNumber = Form1.Ref.MeterNumber;
            string mainQuery = $"SELECT UserInfo.FullName, UserInfo.Address, Bill.Killowatts, Bill.ATP, Bill.Paid, DueDate.DueDate " +
                               $"FROM (UserInfo " +
                               $"LEFT JOIN Bill ON UserInfo.MeterNo = Bill.MeterNo) " +
                               $"LEFT JOIN DueDate ON UserInfo.FKey = DueDate.Key " +
                               $"WHERE UserInfo.MeterNo = @MN";

            using (OleDbCommand cmd = new OleDbCommand(mainQuery, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@MN", MeterNumber);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tbxUserName.Text = reader["FullName"].ToString();
                        tbxAddress.Text = reader["Address"].ToString();
                        tbxKWH.Text = reader["Killowatts"].ToString();
                        tbxATP.Text = reader["ATP"].ToString();
                        tbxPaid.Text = reader["Paid"].ToString();
                        tbxDueDate.Text = reader["DueDate"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data found for the entered meter number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }

            //string annquery = "SELECT Announcement FROM Announcement WHERE Key = @key";
            //using (OleDbCommand cmd = new OleDbCommand(@annquery, conn))
            //{
            //    conn.Open();
            //    cmd.Parameters.AddWithValue("@key", 99);
            //    using (OleDbDataReader read = cmd.ExecuteReader())
            //    {
            //        if (read.Read())
            //        {
            //            string announcement = read.GetString(0);
            //            tbxAnnouncement.Text = announcement;
            //        }
            //    }
            //    conn.Close();
            //}
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

        //private void btnPay_Click(object sender, EventArgs e)
        //{
        //    string un = tbxUserName.Text;
        //    decimal payment = decimal.Parse(tbxPay.Text);

        //    decimal atp = GetATP();
        //    DateTime dd = getdd();

        //    decimal change = payment - atp;
        //    if (DateTime.Now > dd && !IsPaymentMade())
        //    {
        //        atp += atp * 0.02m;
        //    }

        //    if (payment >= atp)
        //    {
        //        PaidStatus();

        //        DisplayReceipt(un, payment, atp, change, DateTime.Now);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Payment is insufficient. Please enter the correct amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            PaymentMenu paymentMenu = new PaymentMenu();
            this.Hide();
            paymentMenu.Show();
        }
    }
}
