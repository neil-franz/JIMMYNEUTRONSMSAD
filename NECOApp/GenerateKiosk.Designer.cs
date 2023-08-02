namespace NECOApp
{
    partial class GenerateKiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateKiosk));
            tbxAccNum = new TextBox();
            btnClear = new Button();
            btnGenerate = new Button();
            tbxAddress = new TextBox();
            tbxName = new TextBox();
            tbxAmount = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            btnCloseRegister = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            btnLogoutUI = new Button();
            tbxMeterNo = new TextBox();
            tbxDate = new TextBox();
            tbxTime = new TextBox();
            tbxKWH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbxAccNum
            // 
            tbxAccNum.BackColor = Color.White;
            tbxAccNum.Cursor = Cursors.IBeam;
            tbxAccNum.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAccNum.Location = new Point(227, 366);
            tbxAccNum.Name = "tbxAccNum";
            tbxAccNum.Size = new Size(220, 30);
            tbxAccNum.TabIndex = 38;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.DarkRed;
            btnClear.Location = new Point(118, 488);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 42);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Gold;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.ForeColor = Color.DarkRed;
            btnGenerate.Location = new Point(345, 488);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(102, 42);
            btnGenerate.TabIndex = 36;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // tbxAddress
            // 
            tbxAddress.BackColor = Color.White;
            tbxAddress.Cursor = Cursors.IBeam;
            tbxAddress.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAddress.Location = new Point(227, 316);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(220, 30);
            tbxAddress.TabIndex = 34;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.White;
            tbxName.Cursor = Cursors.IBeam;
            tbxName.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxName.Location = new Point(227, 264);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(220, 30);
            tbxName.TabIndex = 33;
            // 
            // tbxAmount
            // 
            tbxAmount.BackColor = Color.White;
            tbxAmount.Cursor = Cursors.IBeam;
            tbxAmount.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAmount.Location = new Point(227, 415);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(220, 30);
            tbxAmount.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(67, 373);
            label6.Name = "label6";
            label6.Size = new Size(153, 23);
            label6.TabIndex = 29;
            label6.Text = "Account Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(140, 323);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 28;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(158, 271);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 27;
            label4.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(134, 422);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 24;
            label1.Text = "Amount: ";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Maroon;
            textBox2.Location = new Point(172, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 36);
            textBox2.TabIndex = 23;
            textBox2.TabStop = false;
            textBox2.Text = "OTP RECEIPT";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCloseRegister
            // 
            btnCloseRegister.BackgroundImage = (Image)resources.GetObject("btnCloseRegister.BackgroundImage");
            btnCloseRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseRegister.Cursor = Cursors.Hand;
            btnCloseRegister.FlatAppearance.BorderSize = 0;
            btnCloseRegister.FlatStyle = FlatStyle.Flat;
            btnCloseRegister.Location = new Point(482, 22);
            btnCloseRegister.Name = "btnCloseRegister";
            btnCloseRegister.Size = new Size(40, 39);
            btnCloseRegister.TabIndex = 22;
            btnCloseRegister.UseVisualStyleBackColor = true;
            btnCloseRegister.Click += btnCloseRegister_Click;
            btnCloseRegister.MouseClick += btnCloseRegister_MouseClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft PhagsPa", 48F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(184, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 82);
            textBox1.TabIndex = 21;
            textBox1.TabStop = false;
            textBox1.Text = "NECO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-26, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnLogoutUI
            // 
            btnLogoutUI.BackColor = Color.Transparent;
            btnLogoutUI.BackgroundImage = (Image)resources.GetObject("btnLogoutUI.BackgroundImage");
            btnLogoutUI.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogoutUI.FlatAppearance.BorderSize = 0;
            btnLogoutUI.FlatStyle = FlatStyle.Flat;
            btnLogoutUI.Location = new Point(432, 24);
            btnLogoutUI.Name = "btnLogoutUI";
            btnLogoutUI.Size = new Size(33, 34);
            btnLogoutUI.TabIndex = 39;
            btnLogoutUI.UseVisualStyleBackColor = false;
            btnLogoutUI.MouseClick += btnLogoutUI_MouseClick;
            // 
            // tbxMeterNo
            // 
            tbxMeterNo.BackColor = Color.White;
            tbxMeterNo.Cursor = Cursors.IBeam;
            tbxMeterNo.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMeterNo.Location = new Point(12, 24);
            tbxMeterNo.Name = "tbxMeterNo";
            tbxMeterNo.Size = new Size(220, 30);
            tbxMeterNo.TabIndex = 40;
            tbxMeterNo.Visible = false;
            // 
            // tbxDate
            // 
            tbxDate.BackColor = Color.White;
            tbxDate.Cursor = Cursors.IBeam;
            tbxDate.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDate.Location = new Point(12, 60);
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(220, 30);
            tbxDate.TabIndex = 41;
            tbxDate.Visible = false;
            // 
            // tbxTime
            // 
            tbxTime.BackColor = Color.White;
            tbxTime.Cursor = Cursors.IBeam;
            tbxTime.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTime.Location = new Point(12, 96);
            tbxTime.Name = "tbxTime";
            tbxTime.Size = new Size(220, 30);
            tbxTime.TabIndex = 42;
            tbxTime.Visible = false;
            // 
            // tbxKWH
            // 
            tbxKWH.BackColor = Color.White;
            tbxKWH.Cursor = Cursors.IBeam;
            tbxKWH.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxKWH.Location = new Point(12, 132);
            tbxKWH.Name = "tbxKWH";
            tbxKWH.Size = new Size(220, 30);
            tbxKWH.TabIndex = 43;
            tbxKWH.Visible = false;
            // 
            // GenerateKiosk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(539, 568);
            Controls.Add(tbxKWH);
            Controls.Add(tbxTime);
            Controls.Add(tbxDate);
            Controls.Add(tbxMeterNo);
            Controls.Add(btnLogoutUI);
            Controls.Add(tbxAccNum);
            Controls.Add(btnClear);
            Controls.Add(btnGenerate);
            Controls.Add(tbxAddress);
            Controls.Add(tbxName);
            Controls.Add(tbxAmount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btnCloseRegister);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GenerateKiosk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GenerateKiosk";
            Load += GenerateKiosk_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxAccNum;
        private Button btnClear;
        private Button btnGenerate;
        private TextBox tbxAddress;
        private TextBox tbxName;
        private TextBox tbxAmount;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox textBox2;
        private Button btnCloseRegister;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button btnLogoutUI;
        private TextBox tbxMeterNo;
        private TextBox tbxDate;
        private TextBox tbxTime;
        private TextBox tbxKWH;
    }
}