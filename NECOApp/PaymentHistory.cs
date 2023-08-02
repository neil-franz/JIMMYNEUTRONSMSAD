using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NECOApp
{
    public partial class PaymentHistory : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\CIT-U\\CIT-U Second Year\\Midyear (Second Year)\\NECOdb.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet? ds;
        public PaymentHistory()
        {
            InitializeComponent();
            loadPaymentHistory();
        }

        private void btnLogoutUI_MouseClick(object sender, MouseEventArgs e)
        {
            BillMenu billMenu = new BillMenu();
            this.Hide();
            billMenu.Show();
        }

        private void btnCloseRegister_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        public void loadPaymentHistory()
        {
            try
            {
                conn.Open();
                string mn = Form1.Ref.MeterNumber;
                string query = $"SELECT * FROM HistorySubSystem WHERE MeterNo = @MeterNo";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MeterNo", mn);
                    da = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "HistorySubsystem");
                    dgvPayHistory.DataSource = ds.Tables["HistorySubsystem"];
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
