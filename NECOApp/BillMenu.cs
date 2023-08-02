using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NECOApp
{
    public partial class BillMenu : Form
    {
        public BillMenu()
        {
            InitializeComponent();
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            UserInterface UI = new UserInterface();
            this.Hide();
            UI.Show();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoutUI_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnCloseApp_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnEnergyPlanning_Click(object sender, EventArgs e)
        {
            Planning planning = new Planning();
            this.Hide();
            planning.Show();
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            PaymentHistory payhistory = new PaymentHistory();
            this.Hide();
            payhistory.Show();
        }
    }
}
