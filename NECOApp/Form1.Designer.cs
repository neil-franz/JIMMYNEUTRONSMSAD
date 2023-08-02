namespace NECOApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btnCloseApp = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            tbxMeterNo = new TextBox();
            tbxPassword = new TextBox();
            cbxShowPass = new CheckBox();
            btnLogin = new Button();
            textBox5 = new TextBox();
            lnkRegister = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-21, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "NECO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
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
            btnCloseApp.TabIndex = 2;
            btnCloseApp.UseVisualStyleBackColor = false;
            btnCloseApp.Click += btnCloseApp_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Malgun Gothic", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.DarkRed;
            textBox2.Location = new Point(35, 191);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(99, 34);
            textBox2.TabIndex = 3;
            textBox2.TabStop = false;
            textBox2.Text = "LOG-IN";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LemonChiffon;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.DarkRed;
            textBox3.Location = new Point(35, 267);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(144, 23);
            textBox3.TabIndex = 4;
            textBox3.TabStop = false;
            textBox3.Text = "Meter No: ";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LemonChiffon;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.DarkRed;
            textBox4.Location = new Point(35, 325);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 5;
            textBox4.TabStop = false;
            textBox4.Text = "Password: ";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxMeterNo
            // 
            tbxMeterNo.BackColor = Color.White;
            tbxMeterNo.Cursor = Cursors.IBeam;
            tbxMeterNo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMeterNo.ForeColor = Color.Black;
            tbxMeterNo.Location = new Point(162, 257);
            tbxMeterNo.Multiline = true;
            tbxMeterNo.Name = "tbxMeterNo";
            tbxMeterNo.Size = new Size(188, 33);
            tbxMeterNo.TabIndex = 6;
            tbxMeterNo.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.White;
            tbxPassword.Cursor = Cursors.IBeam;
            tbxPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.ForeColor = Color.Black;
            tbxPassword.Location = new Point(162, 315);
            tbxPassword.Multiline = true;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(188, 33);
            tbxPassword.TabIndex = 7;
            tbxPassword.TextAlign = HorizontalAlignment.Right;
            // 
            // cbxShowPass
            // 
            cbxShowPass.AutoSize = true;
            cbxShowPass.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbxShowPass.ForeColor = Color.Firebrick;
            cbxShowPass.Location = new Point(258, 364);
            cbxShowPass.Name = "cbxShowPass";
            cbxShowPass.Size = new Size(117, 19);
            cbxShowPass.TabIndex = 9;
            cbxShowPass.Text = "Show Password";
            cbxShowPass.UseVisualStyleBackColor = true;
            cbxShowPass.CheckedChanged += cbxShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gold;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.DarkRed;
            btnLogin.Location = new Point(162, 471);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(109, 38);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Log-in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LemonChiffon;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.DarkRed;
            textBox5.Location = new Point(118, 405);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(144, 16);
            textBox5.TabIndex = 11;
            textBox5.TabStop = false;
            textBox5.Text = "Don't have an account?";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lnkRegister.Location = new Point(258, 405);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(50, 15);
            lnkRegister.TabIndex = 12;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Sign-up";
            lnkRegister.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(405, 543);
            Controls.Add(lnkRegister);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(btnLogin);
            Controls.Add(cbxShowPass);
            Controls.Add(tbxPassword);
            Controls.Add(tbxMeterNo);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btnCloseApp);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnCloseApp;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox tbxMeterNo;
        private TextBox tbxPassword;
        private CheckBox cbxShowPass;
        private Button btnLogin;
        private TextBox textBox5;
        private LinkLabel lnkRegister;
    }
}