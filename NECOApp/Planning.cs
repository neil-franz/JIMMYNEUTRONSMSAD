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
    public partial class Planning : Form
    {
        public Planning()
        {
            InitializeComponent();
        }

        private void btnCloseRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoutUI_Click(object sender, EventArgs e)
        {
            BillMenu billMenu = new BillMenu();
            this.Hide();
            billMenu.Show();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;

            // Get the month and year from the selected date
            string month = selectedDate.ToString("MMMM");

            // Update the label text with the selected month and year
            labelMonth.Text = month + ":";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2_GoalAmount.Text, out double input) &&
         double.TryParse(textBox2_LatestMeterInput.Text, out double latestMeterInput))
            {
                double resultKWatts = (input / 4) / 11;
                textBox4_PowConKW.Text = resultKWatts.ToString("F2");

                double resultWatts = resultKWatts * 1000;
                textBox3_PowConWatts.Text = resultWatts.ToString("F2");

                textBox2_PCWpanel2.Text = resultKWatts.ToString("F2");

                double goalamountWeekly = input/4;
                textBox3_GoalAmountWeekly.Text = goalamountWeekly.ToString("F2");

                textBox2_LatestMeter.Text = latestMeterInput.ToString("F2");

                double week1Result = resultKWatts + latestMeterInput;
                textBox2_Week1.Text = week1Result.ToString("F2");

                double week2Result = week1Result + resultKWatts;
                textBox3_Week2.Text = week2Result.ToString("F2");

                double week3Result = week2Result + resultKWatts;
                textBox4_Week3.Text = week3Result.ToString("F2");

                double week4Result = week3Result + resultKWatts;
                textBox5_Week4.Text = week4Result.ToString("F2");

                textBox_finalGoal.Text = week4Result.ToString("F2");
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void textBox7_AmntForMonthSelected_TextChanged(object sender, EventArgs e)
        {
            textBox2_LatestMeterInput.Text = textBox2_LatestMeter.Text;
        }

        private void textBox2_GoalAmount_TextChanged(object sender, EventArgs e)
        {
            label10_GoalAmount.Text = textBox2_GoalAmount.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
