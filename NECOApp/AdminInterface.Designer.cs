namespace NECOApp
{
    partial class AdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnChange = new Button();
            label1 = new Label();
            tbxDueDate = new TextBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            tbxATP = new TextBox();
            btnDB = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            tbxKWH = new TextBox();
            dgvDB = new DataGridView();
            tabPage3 = new TabPage();
            btnSave = new Button();
            label3 = new Label();
            tbxAnnouncement = new TextBox();
            tabPage4 = new TabPage();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbxEmail = new TextBox();
            tbxPassword = new TextBox();
            tbxZIP = new TextBox();
            tbxAddress = new TextBox();
            tbxName = new TextBox();
            tbxMeterNo = new TextBox();
            btnDeny = new Button();
            btnClear = new Button();
            button1 = new Button();
            pendingTable = new DataGridView();
            tabPage5 = new TabPage();
            btnCloseAI = new Button();
            btnLogoutAI = new Button();
            textBox1 = new TextBox();
            dgvuserPaymentHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDB).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pendingTable).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvuserPaymentHistory).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(3, 157);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(982, 430);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(btnChange);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbxDueDate);
            tabPage1.Cursor = Cursors.Hand;
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(974, 402);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Due Date";
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.White;
            btnChange.BackgroundImage = (Image)resources.GetObject("btnChange.BackgroundImage");
            btnChange.BackgroundImageLayout = ImageLayout.Stretch;
            btnChange.Cursor = Cursors.Hand;
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Location = new Point(453, 214);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(50, 45);
            btnChange.TabIndex = 5;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(348, 132);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 4;
            label1.Text = "Due Date";
            // 
            // tbxDueDate
            // 
            tbxDueDate.BackColor = Color.Khaki;
            tbxDueDate.Cursor = Cursors.IBeam;
            tbxDueDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDueDate.Location = new Point(348, 173);
            tbxDueDate.Name = "tbxDueDate";
            tbxDueDate.PlaceholderText = "mm/dd/yyyy";
            tbxDueDate.Size = new Size(303, 31);
            tbxDueDate.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(tbxATP);
            tabPage2.Controls.Add(btnDB);
            tabPage2.Controls.Add(btnUpdate);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(tbxKWH);
            tabPage2.Controls.Add(dgvDB);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(974, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Database";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(15, 155);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 9;
            label4.Text = "Amount to Pay";
            // 
            // tbxATP
            // 
            tbxATP.BackColor = Color.Khaki;
            tbxATP.BorderStyle = BorderStyle.None;
            tbxATP.Cursor = Cursors.IBeam;
            tbxATP.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxATP.Location = new Point(15, 199);
            tbxATP.Name = "tbxATP";
            tbxATP.Size = new Size(302, 24);
            tbxATP.TabIndex = 8;
            // 
            // btnDB
            // 
            btnDB.BackgroundImage = (Image)resources.GetObject("btnDB.BackgroundImage");
            btnDB.BackgroundImageLayout = ImageLayout.Stretch;
            btnDB.FlatAppearance.BorderSize = 0;
            btnDB.FlatStyle = FlatStyle.Flat;
            btnDB.Location = new Point(265, 10);
            btnDB.Name = "btnDB";
            btnDB.Size = new Size(52, 48);
            btnDB.TabIndex = 7;
            btnDB.UseVisualStyleBackColor = true;
            btnDB.Click += btnDB_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = (Image)resources.GetObject("btnUpdate.BackgroundImage");
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(127, 316);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(52, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(15, 226);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 5;
            label2.Text = "Killowatts per Hour";
            // 
            // tbxKWH
            // 
            tbxKWH.BackColor = Color.Khaki;
            tbxKWH.BorderStyle = BorderStyle.None;
            tbxKWH.Cursor = Cursors.IBeam;
            tbxKWH.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxKWH.Location = new Point(15, 270);
            tbxKWH.Name = "tbxKWH";
            tbxKWH.Size = new Size(302, 24);
            tbxKWH.TabIndex = 4;
            tbxKWH.TextChanged += tbxKWH_TextChanged;
            // 
            // dgvDB
            // 
            dgvDB.BackgroundColor = Color.Maroon;
            dgvDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDB.GridColor = Color.Khaki;
            dgvDB.Location = new Point(323, 10);
            dgvDB.Name = "dgvDB";
            dgvDB.RowTemplate.Height = 25;
            dgvDB.Size = new Size(637, 382);
            dgvDB.TabIndex = 3;
            dgvDB.CellClick += dgvDB_CellClick;
            dgvDB.Click += dgvDB_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSave);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(tbxAnnouncement);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(974, 402);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Announcement";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(101, 329);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(55, 44);
            btnSave.TabIndex = 2;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(68, 28);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 1;
            label3.Text = "Announcement";
            // 
            // tbxAnnouncement
            // 
            tbxAnnouncement.BackColor = Color.Khaki;
            tbxAnnouncement.BorderStyle = BorderStyle.None;
            tbxAnnouncement.Cursor = Cursors.IBeam;
            tbxAnnouncement.Location = new Point(276, 6);
            tbxAnnouncement.Multiline = true;
            tbxAnnouncement.Name = "tbxAnnouncement";
            tbxAnnouncement.Size = new Size(692, 388);
            tbxAnnouncement.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(tbxEmail);
            tabPage4.Controls.Add(tbxPassword);
            tabPage4.Controls.Add(tbxZIP);
            tabPage4.Controls.Add(tbxAddress);
            tabPage4.Controls.Add(tbxName);
            tabPage4.Controls.Add(tbxMeterNo);
            tabPage4.Controls.Add(btnDeny);
            tabPage4.Controls.Add(btnClear);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(pendingTable);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(974, 402);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pending";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(5, 249);
            label11.Name = "label11";
            label11.Size = new Size(38, 13);
            label11.TabIndex = 34;
            label11.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(3, 206);
            label9.Name = "label9";
            label9.Size = new Size(60, 13);
            label9.TabIndex = 32;
            label9.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(6, 163);
            label8.Name = "label8";
            label8.Size = new Size(27, 13);
            label8.TabIndex = 31;
            label8.Text = "ZIP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(6, 120);
            label7.Name = "label7";
            label7.Size = new Size(52, 13);
            label7.TabIndex = 30;
            label7.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(6, 77);
            label6.Name = "label6";
            label6.Size = new Size(41, 13);
            label6.TabIndex = 29;
            label6.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(6, 34);
            label5.Name = "label5";
            label5.Size = new Size(57, 13);
            label5.TabIndex = 28;
            label5.Text = "MeterNo:";
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.Khaki;
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Cursor = Cursors.IBeam;
            tbxEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.Location = new Point(5, 265);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(302, 24);
            tbxEmail.TabIndex = 27;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.Khaki;
            tbxPassword.BorderStyle = BorderStyle.None;
            tbxPassword.Cursor = Cursors.IBeam;
            tbxPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.Location = new Point(5, 222);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(302, 24);
            tbxPassword.TabIndex = 25;
            // 
            // tbxZIP
            // 
            tbxZIP.BackColor = Color.Khaki;
            tbxZIP.BorderStyle = BorderStyle.None;
            tbxZIP.Cursor = Cursors.IBeam;
            tbxZIP.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxZIP.Location = new Point(5, 179);
            tbxZIP.Name = "tbxZIP";
            tbxZIP.Size = new Size(302, 24);
            tbxZIP.TabIndex = 24;
            // 
            // tbxAddress
            // 
            tbxAddress.BackColor = Color.Khaki;
            tbxAddress.BorderStyle = BorderStyle.None;
            tbxAddress.Cursor = Cursors.IBeam;
            tbxAddress.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAddress.Location = new Point(6, 136);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(302, 24);
            tbxAddress.TabIndex = 23;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.Khaki;
            tbxName.BorderStyle = BorderStyle.None;
            tbxName.Cursor = Cursors.IBeam;
            tbxName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxName.Location = new Point(6, 93);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(302, 24);
            tbxName.TabIndex = 22;
            // 
            // tbxMeterNo
            // 
            tbxMeterNo.BackColor = Color.Khaki;
            tbxMeterNo.BorderStyle = BorderStyle.None;
            tbxMeterNo.Cursor = Cursors.IBeam;
            tbxMeterNo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMeterNo.Location = new Point(6, 50);
            tbxMeterNo.Name = "tbxMeterNo";
            tbxMeterNo.Size = new Size(302, 24);
            tbxMeterNo.TabIndex = 21;
            // 
            // btnDeny
            // 
            btnDeny.BackColor = Color.Gold;
            btnDeny.Cursor = Cursors.Hand;
            btnDeny.FlatStyle = FlatStyle.Flat;
            btnDeny.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeny.ForeColor = Color.DarkRed;
            btnDeny.Location = new Point(118, 359);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(82, 29);
            btnDeny.TabIndex = 20;
            btnDeny.Text = "Deny";
            btnDeny.UseVisualStyleBackColor = false;
            btnDeny.Click += btnDeny_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.DarkRed;
            btnClear.Location = new Point(118, 310);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 29);
            btnClear.TabIndex = 19;
            btnClear.Text = "Allow";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(290, 6);
            button1.Name = "button1";
            button1.Size = new Size(35, 34);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            // 
            // pendingTable
            // 
            pendingTable.BackgroundColor = Color.Maroon;
            pendingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendingTable.GridColor = Color.Khaki;
            pendingTable.Location = new Point(331, 6);
            pendingTable.Name = "pendingTable";
            pendingTable.RowTemplate.Height = 25;
            pendingTable.Size = new Size(637, 382);
            pendingTable.TabIndex = 4;
            pendingTable.CellClick += pendingTable_CellClick;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvuserPaymentHistory);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(974, 402);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Customer Payment History";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnCloseAI
            // 
            btnCloseAI.BackColor = Color.LemonChiffon;
            btnCloseAI.BackgroundImage = (Image)resources.GetObject("btnCloseAI.BackgroundImage");
            btnCloseAI.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseAI.Cursor = Cursors.Hand;
            btnCloseAI.FlatAppearance.BorderSize = 0;
            btnCloseAI.FlatStyle = FlatStyle.Flat;
            btnCloseAI.Location = new Point(933, 12);
            btnCloseAI.Name = "btnCloseAI";
            btnCloseAI.Size = new Size(43, 33);
            btnCloseAI.TabIndex = 2;
            btnCloseAI.UseVisualStyleBackColor = false;
            btnCloseAI.Click += btnCloseAI_Click;
            // 
            // btnLogoutAI
            // 
            btnLogoutAI.BackgroundImage = (Image)resources.GetObject("btnLogoutAI.BackgroundImage");
            btnLogoutAI.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogoutAI.Cursor = Cursors.Hand;
            btnLogoutAI.FlatAppearance.BorderSize = 0;
            btnLogoutAI.FlatStyle = FlatStyle.Flat;
            btnLogoutAI.Location = new Point(885, 13);
            btnLogoutAI.Name = "btnLogoutAI";
            btnLogoutAI.Size = new Size(30, 32);
            btnLogoutAI.TabIndex = 3;
            btnLogoutAI.UseVisualStyleBackColor = true;
            btnLogoutAI.Click += btnLogoutAI_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft PhagsPa", 48F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(136, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 82);
            textBox1.TabIndex = 18;
            textBox1.TabStop = false;
            textBox1.Text = "NECO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvuserPaymentHistory
            // 
            dgvuserPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvuserPaymentHistory.Location = new Point(6, 6);
            dgvuserPaymentHistory.Name = "dgvuserPaymentHistory";
            dgvuserPaymentHistory.RowTemplate.Height = 25;
            dgvuserPaymentHistory.Size = new Size(962, 390);
            dgvuserPaymentHistory.TabIndex = 0;
            // 
            // AdminInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(988, 587);
            Controls.Add(textBox1);
            Controls.Add(btnLogoutAI);
            Controls.Add(btnCloseAI);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "v";
            Load += AdminInterface_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDB).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pendingTable).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvuserPaymentHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnChange;
        private Label label1;
        private TextBox tbxDueDate;
        private Button btnUpdate;
        private Label label2;
        private TextBox tbxKWH;
        private DataGridView dgvDB;
        private Button btnCloseAI;
        private Button btnLogoutAI;
        private TabPage tabPage3;
        private Button btnSave;
        private Label label3;
        private TextBox tbxAnnouncement;
        private Button btnDB;
        private Label label4;
        private TextBox tbxATP;
        private TabPage tabPage4;
        private DataGridView pendingTable;
        private Button button1;
        private Button btnDeny;
        private Button btnClear;
        private TextBox tbxPassword;
        private TextBox tbxZIP;
        private TextBox tbxAddress;
        private TextBox tbxName;
        private TextBox tbxMeterNo;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbxEmail;
        private Label label11;
        private Label label9;
        private Label label8;
        private TextBox textBox1;
        private TabPage tabPage5;
        private DataGridView dgvuserPaymentHistory;
    }
}