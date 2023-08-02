using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NECOApp
{
    public partial class AdminInterface : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\NECOdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet? ds;
        public AdminInterface()
        {
            InitializeComponent();

        }

        private void btnCloseAI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoutAI_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime updatedDueDate;
            if (DateTime.TryParseExact(tbxDueDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out updatedDueDate))
            {
                string updateQuery = "UPDATE DueDate SET DueDate = @DueDate";
                using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, conn))
                {
                    updateCommand.Parameters.AddWithValue("@DueDate", updatedDueDate);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("DueDate updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update DueDate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid DueDate format. Please enter a valid date in the format MM/dd/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT UserInfo.MeterNo, UserInfo.FullName, UserInfo.Address, UserInfo.ZIP, UserInfo.Password, Bill.Killowatts, Bill.ATP, Bill.Paid " +
                 "FROM UserInfo INNER JOIN Bill ON UserInfo.MeterNo = Bill.MeterNo", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "UserBill");
            dgvDB.DataSource = ds.Tables["UserBill"];
            conn.Close();
        }

        private void dgvDB_Click(object sender, EventArgs e)
        {

        }

        private void dgvDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDB.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDB.SelectedRows[0];

                tbxKWH.Text = selectedRow.Cells["Killowatts"].Value.ToString();
            }
        }

        private void tbxKWH_TextChanged(object sender, EventArgs e)
        {
            int killowatts;
            if (int.TryParse(tbxKWH.Text, out killowatts))
            {
                decimal atp = killowatts * 11.34m;
                tbxATP.Text = atp.ToString();
            }
            else
            {
                tbxATP.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDB.SelectedRows.Count > 0)
            {
                DataGridViewRow selectrow = dgvDB.SelectedRows[0];
                int i = selectrow.Index;

                int updatekwh;
                if (int.TryParse(tbxKWH.Text, out updatekwh))
                {
                    string updateq = "UPDATE UserBill SET Bill.Killowatts = @kwh, Bill.ATP = @atp, Bill.Paid = @paid where UserInfo.MeterNo = @mn";
                    using (OleDbCommand updatecmd = new OleDbCommand(updateq, conn))
                    {
                        conn.Open();
                        updatecmd.Parameters.AddWithValue("@kwh", updatekwh);
                        updatecmd.Parameters.AddWithValue("@atp", tbxATP.Text);
                        updatecmd.Parameters.AddWithValue("@paid", "No");
                        updatecmd.Parameters.AddWithValue("@mn", selectrow.Cells["MeterNo"].Value);

                        int rowsaffected = updatecmd.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvDB.Rows[i].Cells["Killowatts"].Value = updatekwh;
                            dgvDB.Rows[i].Cells["ATP"].Value = tbxATP.Text;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Killowatts value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {
            string query = "SELECT DueDate FROM DueDate WHERE Key = @Key";
            using (OleDbCommand command = new OleDbCommand(query, conn))
            {
                conn.Open();
                command.Parameters.AddWithValue("@Key", 99);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DateTime dueDate = reader.GetDateTime(0);
                        tbxDueDate.Text = dueDate.ToString("MM/dd/yyyy");
                    }
                }
                conn.Close();
            }

            string annquery = "SELECT Announcement FROM Announcement WHERE Key = @key";
            using (OleDbCommand cmd = new OleDbCommand(@annquery, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@key", 99);
                using (OleDbDataReader read = cmd.ExecuteReader())
                {
                    if (read.Read())
                    {
                        string announcement = read.GetString(0);
                        tbxAnnouncement.Text = announcement;
                    }
                }
                conn.Close();
            }

            LoadPendingRegistrations();
            LoadUserHistory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string updateannounce = tbxAnnouncement.Text;
            string updateq = "UPDATE Announcement SET Announcement = @A WHERE Key = @Key";
            using (OleDbCommand udcmd = new OleDbCommand(updateq, conn))
            {
                conn.Open();
                udcmd.Parameters.AddWithValue("@A", updateannounce);
                udcmd.Parameters.AddWithValue("@Key", 99);
                int rowsaffected = udcmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    MessageBox.Show("Announcement updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update Announcement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private void LoadPendingRegistrations()
        {
            conn.Open();
            try
            {

                string query = "SELECT MeterNo, FullName, Address, ZIP, Password, Email FROM PendingRequests";
                cmd = new OleDbCommand(query, conn);
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "PendingRequests");
                pendingTable.DataSource = ds.Tables["PendingRequests"];

            }
            catch
            {
                MessageBox.Show("An error occurred while loading pending registrations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void pendingTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = pendingTable.Rows[e.RowIndex];
                tbxMeterNo.Text = row.Cells["MeterNo"].Value.ToString();
                tbxName.Text = row.Cells["FullName"].Value.ToString();
                tbxAddress.Text = row.Cells["Address"].Value.ToString();
                tbxZIP.Text = row.Cells["ZIP"].Value.ToString();
                tbxPassword.Text = row.Cells["Password"].Value.ToString();
                tbxEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxMeterNo.Text))
            {
                try
                {
                    conn.Open();
                    string register = "INSERT INTO UserIn VALUES ('" + tbxMeterNo.Text + "', '" + tbxName.Text + "', '" + tbxAddress.Text + "', '" + tbxZIP.Text + "', '" + tbxPassword.Text + "', '" + tbxEmail.Text + "')";
                    cmd = new OleDbCommand(register, conn);
                    cmd.ExecuteNonQuery();

                    string deleteQuery = "DELETE FROM PendingRequests WHERE MeterNo = @MeterNo";
                    cmd = new OleDbCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@MeterNo", tbxMeterNo.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    string subject = "Registration Pending";
                    string body = "Dear " + tbxName.Text + ",\n\n" +
                                  "Congratulations! Your account has been verified.\n\n" +
                                  "You can now use NECOapp.\n\n" +
                                  "At your service,\n" +
                                  "JIMMY NEUTRONS";

                    string userEmailAddress = tbxEmail.Text;
                    MessageBox.Show("Account added to the database.", "Account added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SendEmailNotification(userEmailAddress, subject, body);
                    ClearFields();
                    LoadPendingRegistrations();
                }
                catch
                {
                    MessageBox.Show("An error occurred while approving the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a registration to approve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendEmailNotification(string toEmail, string subject, string body)
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
                    client.Send(mailMessage);
                }
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxMeterNo.Text))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM PendingRequests WHERE MeterNo = @MeterNo";
                    cmd = new OleDbCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@MeterNo", tbxMeterNo.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Account denied and removed from pending registrations.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string subject = "Registration Pending";
                    string body = "Dear " + tbxName.Text + ",\n\n" +
                                  "We are sorry. It seems like the information you have given is inadequate or disingenuous.\n\n" +
                                  "Please try again.\n\n" +
                                  "Serving truly,\n" +
                                  "JIMMY NEUTRONS";

                    string userEmailAddress = tbxEmail.Text;

                    SendEmailNotification(userEmailAddress, subject, body);
                    ClearFields();
                    LoadPendingRegistrations();
                }
                catch
                {
                    MessageBox.Show("An error occurred while denying the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a registration to deny.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            tbxMeterNo.Text = "";
            tbxName.Text = "";
            tbxAddress.Text = "";
            tbxZIP.Text = "";
            tbxPassword.Text = "";
            tbxEmail.Text = "";
        }

        private void LoadUserHistory()
        {
            try
            {
                string query = $"SELECT * FROM HistorySubSystem";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    da = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "HistorySubsystem");
                    dgvuserPaymentHistory.DataSource = ds.Tables["HistorySubsystem"];
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
