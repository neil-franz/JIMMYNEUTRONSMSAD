namespace NECOApp
{
    partial class PaymentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMenu));
            btnOnlineBanking = new Button();
            btnGenerateKiosk = new Button();
            textBox1 = new TextBox();
            btnCloseApp = new Button();
            pictureBox1 = new PictureBox();
            btnLogoutUI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOnlineBanking
            // 
            btnOnlineBanking.BackColor = Color.Gold;
            btnOnlineBanking.FlatStyle = FlatStyle.Flat;
            btnOnlineBanking.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnlineBanking.ForeColor = Color.DarkRed;
            btnOnlineBanking.Location = new Point(93, 252);
            btnOnlineBanking.Name = "btnOnlineBanking";
            btnOnlineBanking.Size = new Size(245, 52);
            btnOnlineBanking.TabIndex = 18;
            btnOnlineBanking.Text = "Online Banking";
            btnOnlineBanking.UseVisualStyleBackColor = false;
            btnOnlineBanking.Click += btnOnlineBanking_Click;
            // 
            // btnGenerateKiosk
            // 
            btnGenerateKiosk.BackColor = Color.Gold;
            btnGenerateKiosk.FlatStyle = FlatStyle.Flat;
            btnGenerateKiosk.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerateKiosk.ForeColor = Color.DarkRed;
            btnGenerateKiosk.Location = new Point(93, 185);
            btnGenerateKiosk.Name = "btnGenerateKiosk";
            btnGenerateKiosk.Size = new Size(245, 52);
            btnGenerateKiosk.TabIndex = 19;
            btnGenerateKiosk.Text = "OTC Receipt";
            btnGenerateKiosk.UseVisualStyleBackColor = false;
            btnGenerateKiosk.Click += btnGenerateKiosk_Click;
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
            textBox1.TabIndex = 16;
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
            btnCloseApp.TabIndex = 17;
            btnCloseApp.UseVisualStyleBackColor = false;
            btnCloseApp.MouseClick += btnCloseApp_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-21, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
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
            btnLogoutUI.TabIndex = 20;
            btnLogoutUI.UseVisualStyleBackColor = false;
            btnLogoutUI.MouseClick += btnLogoutUI_MouseClick;
            // 
            // PaymentMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(405, 373);
            Controls.Add(btnLogoutUI);
            Controls.Add(btnOnlineBanking);
            Controls.Add(btnGenerateKiosk);
            Controls.Add(textBox1);
            Controls.Add(btnCloseApp);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOnlineBanking;
        private Button btnGenerateKiosk;
        private TextBox textBox1;
        private Button btnCloseApp;
        private PictureBox pictureBox1;
        private Button btnLogoutUI;
    }
}