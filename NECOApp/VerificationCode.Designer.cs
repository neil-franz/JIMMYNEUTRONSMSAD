namespace NECOApp
{
    partial class VerificationCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationCode));
            pictureBox1 = new PictureBox();
            tbxPIN = new TextBox();
            textBox3 = new TextBox();
            btnProceed = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // tbxPIN
            // 
            tbxPIN.BackColor = Color.White;
            tbxPIN.Cursor = Cursors.IBeam;
            tbxPIN.Font = new Font("Malgun Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPIN.Location = new Point(53, 230);
            tbxPIN.Name = "tbxPIN";
            tbxPIN.Size = new Size(308, 71);
            tbxPIN.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LemonChiffon;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft PhagsPa", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Maroon;
            textBox3.Location = new Point(31, 173);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(340, 38);
            textBox3.TabIndex = 19;
            textBox3.TabStop = false;
            textBox3.Text = "ENTER YOUR PIN";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.Gold;
            btnProceed.FlatStyle = FlatStyle.Flat;
            btnProceed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProceed.ForeColor = Color.DarkRed;
            btnProceed.Location = new Point(134, 319);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(145, 44);
            btnProceed.TabIndex = 20;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // VerificationCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(405, 385);
            Controls.Add(btnProceed);
            Controls.Add(textBox3);
            Controls.Add(tbxPIN);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerificationCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerificationCode";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox tbxPIN;
        private TextBox textBox3;
        private Button btnProceed;
    }
}