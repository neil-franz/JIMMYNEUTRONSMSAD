namespace NECOApp
{
    partial class Usercheckin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usercheckin));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxDatein = new TextBox();
            tbxAdminAdd = new TextBox();
            tbxAdminName = new TextBox();
            tbxCheckin = new TextBox();
            btnRegisterAdmin = new Button();
            btnCloseCheckin = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(33, 82);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(33, 134);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Address: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(33, 187);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Date: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(33, 237);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 4;
            label5.Text = "Check-in Time:";
            // 
            // tbxDatein
            // 
            tbxDatein.BackColor = Color.White;
            tbxDatein.Cursor = Cursors.IBeam;
            tbxDatein.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDatein.ForeColor = Color.Black;
            tbxDatein.Location = new Point(176, 188);
            tbxDatein.Name = "tbxDatein";
            tbxDatein.PlaceholderText = "mm/dd/yyyy";
            tbxDatein.Size = new Size(216, 31);
            tbxDatein.TabIndex = 6;
            tbxDatein.TabStop = false;
            // 
            // tbxAdminAdd
            // 
            tbxAdminAdd.BackColor = Color.White;
            tbxAdminAdd.Cursor = Cursors.IBeam;
            tbxAdminAdd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAdminAdd.ForeColor = Color.Black;
            tbxAdminAdd.Location = new Point(176, 134);
            tbxAdminAdd.Name = "tbxAdminAdd";
            tbxAdminAdd.Size = new Size(216, 31);
            tbxAdminAdd.TabIndex = 7;
            // 
            // tbxAdminName
            // 
            tbxAdminName.BackColor = Color.White;
            tbxAdminName.Cursor = Cursors.IBeam;
            tbxAdminName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAdminName.ForeColor = Color.Black;
            tbxAdminName.Location = new Point(176, 82);
            tbxAdminName.Name = "tbxAdminName";
            tbxAdminName.Size = new Size(216, 31);
            tbxAdminName.TabIndex = 8;
            // 
            // tbxCheckin
            // 
            tbxCheckin.BackColor = Color.White;
            tbxCheckin.Cursor = Cursors.IBeam;
            tbxCheckin.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxCheckin.ForeColor = Color.Black;
            tbxCheckin.Location = new Point(176, 237);
            tbxCheckin.Name = "tbxCheckin";
            tbxCheckin.PlaceholderText = "hour : min am/pm";
            tbxCheckin.Size = new Size(216, 31);
            tbxCheckin.TabIndex = 5;
            tbxCheckin.TabStop = false;
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.BackColor = Color.Gold;
            btnRegisterAdmin.Cursor = Cursors.Hand;
            btnRegisterAdmin.FlatStyle = FlatStyle.Flat;
            btnRegisterAdmin.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterAdmin.ForeColor = Color.DarkRed;
            btnRegisterAdmin.Location = new Point(144, 288);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(119, 40);
            btnRegisterAdmin.TabIndex = 9;
            btnRegisterAdmin.Text = "Check-in";
            btnRegisterAdmin.UseVisualStyleBackColor = false;
            btnRegisterAdmin.Click += btnRegisterAdmin_Click;
            // 
            // btnCloseCheckin
            // 
            btnCloseCheckin.BackgroundImage = (Image)resources.GetObject("btnCloseCheckin.BackgroundImage");
            btnCloseCheckin.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseCheckin.Cursor = Cursors.Hand;
            btnCloseCheckin.FlatAppearance.BorderSize = 0;
            btnCloseCheckin.FlatStyle = FlatStyle.Flat;
            btnCloseCheckin.Location = new Point(364, 0);
            btnCloseCheckin.Name = "btnCloseCheckin";
            btnCloseCheckin.Size = new Size(42, 38);
            btnCloseCheckin.TabIndex = 10;
            btnCloseCheckin.UseVisualStyleBackColor = true;
            btnCloseCheckin.Click += btnCloseCheckin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 25);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "Admin Check-in ";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Malgun Gothic", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.DarkRed;
            textBox2.Location = new Point(73, 14);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(255, 34);
            textBox2.TabIndex = 15;
            textBox2.TabStop = false;
            textBox2.Text = "ADMIN CHECK - IN";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Usercheckin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(406, 359);
            Controls.Add(textBox2);
            Controls.Add(btnCloseCheckin);
            Controls.Add(btnRegisterAdmin);
            Controls.Add(tbxAdminName);
            Controls.Add(tbxAdminAdd);
            Controls.Add(tbxDatein);
            Controls.Add(tbxCheckin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usercheckin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usercheckin";
            Load += Usercheckin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxDatein;
        private TextBox tbxAdminAdd;
        private TextBox tbxAdminName;
        private TextBox tbxCheckin;
        private Button btnRegisterAdmin;
        private Button btnCloseCheckin;
        private Label label1;
        private TextBox textBox2;
    }
}