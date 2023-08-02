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
    public partial class OnlineBanking : Form
    {
        public OnlineBanking()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            BankTransfer bankTransfer = new BankTransfer();
            this.Hide();
            bankTransfer.Show();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            BankTransfer bankTransfer = new BankTransfer();
            this.Hide();
            bankTransfer.Show();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            GCASH gCASH = new GCASH();
            this.Hide();
            gCASH.Show();
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            BankTransfer bankTransfer = new BankTransfer();
            this.Hide();
            bankTransfer.Show();
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            BankTransfer bankTransfer = new BankTransfer();
            this.Hide();
            bankTransfer.Show();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            BankTransfer bankTransfer = new BankTransfer();
            this.Hide();
            bankTransfer.Show();
        }

        private void btnLogoutUI_MouseClick(object sender, MouseEventArgs e)
        {
            PaymentMenu paymentMenu = new PaymentMenu();
            this.Hide();
            paymentMenu.Show();
        }

        private void btnCloseRegister_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
