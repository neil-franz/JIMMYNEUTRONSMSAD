namespace NECOApp
{
    partial class BankTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankTransfer));
            textBox1 = new TextBox();
            btnProceed = new Button();
            btnClear = new Button();
            tbxName = new TextBox();
            textBox2 = new TextBox();
            btnCloseApp = new Button();
            pictureBox1 = new PictureBox();
            tbxAmount = new TextBox();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            tbxAccNum = new TextBox();
            txtName = new TextBox();
            btnLogoutUI = new Button();
            tbxMeterNum = new TextBox();
            tbxDate = new TextBox();
            tbxTime = new TextBox();
            tbxKWH = new TextBox();
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
            // btnProceed
            // 
            btnProceed.BackColor = Color.Gold;
            btnProceed.Cursor = Cursors.Hand;
            btnProceed.FlatStyle = FlatStyle.Flat;
            btnProceed.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnProceed.ForeColor = Color.DarkRed;
            btnProceed.Location = new Point(241, 365);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(109, 38);
            btnProceed.TabIndex = 21;
            btnProceed.Text = "Pay";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.DarkRed;
            btnClear.Location = new Point(65, 365);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 38);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.White;
            tbxName.Cursor = Cursors.IBeam;
            tbxName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxName.ForeColor = Color.Black;
            tbxName.HideSelection = false;
            tbxName.Location = new Point(162, 235);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(188, 33);
            tbxName.TabIndex = 17;
            tbxName.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Malgun Gothic", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.DarkRed;
            textBox2.Location = new Point(86, 186);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(255, 34);
            textBox2.TabIndex = 14;
            textBox2.TabStop = false;
            textBox2.Text = "BANK TRANSFER";
            textBox2.TextAlign = HorizontalAlignment.Center;
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
            // tbxAmount
            // 
            tbxAmount.BackColor = Color.White;
            tbxAmount.Cursor = Cursors.IBeam;
            tbxAmount.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAmount.ForeColor = Color.Black;
            tbxAmount.Location = new Point(162, 274);
            tbxAmount.Multiline = true;
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(188, 33);
            tbxAmount.TabIndex = 23;
            tbxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LemonChiffon;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.DarkRed;
            textBox6.Location = new Point(78, 284);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(78, 23);
            textBox6.TabIndex = 22;
            textBox6.TabStop = false;
            textBox6.Text = "Amount:";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.LemonChiffon;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.ForeColor = Color.DarkRed;
            textBox9.Location = new Point(-17, 323);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(191, 23);
            textBox9.TabIndex = 22;
            textBox9.TabStop = false;
            textBox9.Text = "Account Number:";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxAccNum
            // 
            tbxAccNum.BackColor = Color.White;
            tbxAccNum.Cursor = Cursors.IBeam;
            tbxAccNum.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAccNum.ForeColor = Color.Black;
            tbxAccNum.Location = new Point(162, 313);
            tbxAccNum.Multiline = true;
            tbxAccNum.Name = "tbxAccNum";
            tbxAccNum.Size = new Size(188, 33);
            tbxAccNum.TabIndex = 23;
            tbxAccNum.TextAlign = HorizontalAlignment.Right;
            // 
            // txtName
            // 
            txtName.BackColor = Color.LemonChiffon;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.ForeColor = Color.DarkRed;
            txtName.Location = new Point(94, 245);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(62, 23);
            txtName.TabIndex = 22;
            txtName.TabStop = false;
            txtName.Text = "Name:";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogoutUI
            // 
            btnLogoutUI.BackColor = Color.Transparent;
            btnLogoutUI.BackgroundImage = (Image)resources.GetObject("btnLogoutUI.BackgroundImage");
            btnLogoutUI.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogoutUI.FlatAppearance.BorderSize = 0;
            btnLogoutUI.FlatStyle = FlatStyle.Flat;
            btnLogoutUI.Location = new Point(308, 15);
            btnLogoutUI.Name = "btnLogoutUI";
            btnLogoutUI.Size = new Size(33, 34);
            btnLogoutUI.TabIndex = 24;
            btnLogoutUI.UseVisualStyleBackColor = false;
            btnLogoutUI.MouseClick += btnLogoutUI_MouseClick;
            // 
            // tbxMeterNum
            // 
            tbxMeterNum.BackColor = Color.White;
            tbxMeterNum.Cursor = Cursors.IBeam;
            tbxMeterNum.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMeterNum.ForeColor = Color.Black;
            tbxMeterNum.HideSelection = false;
            tbxMeterNum.Location = new Point(12, 12);
            tbxMeterNum.Multiline = true;
            tbxMeterNum.Name = "tbxMeterNum";
            tbxMeterNum.Size = new Size(188, 33);
            tbxMeterNum.TabIndex = 25;
            tbxMeterNum.TextAlign = HorizontalAlignment.Right;
            tbxMeterNum.Visible = false;
            // 
            // tbxDate
            // 
            tbxDate.BackColor = Color.White;
            tbxDate.Cursor = Cursors.IBeam;
            tbxDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDate.ForeColor = Color.Black;
            tbxDate.HideSelection = false;
            tbxDate.Location = new Point(12, 51);
            tbxDate.Multiline = true;
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(188, 33);
            tbxDate.TabIndex = 26;
            tbxDate.TextAlign = HorizontalAlignment.Right;
            tbxDate.Visible = false;
            // 
            // tbxTime
            // 
            tbxTime.BackColor = Color.White;
            tbxTime.Cursor = Cursors.IBeam;
            tbxTime.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTime.ForeColor = Color.Black;
            tbxTime.HideSelection = false;
            tbxTime.Location = new Point(12, 90);
            tbxTime.Multiline = true;
            tbxTime.Name = "tbxTime";
            tbxTime.Size = new Size(188, 33);
            tbxTime.TabIndex = 27;
            tbxTime.TextAlign = HorizontalAlignment.Right;
            tbxTime.Visible = false;
            // 
            // tbxKWH
            // 
            tbxKWH.BackColor = Color.White;
            tbxKWH.Cursor = Cursors.IBeam;
            tbxKWH.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxKWH.ForeColor = Color.Black;
            tbxKWH.HideSelection = false;
            tbxKWH.Location = new Point(12, 129);
            tbxKWH.Multiline = true;
            tbxKWH.Name = "tbxKWH";
            tbxKWH.Size = new Size(188, 33);
            tbxKWH.TabIndex = 28;
            tbxKWH.TextAlign = HorizontalAlignment.Right;
            tbxKWH.Visible = false;
            // 
            // BankTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(402, 424);
            Controls.Add(tbxKWH);
            Controls.Add(tbxTime);
            Controls.Add(tbxDate);
            Controls.Add(tbxMeterNum);
            Controls.Add(btnLogoutUI);
            Controls.Add(txtName);
            Controls.Add(tbxAccNum);
            Controls.Add(textBox9);
            Controls.Add(tbxAmount);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(btnProceed);
            Controls.Add(btnClear);
            Controls.Add(tbxName);
            Controls.Add(textBox2);
            Controls.Add(btnCloseApp);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BankTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BankTransfer";
            Load += BankTransfer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnProceed;
        private Button btnClear;
        private TextBox tbxName;
        private TextBox textBox2;
        private Button btnCloseApp;
        private PictureBox pictureBox1;
        private TextBox tbxAmount;
        private TextBox textBox6;
        private TextBox textBox9;
        private TextBox tbxAccNum;
        private TextBox txtName;
        private Button btnLogoutUI;
        private TextBox tbxMeterNum;
        private TextBox tbxDate;
        private TextBox tbxTime;
        private TextBox tbxKWH;
    }
}