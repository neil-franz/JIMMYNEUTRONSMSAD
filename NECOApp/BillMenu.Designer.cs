namespace NECOApp
{
    partial class BillMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillMenu));
            textBox1 = new TextBox();
            btnCloseApp = new Button();
            pictureBox1 = new PictureBox();
            btnPayBill = new Button();
            btnLogoutUI = new Button();
            btnPaymentHistory = new Button();
            btnEnergyPlanning = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft PhagsPa", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(138, 93);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(165, 62);
            textBox1.TabIndex = 12;
            textBox1.TabStop = false;
            textBox1.Text = "NECO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCloseApp
            // 
            btnCloseApp.BackColor = Color.LemonChiffon;
            btnCloseApp.BackgroundImage = (Image)resources.GetObject("btnCloseApp.BackgroundImage");
            btnCloseApp.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseApp.Cursor = Cursors.Hand;
            btnCloseApp.FlatAppearance.BorderSize = 0;
            btnCloseApp.FlatStyle = FlatStyle.Flat;
            btnCloseApp.Location = new Point(352, 12);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(41, 40);
            btnCloseApp.TabIndex = 13;
            btnCloseApp.UseVisualStyleBackColor = false;
            btnCloseApp.Click += btnCloseApp_Click;
            btnCloseApp.MouseClick += btnCloseApp_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-21, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnPayBill
            // 
            btnPayBill.BackColor = Color.Gold;
            btnPayBill.FlatStyle = FlatStyle.Flat;
            btnPayBill.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayBill.ForeColor = Color.DarkRed;
            btnPayBill.Location = new Point(93, 185);
            btnPayBill.Name = "btnPayBill";
            btnPayBill.Size = new Size(245, 52);
            btnPayBill.TabIndex = 14;
            btnPayBill.Text = "View Bill";
            btnPayBill.UseVisualStyleBackColor = false;
            btnPayBill.Click += btnPayBill_Click;
            // 
            // btnLogoutUI
            // 
            btnLogoutUI.BackColor = Color.Transparent;
            btnLogoutUI.BackgroundImage = (Image)resources.GetObject("btnLogoutUI.BackgroundImage");
            btnLogoutUI.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogoutUI.FlatAppearance.BorderSize = 0;
            btnLogoutUI.FlatStyle = FlatStyle.Flat;
            btnLogoutUI.Location = new Point(305, 15);
            btnLogoutUI.Name = "btnLogoutUI";
            btnLogoutUI.Size = new Size(33, 34);
            btnLogoutUI.TabIndex = 16;
            btnLogoutUI.UseVisualStyleBackColor = false;
            btnLogoutUI.MouseClick += btnLogoutUI_MouseClick;
            // 
            // btnPaymentHistory
            // 
            btnPaymentHistory.BackColor = Color.Gold;
            btnPaymentHistory.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPaymentHistory.ForeColor = Color.DarkRed;
            btnPaymentHistory.Location = new Point(93, 243);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(245, 52);
            btnPaymentHistory.TabIndex = 17;
            btnPaymentHistory.Text = "Payment History";
            btnPaymentHistory.UseVisualStyleBackColor = false;
            btnPaymentHistory.Click += btnPaymentHistory_Click;
            // 
            // btnEnergyPlanning
            // 
            btnEnergyPlanning.BackColor = Color.Gold;
            btnEnergyPlanning.FlatStyle = FlatStyle.Flat;
            btnEnergyPlanning.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnergyPlanning.ForeColor = Color.DarkRed;
            btnEnergyPlanning.Location = new Point(93, 301);
            btnEnergyPlanning.Name = "btnEnergyPlanning";
            btnEnergyPlanning.Size = new Size(245, 52);
            btnEnergyPlanning.TabIndex = 17;
            btnEnergyPlanning.Text = "Energy Planning";
            btnEnergyPlanning.UseVisualStyleBackColor = false;
            btnEnergyPlanning.Click += btnEnergyPlanning_Click;
            // 
            // BillMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(405, 383);
            Controls.Add(btnEnergyPlanning);
            Controls.Add(btnPaymentHistory);
            Controls.Add(btnLogoutUI);
            Controls.Add(btnPayBill);
            Controls.Add(textBox1);
            Controls.Add(btnCloseApp);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnLogin;
        private CheckBox cbxShowPass;
        private TextBox tbxPassword;
        private TextBox tbxMeterNo;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnCloseApp;
        private PictureBox pictureBox1;
        private Button btnPayBill;
        private Button btnLogoutUI;
        private Button btnPaymentHistory;
        private Button btnEnergyPlanning;
    }
}