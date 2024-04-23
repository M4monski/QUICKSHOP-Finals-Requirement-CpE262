namespace Finals_Requirement_CpE262
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            pictureBox1 = new PictureBox();
            LBL_FPASS = new Label();
            Tbox_FPASSPASS = new TextBox();
            Tbox_FPASSUSER = new TextBox();
            LBL_FPASSNEW = new Label();
            LBL_FPASSUSER = new Label();
            Tbox_FPASSPIN = new TextBox();
            LBL_FPASSPIN = new Label();
            BUT_CHANGEPASS = new Button();
            But_FPASSBACK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(145, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LBL_FPASS
            // 
            LBL_FPASS.AutoSize = true;
            LBL_FPASS.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_FPASS.Location = new Point(103, 142);
            LBL_FPASS.Name = "LBL_FPASS";
            LBL_FPASS.Size = new Size(191, 72);
            LBL_FPASS.TabIndex = 1;
            LBL_FPASS.Text = "FORGOT\r\nPASSWORD\r\n";
            LBL_FPASS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tbox_FPASSPASS
            // 
            Tbox_FPASSPASS.Location = new Point(86, 365);
            Tbox_FPASSPASS.Name = "Tbox_FPASSPASS";
            Tbox_FPASSPASS.Size = new Size(238, 27);
            Tbox_FPASSPASS.TabIndex = 9;
            Tbox_FPASSPASS.UseSystemPasswordChar = true;
            // 
            // Tbox_FPASSUSER
            // 
            Tbox_FPASSUSER.Location = new Point(82, 244);
            Tbox_FPASSUSER.Name = "Tbox_FPASSUSER";
            Tbox_FPASSUSER.Size = new Size(238, 27);
            Tbox_FPASSUSER.TabIndex = 8;
            // 
            // LBL_FPASSNEW
            // 
            LBL_FPASSNEW.AutoSize = true;
            LBL_FPASSNEW.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSNEW.Location = new Point(148, 343);
            LBL_FPASSNEW.Name = "LBL_FPASSNEW";
            LBL_FPASSNEW.Size = new Size(115, 19);
            LBL_FPASSNEW.TabIndex = 7;
            LBL_FPASSNEW.Text = "New Password";
            // 
            // LBL_FPASSUSER
            // 
            LBL_FPASSUSER.AutoSize = true;
            LBL_FPASSUSER.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSUSER.Location = new Point(160, 224);
            LBL_FPASSUSER.Name = "LBL_FPASSUSER";
            LBL_FPASSUSER.Size = new Size(82, 19);
            LBL_FPASSUSER.TabIndex = 6;
            LBL_FPASSUSER.Text = "Username";
            // 
            // Tbox_FPASSPIN
            // 
            Tbox_FPASSPIN.Location = new Point(82, 306);
            Tbox_FPASSPIN.Name = "Tbox_FPASSPIN";
            Tbox_FPASSPIN.Size = new Size(238, 27);
            Tbox_FPASSPIN.TabIndex = 11;
            Tbox_FPASSPIN.UseSystemPasswordChar = true;
            // 
            // LBL_FPASSPIN
            // 
            LBL_FPASSPIN.AutoSize = true;
            LBL_FPASSPIN.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSPIN.Location = new Point(115, 284);
            LBL_FPASSPIN.Name = "LBL_FPASSPIN";
            LBL_FPASSPIN.Size = new Size(173, 19);
            LBL_FPASSPIN.TabIndex = 10;
            LBL_FPASSPIN.Text = "6-DIGIT SECURITY PIN";
            // 
            // BUT_CHANGEPASS
            // 
            BUT_CHANGEPASS.Font = new Font("Inter", 9F);
            BUT_CHANGEPASS.Location = new Point(148, 398);
            BUT_CHANGEPASS.Name = "BUT_CHANGEPASS";
            BUT_CHANGEPASS.Size = new Size(103, 48);
            BUT_CHANGEPASS.TabIndex = 13;
            BUT_CHANGEPASS.Text = "Change";
            BUT_CHANGEPASS.UseVisualStyleBackColor = true;
            BUT_CHANGEPASS.Click += BUT_CHANGEPASS_Click;
            // 
            // But_FPASSBACK
            // 
            But_FPASSBACK.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            But_FPASSBACK.Location = new Point(269, 441);
            But_FPASSBACK.Name = "But_FPASSBACK";
            But_FPASSBACK.Size = new Size(115, 53);
            But_FPASSBACK.TabIndex = 14;
            But_FPASSBACK.Text = "Back";
            But_FPASSBACK.UseVisualStyleBackColor = true;
            But_FPASSBACK.Click += But_FPASSBACK_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(396, 506);
            Controls.Add(But_FPASSBACK);
            Controls.Add(BUT_CHANGEPASS);
            Controls.Add(Tbox_FPASSPIN);
            Controls.Add(LBL_FPASSPIN);
            Controls.Add(Tbox_FPASSPASS);
            Controls.Add(Tbox_FPASSUSER);
            Controls.Add(LBL_FPASSNEW);
            Controls.Add(LBL_FPASSUSER);
            Controls.Add(LBL_FPASS);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LBL_FPASS;
        private TextBox Tbox_FPASSPASS;
        private TextBox Tbox_FPASSUSER;
        private Label LBL_FPASSNEW;
        private Label LBL_FPASSUSER;
        private TextBox Tbox_FPASSPIN;
        private Label LBL_FPASSPIN;
        private Button BUT_CHANGEPASS;
        private Button But_FPASSBACK;
    }
}