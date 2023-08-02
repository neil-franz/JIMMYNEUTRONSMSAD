namespace NECOApp
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbxATP = new TextBox();
            tbxKWH = new TextBox();
            tbxAddress = new TextBox();
            tbxUserName = new TextBox();
            tbxDueDate = new TextBox();
            tbxPaid = new TextBox();
            btnCloseUI = new Button();
            btnLogoutUI = new Button();
            btnBills = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(12, 198);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 2;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(12, 237);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 3;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 276);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 4;
            label3.Text = "KWH:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(12, 316);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 5;
            label4.Text = "Amount to Pay:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(12, 360);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 6;
            label5.Text = "Due Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(12, 403);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 7;
            label6.Text = "Paid:";
            // 
            // tbxATP
            // 
            tbxATP.BackColor = Color.White;
            tbxATP.Cursor = Cursors.No;
            tbxATP.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            tbxATP.Location = new Point(163, 316);
            tbxATP.Name = "tbxATP";
            tbxATP.ReadOnly = true;
            tbxATP.Size = new Size(187, 31);
            tbxATP.TabIndex = 8;
            // 
            // tbxKWH
            // 
            tbxKWH.BackColor = Color.White;
            tbxKWH.Cursor = Cursors.No;
            tbxKWH.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            tbxKWH.Location = new Point(163, 276);
            tbxKWH.Name = "tbxKWH";
            tbxKWH.ReadOnly = true;
            tbxKWH.Size = new Size(187, 31);
            tbxKWH.TabIndex = 9;
            // 
            // tbxAddress
            // 
            tbxAddress.BackColor = Color.White;
            tbxAddress.Cursor = Cursors.No;
            tbxAddress.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            tbxAddress.Location = new Point(163, 237);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.ReadOnly = true;
            tbxAddress.Size = new Size(187, 31);
            tbxAddress.TabIndex = 10;
            // 
            // tbxUserName
            // 
            tbxUserName.BackColor = Color.White;
            tbxUserName.Cursor = Cursors.No;
            tbxUserName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            tbxUserName.Location = new Point(163, 198);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.ReadOnly = true;
            tbxUserName.Size = new Size(187, 31);
            tbxUserName.TabIndex = 11;
            // 
            // tbxDueDate
            // 
            tbxDueDate.BackColor = Color.White;
            tbxDueDate.Cursor = Cursors.No;
            tbxDueDate.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            tbxDueDate.Location = new Point(163, 360);
            tbxDueDate.Name = "tbxDueDate";
            tbxDueDate.ReadOnly = true;
            tbxDueDate.Size = new Size(187, 31);
            tbxDueDate.TabIndex = 12;
            // 
            // tbxPaid
            // 
            tbxPaid.BackColor = Color.White;
            tbxPaid.Cursor = Cursors.No;
            tbxPaid.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            tbxPaid.Location = new Point(163, 403);
            tbxPaid.Name = "tbxPaid";
            tbxPaid.ReadOnly = true;
            tbxPaid.Size = new Size(187, 31);
            tbxPaid.TabIndex = 13;
            // 
            // btnCloseUI
            // 
            btnCloseUI.BackColor = Color.Transparent;
            btnCloseUI.BackgroundImage = (Image)resources.GetObject("btnCloseUI.BackgroundImage");
            btnCloseUI.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseUI.Cursor = Cursors.Hand;
            btnCloseUI.FlatAppearance.BorderSize = 0;
            btnCloseUI.FlatStyle = FlatStyle.Flat;
            btnCloseUI.Location = new Point(323, 12);
            btnCloseUI.Name = "btnCloseUI";
            btnCloseUI.Size = new Size(39, 35);
            btnCloseUI.TabIndex = 14;
            btnCloseUI.UseVisualStyleBackColor = false;
            btnCloseUI.Click += btnCloseUI_Click;
            // 
            // btnLogoutUI
            // 
            btnLogoutUI.BackColor = Color.Transparent;
            btnLogoutUI.BackgroundImage = (Image)resources.GetObject("btnLogoutUI.BackgroundImage");
            btnLogoutUI.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogoutUI.FlatAppearance.BorderSize = 0;
            btnLogoutUI.FlatStyle = FlatStyle.Flat;
            btnLogoutUI.Location = new Point(329, 53);
            btnLogoutUI.Name = "btnLogoutUI";
            btnLogoutUI.Size = new Size(33, 34);
            btnLogoutUI.TabIndex = 15;
            btnLogoutUI.UseVisualStyleBackColor = false;
            btnLogoutUI.Click += btnLogoutUI_Click;
            // 
            // btnBills
            // 
            btnBills.BackColor = Color.Gold;
            btnBills.Cursor = Cursors.Hand;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBills.ForeColor = Color.DarkRed;
            btnBills.Location = new Point(111, 450);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(158, 43);
            btnBills.TabIndex = 16;
            btnBills.Text = "Pay Bills";
            btnBills.UseVisualStyleBackColor = false;
            btnBills.Click += btnBills_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft PhagsPa", 48F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(101, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 82);
            textBox1.TabIndex = 17;
            textBox1.TabStop = false;
            textBox1.Text = "NECO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(368, 505);
            Controls.Add(textBox1);
            Controls.Add(btnBills);
            Controls.Add(btnLogoutUI);
            Controls.Add(btnCloseUI);
            Controls.Add(tbxPaid);
            Controls.Add(tbxDueDate);
            Controls.Add(tbxUserName);
            Controls.Add(tbxAddress);
            Controls.Add(tbxKWH);
            Controls.Add(tbxATP);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInterface";
            Load += UserInterface_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbxDueDate;
        private TextBox tbxPaid;
        private Button btnCloseUI;
        private Button btnLogoutUI;
        private Button btnBills;
        private TextBox textBox1;
        public TextBox tbxATP;
        public TextBox tbxKWH;
        public TextBox tbxAddress;
        public TextBox tbxUserName;
    }
}