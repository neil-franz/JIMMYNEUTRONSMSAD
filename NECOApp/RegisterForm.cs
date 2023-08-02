using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Net.Mail;
using System.Net;

namespace NECOApp
{
    public partial class RegisterForm : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\NECOdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet? ds;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCloseRegister_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                tbxPass.PasswordChar = '\0';
                tbxConPass.PasswordChar = '\0';
            }
            else
            {
                tbxPass.PasswordChar = '*';
                tbxConPass.PasswordChar = '*';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            tbxMetNum.Text = string.Empty;
            tbxPass.Text = string.Empty;
            tbxConPass.Text = string.Empty;
            tbxName.Text = string.Empty;
            tbxAddress.Text = string.Empty;
            tbxZIP.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            tbxName.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbxMetNum.Text == "" && tbxPass.Text == "" && tbxConPass.Text == "" && tbxName.Text == "" && tbxAddress.Text == "" && tbxZIP.Text == "")
            {
                MessageBox.Show("Some fields are empty", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
            }
            else if (tbxPass.Text == tbxConPass.Text)
            {
                try
                {
                    conn.Open();
                    string register = "INSERT INTO PendingRequests VALUES ('" + tbxMetNum.Text + "', '" + tbxName.Text + "', '" + tbxAddress.Text + "', '" + tbxZIP.Text + "', '" + tbxPass.Text + "', '" + tbxEmail.Text + "')";
                    cmd = new OleDbCommand(register, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string subject = "Registration Pending";
                    string body = "Dear " + tbxName.Text + ",\n\n" +
                                  "Thank you for registering an account. Your account is currently pending approval. " +
                                  "You will receive another email once your account has been approved.\n\n" +
                                  "Best regards,\n" +
                                  "NECOapp Admin";

                    string userEmailAddress = tbxEmail.Text;

                    SendEmailNotification(userEmailAddress, subject, body);
                    ClearFields();
                    MessageBox.Show("Approval for account is pending.", "Please wait for confirmation email.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("MeterNo, Password, or PIN is/are already taken.", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Passwords do not match please re-enter", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxPass.Text = "";
                tbxConPass.Text = "";
                tbxPass.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
    }
}
