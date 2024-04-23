namespace Finals_Requirement_CpE262
{
    partial class DeleteAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAdmin));
            But_DeleteBack = new Button();
            But_DeleteAccount = new Button();
            Tbox_DeletePIN = new TextBox();
            LBL_FPASSPIN = new Label();
            Tbox_DeletePass = new TextBox();
            Tbox_DeleteUser = new TextBox();
            LBL_FPASSNEW = new Label();
            LBL_FPASSUSER = new Label();
            LBL_DELETEACCOUNT = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // But_DeleteBack
            // 
            But_DeleteBack.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            But_DeleteBack.Location = new Point(269, 441);
            But_DeleteBack.Name = "But_DeleteBack";
            But_DeleteBack.Size = new Size(115, 53);
            But_DeleteBack.TabIndex = 34;
            But_DeleteBack.Text = "Back";
            But_DeleteBack.UseVisualStyleBackColor = true;
            But_DeleteBack.Click += But_DeleteBack_Click;
            // 
            // But_DeleteAccount
            // 
            But_DeleteAccount.Font = new Font("Inter", 9F);
            But_DeleteAccount.Location = new Point(143, 376);
            But_DeleteAccount.Name = "But_DeleteAccount";
            But_DeleteAccount.Size = new Size(103, 48);
            But_DeleteAccount.TabIndex = 33;
            But_DeleteAccount.Text = "Delete Account";
            But_DeleteAccount.UseVisualStyleBackColor = true;
            But_DeleteAccount.Click += But_DeleteAccount_Click;
            // 
            // Tbox_DeletePIN
            // 
            Tbox_DeletePIN.Location = new Point(78, 343);
            Tbox_DeletePIN.Name = "Tbox_DeletePIN";
            Tbox_DeletePIN.Size = new Size(238, 27);
            Tbox_DeletePIN.TabIndex = 32;
            Tbox_DeletePIN.UseSystemPasswordChar = true;
            // 
            // LBL_FPASSPIN
            // 
            LBL_FPASSPIN.AutoSize = true;
            LBL_FPASSPIN.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSPIN.Location = new Point(111, 321);
            LBL_FPASSPIN.Name = "LBL_FPASSPIN";
            LBL_FPASSPIN.Size = new Size(173, 19);
            LBL_FPASSPIN.TabIndex = 31;
            LBL_FPASSPIN.Text = "6-DIGIT SECURITY PIN";
            // 
            // Tbox_DeletePass
            // 
            Tbox_DeletePass.Location = new Point(78, 278);
            Tbox_DeletePass.Name = "Tbox_DeletePass";
            Tbox_DeletePass.Size = new Size(238, 27);
            Tbox_DeletePass.TabIndex = 30;
            Tbox_DeletePass.UseSystemPasswordChar = true;
            // 
            // Tbox_DeleteUser
            // 
            Tbox_DeleteUser.Location = new Point(78, 214);
            Tbox_DeleteUser.Name = "Tbox_DeleteUser";
            Tbox_DeleteUser.Size = new Size(238, 27);
            Tbox_DeleteUser.TabIndex = 29;
            // 
            // LBL_FPASSNEW
            // 
            LBL_FPASSNEW.AutoSize = true;
            LBL_FPASSNEW.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSNEW.Location = new Point(156, 256);
            LBL_FPASSNEW.Name = "LBL_FPASSNEW";
            LBL_FPASSNEW.Size = new Size(79, 19);
            LBL_FPASSNEW.TabIndex = 28;
            LBL_FPASSNEW.Text = "Password";
            // 
            // LBL_FPASSUSER
            // 
            LBL_FPASSUSER.AutoSize = true;
            LBL_FPASSUSER.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSUSER.Location = new Point(156, 194);
            LBL_FPASSUSER.Name = "LBL_FPASSUSER";
            LBL_FPASSUSER.Size = new Size(82, 19);
            LBL_FPASSUSER.TabIndex = 27;
            LBL_FPASSUSER.Text = "Username";
            // 
            // LBL_DELETEACCOUNT
            // 
            LBL_DELETEACCOUNT.AutoSize = true;
            LBL_DELETEACCOUNT.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_DELETEACCOUNT.Location = new Point(48, 135);
            LBL_DELETEACCOUNT.Name = "LBL_DELETEACCOUNT";
            LBL_DELETEACCOUNT.Size = new Size(301, 36);
            LBL_DELETEACCOUNT.TabIndex = 26;
            LBL_DELETEACCOUNT.Text = "DELETE ACCOUNT";
            LBL_DELETEACCOUNT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(140, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 109);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // DeleteAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(396, 506);
            Controls.Add(But_DeleteBack);
            Controls.Add(But_DeleteAccount);
            Controls.Add(Tbox_DeletePIN);
            Controls.Add(LBL_FPASSPIN);
            Controls.Add(Tbox_DeletePass);
            Controls.Add(Tbox_DeleteUser);
            Controls.Add(LBL_FPASSNEW);
            Controls.Add(LBL_FPASSUSER);
            Controls.Add(LBL_DELETEACCOUNT);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteAdmin";
            Load += DeleteAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button But_DeleteBack;
        private Button But_DeleteAccount;
        private TextBox Tbox_DeletePIN;
        private Label LBL_FPASSPIN;
        private TextBox Tbox_DeletePass;
        private TextBox Tbox_DeleteUser;
        private Label LBL_FPASSNEW;
        private Label LBL_FPASSUSER;
        private Label LBL_DELETEACCOUNT;
        private PictureBox pictureBox1;
    }
}