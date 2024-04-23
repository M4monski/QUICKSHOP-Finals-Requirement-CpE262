namespace Finals_Requirement_CpE262
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            But_AddBack = new Button();
            But_AddAccount = new Button();
            Tbox_AddPIN = new TextBox();
            LBL_FPASSPIN = new Label();
            Tbox_AddPass = new TextBox();
            Tbox_AddUser = new TextBox();
            LBL_FPASSNEW = new Label();
            LBL_FPASSUSER = new Label();
            LBL_FPASS = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // But_AddBack
            // 
            But_AddBack.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            But_AddBack.Location = new Point(269, 441);
            But_AddBack.Name = "But_AddBack";
            But_AddBack.Size = new Size(115, 53);
            But_AddBack.TabIndex = 24;
            But_AddBack.Text = "Back";
            But_AddBack.UseVisualStyleBackColor = true;
            But_AddBack.Click += But_AddBack_Click;
            // 
            // But_AddAccount
            // 
            But_AddAccount.Font = new Font("Inter", 9F);
            But_AddAccount.Location = new Point(143, 378);
            But_AddAccount.Name = "But_AddAccount";
            But_AddAccount.Size = new Size(103, 48);
            But_AddAccount.TabIndex = 23;
            But_AddAccount.Text = "Add Account";
            But_AddAccount.UseVisualStyleBackColor = true;
            But_AddAccount.Click += But_AddAccount_Click;
            // 
            // Tbox_AddPIN
            // 
            Tbox_AddPIN.Location = new Point(78, 345);
            Tbox_AddPIN.Name = "Tbox_AddPIN";
            Tbox_AddPIN.Size = new Size(238, 27);
            Tbox_AddPIN.TabIndex = 22;
            // 
            // LBL_FPASSPIN
            // 
            LBL_FPASSPIN.AutoSize = true;
            LBL_FPASSPIN.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSPIN.Location = new Point(111, 323);
            LBL_FPASSPIN.Name = "LBL_FPASSPIN";
            LBL_FPASSPIN.Size = new Size(173, 19);
            LBL_FPASSPIN.TabIndex = 21;
            LBL_FPASSPIN.Text = "6-DIGIT SECURITY PIN";
            // 
            // Tbox_AddPass
            // 
            Tbox_AddPass.Location = new Point(78, 280);
            Tbox_AddPass.Name = "Tbox_AddPass";
            Tbox_AddPass.Size = new Size(238, 27);
            Tbox_AddPass.TabIndex = 20;
            // 
            // Tbox_AddUser
            // 
            Tbox_AddUser.Location = new Point(78, 216);
            Tbox_AddUser.Name = "Tbox_AddUser";
            Tbox_AddUser.Size = new Size(238, 27);
            Tbox_AddUser.TabIndex = 19;
            // 
            // LBL_FPASSNEW
            // 
            LBL_FPASSNEW.AutoSize = true;
            LBL_FPASSNEW.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSNEW.Location = new Point(156, 258);
            LBL_FPASSNEW.Name = "LBL_FPASSNEW";
            LBL_FPASSNEW.Size = new Size(79, 19);
            LBL_FPASSNEW.TabIndex = 18;
            LBL_FPASSNEW.Text = "Password";
            // 
            // LBL_FPASSUSER
            // 
            LBL_FPASSUSER.AutoSize = true;
            LBL_FPASSUSER.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_FPASSUSER.Location = new Point(156, 196);
            LBL_FPASSUSER.Name = "LBL_FPASSUSER";
            LBL_FPASSUSER.Size = new Size(82, 19);
            LBL_FPASSUSER.TabIndex = 17;
            LBL_FPASSUSER.Text = "Username";
            // 
            // LBL_FPASS
            // 
            LBL_FPASS.AutoSize = true;
            LBL_FPASS.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_FPASS.Location = new Point(73, 137);
            LBL_FPASS.Name = "LBL_FPASS";
            LBL_FPASS.Size = new Size(250, 36);
            LBL_FPASS.TabIndex = 16;
            LBL_FPASS.Text = "ADD ACCOUNT";
            LBL_FPASS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(140, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 109);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(396, 506);
            Controls.Add(But_AddBack);
            Controls.Add(But_AddAccount);
            Controls.Add(Tbox_AddPIN);
            Controls.Add(LBL_FPASSPIN);
            Controls.Add(Tbox_AddPass);
            Controls.Add(Tbox_AddUser);
            Controls.Add(LBL_FPASSNEW);
            Controls.Add(LBL_FPASSUSER);
            Controls.Add(LBL_FPASS);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button But_AddBack;
        private Button But_AddAccount;
        private TextBox Tbox_AddPIN;
        private Label LBL_FPASSPIN;
        private TextBox Tbox_AddPass;
        private TextBox Tbox_AddUser;
        private Label LBL_FPASSNEW;
        private Label LBL_FPASSUSER;
        private Label LBL_FPASS;
        private PictureBox pictureBox1;
    }
}