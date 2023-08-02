using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Globalization;

namespace NECOApp
{
    public partial class Usercheckin : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\NECOdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet? ds;

        public Usercheckin()
        {
            InitializeComponent();
        }

        private void btnCloseCheckin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string register = "INSERT INTO AdminIn VALUES ('" + tbxAdminName.Text + "', '" + tbxAdminAdd.Text + "', '" + tbxDatein.Text + "', '" + tbxCheckin.Text + "')";
            cmd = new OleDbCommand(register, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            AdminInterface ai = new AdminInterface();
            ai.Show();
            this.Hide();
        }

        private void Usercheckin_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            string formattedTime = currentDate.ToString("h:mm tt");
            tbxDatein.Text = formattedDate;
            tbxCheckin.Text = formattedTime;
        }
    }
}
