namespace NECOApp
{
    partial class GCASH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCASH));
            tbxAmount = new TextBox();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            btnPay = new Button();
            btnClear = new Button();
            tbxNumber = new TextBox();
            tbxName = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            btnCloseApp = new Button();
            pictureBox1 = new PictureBox();
            btnLogoutUI = new Button();
            tbxMeterNo = new TextBox();
            tbxDate = new TextBox();
            tbxTime = new TextBox();
            tbxKWH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbxAmount
            // 
            tbxAmount.BackColor = Color.White;
            tbxAmount.Cursor = Cursors.IBeam;
            tbxAmount.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAmount.ForeColor = Color.Black;
            tbxAmount.Location = new Point(162, 312);
            tbxAmount.Multiline = true;
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(188, 33);
            tbxAmount.TabIndex = 40;
            tbxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LemonChiffon;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.DarkRed;
            textBox6.Location = new Point(46, 322);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(144, 23);
            textBox6.TabIndex = 36;
            textBox6.TabStop = false;
            textBox6.Text = "Amount:";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft PhagsPa", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(138, 92);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(165, 62);
            textBox1.TabIndex = 25;
            textBox1.TabStop = false;
            textBox1.Text = "NECO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Gold;
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.ForeColor = Color.DarkRed;
            btnPay.Location = new Point(241, 384);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(109, 38);
            btnPay.TabIndex = 33;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnContinue_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.DarkRed;
            btnClear.Location = new Point(46, 384);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 38);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbxNumber
            // 
            tbxNumber.BackColor = Color.White;
            tbxNumber.Cursor = Cursors.IBeam;
            tbxNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxNumber.ForeColor = Color.Black;
            tbxNumber.Location = new Point(162, 273);
            tbxNumber.Multiline = true;
            tbxNumber.Name = "tbxNumber";
            tbxNumber.Size = new Size(188, 33);
            tbxNumber.TabIndex = 31;
            tbxNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.White;
            tbxName.Cursor = Cursors.IBeam;
            tbxName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxName.ForeColor = Color.Black;
            tbxName.Location = new Point(162, 234);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(188, 33);
            tbxName.TabIndex = 30;
            tbxName.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LemonChiffon;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.DarkRed;
            textBox4.Location = new Point(63, 283);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(107, 23);
            textBox4.TabIndex = 29;
            textBox4.TabStop = false;
            textBox4.Text = "Number:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LemonChiffon;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.DarkRed;
            textBox3.Location = new Point(76, 244);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 28;
            textBox3.TabStop = false;
            textBox3.Text = "Name:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Malgun Gothic", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.DarkRed;
            textBox2.Location = new Point(86, 185);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(255, 34);
            textBox2.TabIndex = 27;
            textBox2.TabStop = false;
            textBox2.Text = "GCASH";
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
            btnCloseApp.Location = new Point(352, 11);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(41, 40);
            btnCloseApp.TabIndex = 26;
            btnCloseApp.UseVisualStyleBackColor = false;
            btnCloseApp.Click += btnCloseApp_Click;
            btnCloseApp.MouseClick += btnCloseApp_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-21, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btnLogoutUI
            // 
            btnLogoutUI.BackColor = Color.Transparent;
            btnLogoutUI.BackgroundImage = (Image)resources.GetObject("btnLogoutUI.BackgroundImage");
            btnLogoutUI.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogoutUI.FlatAppearance.BorderSize = 0;
            btnLogoutUI.FlatStyle = FlatStyle.Flat;
            btnLogoutUI.Location = new Point(308, 14);
            btnLogoutUI.Name = "btnLogoutUI";
            btnLogoutUI.Size = new Size(33, 34);
            btnLogoutUI.TabIndex = 41;
            btnLogoutUI.UseVisualStyleBackColor = false;
            btnLogoutUI.MouseClick += btnLogoutUI_MouseClick;
            // 
            // tbxMeterNo
            // 
            tbxMeterNo.BackColor = Color.White;
            tbxMeterNo.Cursor = Cursors.IBeam;
            tbxMeterNo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMeterNo.ForeColor = Color.Black;
            tbxMeterNo.Location = new Point(12, 23);
            tbxMeterNo.Multiline = true;
            tbxMeterNo.Name = "tbxMeterNo";
            tbxMeterNo.Size = new Size(188, 33);
            tbxMeterNo.TabIndex = 42;
            tbxMeterNo.TextAlign = HorizontalAlignment.Right;
            tbxMeterNo.Visible = false;
            // 
            // tbxDate
            // 
            tbxDate.BackColor = Color.White;
            tbxDate.Cursor = Cursors.IBeam;
            tbxDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDate.ForeColor = Color.Black;
            tbxDate.Location = new Point(12, 62);
            tbxDate.Multiline = true;
            tbxDate.Name = "tbxDate";
            tbxDate.Size = new Size(188, 33);
            tbxDate.TabIndex = 43;
            tbxDate.TextAlign = HorizontalAlignment.Right;
            tbxDate.Visible = false;
            // 
            // tbxTime
            // 
            tbxTime.BackColor = Color.White;
            tbxTime.Cursor = Cursors.IBeam;
            tbxTime.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTime.ForeColor = Color.Black;
            tbxTime.Location = new Point(12, 101);
            tbxTime.Multiline = true;
            tbxTime.Name = "tbxTime";
            tbxTime.Size = new Size(188, 33);
            tbxTime.TabIndex = 44;
            tbxTime.TextAlign = HorizontalAlignment.Right;
            tbxTime.Visible = false;
            // 
            // tbxKWH
            // 
            tbxKWH.BackColor = Color.White;
            tbxKWH.Cursor = Cursors.IBeam;
            tbxKWH.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxKWH.ForeColor = Color.Black;
            tbxKWH.Location = new Point(12, 140);
            tbxKWH.Multiline = true;
            tbxKWH.Name = "tbxKWH";
            tbxKWH.Size = new Size(188, 33);
            tbxKWH.TabIndex = 45;
            tbxKWH.TextAlign = HorizontalAlignment.Right;
            tbxKWH.Visible = false;
            // 
            // GCASH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(405, 466);
            Controls.Add(tbxKWH);
            Controls.Add(tbxTime);
            Controls.Add(tbxDate);
            Controls.Add(tbxMeterNo);
            Controls.Add(btnLogoutUI);
            Controls.Add(tbxAmount);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(btnPay);
            Controls.Add(btnClear);
            Controls.Add(tbxNumber);
            Controls.Add(tbxName);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btnCloseApp);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GCASH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCASH";
            Load += GCASH_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxAmount;
        private TextBox textBox6;
        private TextBox textBox1;
        private Button btnPay;
        private Button btnClear;
        private TextBox tbxNumber;
        private TextBox tbxName;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnCloseApp;
        private PictureBox pictureBox1;
        private Button btnLogoutUI;
        private TextBox tbxMeterNo;
        private TextBox tbxDate;
        private TextBox tbxTime;
        private TextBox tbxKWH;
    }
}