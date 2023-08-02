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
    public partial class VerificationCode : Form
    {
        public VerificationCode()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment is successful!", "Success", MessageBoxButtons.OK);
            Application.Exit();
        }
    }
}
