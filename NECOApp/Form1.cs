using System.Data;
using System.Data.OleDb;

namespace NECOApp
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\NECOdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet? ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Functions.Quit();
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            this.Hide();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            InputTextbox.enterMeterNo = tbxMeterNo.Text;
            InputTextbox.enterPassword = tbxPassword.Text;

            if (InputTextbox.enterMeterNo == AdminCredentials.MeterNo && InputTextbox.enterPassword == AdminCredentials.Password)
            {
                Usercheckin usercheckin = new Usercheckin();
                this.Hide();
                usercheckin.Show();
            }
            else if (InputTextbox.enterMeterNo != AdminCredentials.MeterNo && InputTextbox.enterPassword != AdminCredentials.Password)
            {
                conn.Open();

                string query = "SELECT Password FROM UserInfo WHERE MeterNo = @MeterNo";
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MeterNo", InputTextbox.enterMeterNo);
                    Ref.passwordFromDatabase = command.ExecuteScalar()?.ToString();

                    if (Ref.passwordFromDatabase == InputTextbox.enterPassword)
                    {
                        Ref.MeterNumber = InputTextbox.enterMeterNo;
                        BillMenu menu = new BillMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid meter number or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Invalid meter number or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public class Goto
        {
            public static void gotoLogbook()
            {
                Form1 f1 = new Form1();
                Usercheckin uc = new Usercheckin();
                f1.Hide();
                uc.Show();
            }

            public static void gotoRegisterForm()
            {
                Form1 f1 = new Form1();
                RegisterForm RegisterForm = new RegisterForm();
                f1.Hide();
                RegisterForm.Show();
            }

            public static void gotoUserInterface()
            {
                Form1 f1 = new Form1();
                Form1.Ref.MeterNumber = InputTextbox.enterMeterNo;
                UserInterface userForm = new UserInterface();
                f1.Hide();
                userForm.Show();
            }
        }

        public class Ref
        {
            public static string? MeterNumber { get; set; }
            public static string? passwordFromDatabase { get; set; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            this.Hide();
            frm.Show();
        }
    }
    public static class AdminCredentials
    {
        public static string MeterNo { get; set; } = "admin";
        public static string Password { get; set; } = "admin";
    }

    public static class InputTextbox
    {
        public static string? enterMeterNo { get; set; }
        public static string? enterPassword { get; set; }
    }

    public static class Functions
    {
        public static void Quit()
        {
            Application.Exit();
        }
    }
}