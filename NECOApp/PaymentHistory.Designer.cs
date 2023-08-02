namespace NECOApp
{
    partial class PaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHistory));
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            btnLogoutUI = new Button();
            btnCloseRegister = new Button();
            dgvPayHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayHistory).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft PhagsPa", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Maroon;
            textBox1.Location = new Point(109, 67);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(165, 62);
            textBox1.TabIndex = 14;
            textBox1.TabStop = false;
            textBox1.Text = "NECO";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-50, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft PhagsPa", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Maroon;
            textBox2.Location = new Point(255, 149);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(496, 62);
            textBox2.TabIndex = 15;
            textBox2.TabStop = false;
            textBox2.Text = "PAYMENT HISTORY";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogoutUI
            // 
            btnLogoutUI.BackColor = Color.Transparent;
            btnLogoutUI.BackgroundImage = (Image)resources.GetObject("btnLogoutUI.BackgroundImage");
            btnLogoutUI.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogoutUI.FlatAppearance.BorderSize = 0;
            btnLogoutUI.FlatStyle = FlatStyle.Flat;
            btnLogoutUI.Location = new Point(885, 14);
            btnLogoutUI.Name = "btnLogoutUI";
            btnLogoutUI.Size = new Size(33, 34);
            btnLogoutUI.TabIndex = 51;
            btnLogoutUI.UseVisualStyleBackColor = false;
            btnLogoutUI.MouseClick += btnLogoutUI_MouseClick;
            // 
            // btnCloseRegister
            // 
            btnCloseRegister.BackgroundImage = (Image)resources.GetObject("btnCloseRegister.BackgroundImage");
            btnCloseRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnCloseRegister.Cursor = Cursors.Hand;
            btnCloseRegister.FlatAppearance.BorderSize = 0;
            btnCloseRegister.FlatStyle = FlatStyle.Flat;
            btnCloseRegister.Location = new Point(936, 12);
            btnCloseRegister.Name = "btnCloseRegister";
            btnCloseRegister.Size = new Size(40, 39);
            btnCloseRegister.TabIndex = 50;
            btnCloseRegister.UseVisualStyleBackColor = true;
            btnCloseRegister.MouseClick += btnCloseRegister_MouseClick;
            // 
            // dgvPayHistory
            // 
            dgvPayHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayHistory.Location = new Point(34, 231);
            dgvPayHistory.Name = "dgvPayHistory";
            dgvPayHistory.RowTemplate.Height = 25;
            dgvPayHistory.Size = new Size(922, 324);
            dgvPayHistory.TabIndex = 52;
            // 
            // PaymentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(988, 587);
            Controls.Add(dgvPayHistory);
            Controls.Add(btnLogoutUI);
            Controls.Add(btnCloseRegister);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentHistory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Button btnLogoutUI;
        private Button btnCloseRegister;
        public DataGridView dgvPayHistory;
    }
}