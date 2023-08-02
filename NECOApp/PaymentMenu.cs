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
    public partial class PaymentMenu : Form
    {
        public PaymentMenu()
        {
            InitializeComponent();
        }

        private void btnGenerateKiosk_Click(object sender, EventArgs e)
        {
            GenerateKiosk generateKiosk = new GenerateKiosk();
            this.Hide();
            generateKiosk.Show();
        }

        private void btnOnlineBanking_Click(object sender, EventArgs e)
        {
            OnlineBanking onlineBanking = new OnlineBanking();
            this.Hide();
            onlineBanking.Show();
        }

        private void btnLogoutUI_MouseClick(object sender, MouseEventArgs e)
        {
            BillMenu billMenu = new BillMenu();
            this.Hide();
            billMenu.Show();
        }

        private void btnCloseApp_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
