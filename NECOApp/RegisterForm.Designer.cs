namespace NECOApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btnCloseRegister = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbxMetNum = new TextBox();
            tbxPass = new TextBox();
            tbxConPass = new TextBox();
            tbxName = new TextBox();
            tbxAddress = new TextBox();
            cbxShowPass = new CheckBox();
            btnRegister = new Button();
            btnClear = new Button();
            tbxZIP = new TextBox();
            tbxEmail = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-21, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft PhagsPa", 48F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(189, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 82);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "NECO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnCloseRegister
            // 
            btnCloseRegister.BackgroundImage = (Image)resources.GetObject("btnCloseRegister.BackgroundImage");
            btnCloseRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseRegister.Cursor = Cursors.Hand;
            btnCloseRegister.FlatAppearance.BorderSize = 0;
            btnCloseRegister.FlatStyle = FlatStyle.Flat;
            btnCloseRegister.Location = new Point(487, 12);
            btnCloseRegister.Name = "btnCloseRegister";
            btnCloseRegister.Size = new Size(40, 39);
            btnCloseRegister.TabIndex = 2;
            btnCloseRegister.UseVisualStyleBackColor = true;
            btnCloseRegister.Click += btnCloseRegister_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Maroon;
            textBox2.Location = new Point(182, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 36);
            textBox2.TabIndex = 3;
            textBox2.TabStop = false;
            textBox2.Text = "REGISTER";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(132, 378);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 4;
            label1.Text = "Meter No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(134, 473);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(61, 523);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(163, 227);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 7;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(145, 279);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 8;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(136, 329);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 9;
            label6.Text = "ZIP Code: ";
            // 
            // tbxMetNum
            // 
            tbxMetNum.BackColor = Color.White;
            tbxMetNum.Cursor = Cursors.IBeam;
            tbxMetNum.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMetNum.Location = new Point(232, 371);
            tbxMetNum.Name = "tbxMetNum";
            tbxMetNum.Size = new Size(220, 30);
            tbxMetNum.TabIndex = 10;
            // 
            // tbxPass
            // 
            tbxPass.BackColor = Color.White;
            tbxPass.Cursor = Cursors.IBeam;
            tbxPass.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPass.Location = new Point(232, 466);
            tbxPass.Name = "tbxPass";
            tbxPass.PasswordChar = '*';
            tbxPass.Size = new Size(220, 30);
            tbxPass.TabIndex = 11;
            // 
            // tbxConPass
            // 
            tbxConPass.BackColor = Color.White;
            tbxConPass.Cursor = Cursors.IBeam;
            tbxConPass.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxConPass.Location = new Point(232, 516);
            tbxConPass.Name = "tbxConPass";
            tbxConPass.PasswordChar = '*';
            tbxConPass.Size = new Size(220, 30);
            tbxConPass.TabIndex = 12;
            // 
            // tbxName
            // 
            tbxName.BackColor = Color.White;
            tbxName.Cursor = Cursors.IBeam;
            tbxName.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxName.Location = new Point(232, 220);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(220, 30);
            tbxName.TabIndex = 13;
            // 
            // tbxAddress
            // 
            tbxAddress.BackColor = Color.White;
            tbxAddress.Cursor = Cursors.IBeam;
            tbxAddress.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAddress.Location = new Point(232, 272);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(220, 30);
            tbxAddress.TabIndex = 14;
            // 
            // cbxShowPass
            // 
            cbxShowPass.AutoSize = true;
            cbxShowPass.Font = new Font("Leelawadee", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbxShowPass.ForeColor = Color.Firebrick;
            cbxShowPass.Location = new Point(374, 561);
            cbxShowPass.Name = "cbxShowPass";
            cbxShowPass.Size = new Size(112, 18);
            cbxShowPass.TabIndex = 16;
            cbxShowPass.Text = "Show Password";
            cbxShowPass.UseVisualStyleBackColor = true;
            cbxShowPass.CheckedChanged += cbxShowPass_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gold;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.DarkRed;
            btnRegister.Location = new Point(356, 597);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(96, 42);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.DarkRed;
            btnClear.Location = new Point(129, 597);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 42);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tbxZIP
            // 
            tbxZIP.BackColor = Color.White;
            tbxZIP.Cursor = Cursors.IBeam;
            tbxZIP.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxZIP.Location = new Point(232, 322);
            tbxZIP.Name = "tbxZIP";
            tbxZIP.Size = new Size(220, 30);
            tbxZIP.TabIndex = 19;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.White;
            tbxEmail.Cursor = Cursors.IBeam;
            tbxEmail.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.Location = new Point(232, 420);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(220, 30);
            tbxEmail.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(167, 420);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 23;
            label8.Text = "Email:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(539, 655);
            Controls.Add(label8);
            Controls.Add(tbxEmail);
            Controls.Add(tbxZIP);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(cbxShowPass);
            Controls.Add(tbxAddress);
            Controls.Add(tbxName);
            Controls.Add(tbxConPass);
            Controls.Add(tbxPass);
            Controls.Add(tbxMetNum);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btnCloseRegister);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnCloseRegister;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbxMetNum;
        private TextBox tbxPass;
        private TextBox tbxConPass;
        private TextBox tbxName;
        private TextBox tbxAddress;
        private CheckBox cbxShowPass;
        private Button btnRegister;
        private Button btnClear;
        private TextBox tbxZIP;
        private TextBox tbxEmail;
        private Label label8;
    }
}