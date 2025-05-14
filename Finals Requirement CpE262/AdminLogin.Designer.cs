namespace Finals_Requirement_CpE262
{
    partial class AdminLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LBL_LOGIN = new Label();
            LBL_HELLOADMIN = new Label();
            LBL_USERNAME = new Label();
            LBL_PASSWORD = new Label();
            Tbox_AdminUser = new TextBox();
            Tbox_AdminPass = new TextBox();
            But_AdminLOGIN = new Button();
            LLBL_AdminFPass = new LinkLabel();
            But_ReturnLogin = new Button();
            G2But_ViewPass = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // LBL_LOGIN
            // 
            LBL_LOGIN.AutoSize = true;
            LBL_LOGIN.Font = new Font("Inter Black", 20F, FontStyle.Bold);
            LBL_LOGIN.Location = new Point(73, 130);
            LBL_LOGIN.Name = "LBL_LOGIN";
            LBL_LOGIN.Size = new Size(112, 41);
            LBL_LOGIN.TabIndex = 0;
            LBL_LOGIN.Text = "Login";
            // 
            // LBL_HELLOADMIN
            // 
            LBL_HELLOADMIN.AutoSize = true;
            LBL_HELLOADMIN.Font = new Font("Inter", 10F);
            LBL_HELLOADMIN.ForeColor = SystemColors.ControlDarkDark;
            LBL_HELLOADMIN.Location = new Point(73, 171);
            LBL_HELLOADMIN.Name = "LBL_HELLOADMIN";
            LBL_HELLOADMIN.Size = new Size(218, 20);
            LBL_HELLOADMIN.TabIndex = 1;
            LBL_HELLOADMIN.Text = "Hello Admin, please login!";
            // 
            // LBL_USERNAME
            // 
            LBL_USERNAME.AutoSize = true;
            LBL_USERNAME.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_USERNAME.Location = new Point(147, 221);
            LBL_USERNAME.Name = "LBL_USERNAME";
            LBL_USERNAME.Size = new Size(82, 19);
            LBL_USERNAME.TabIndex = 2;
            LBL_USERNAME.Text = "Username";
            // 
            // LBL_PASSWORD
            // 
            LBL_PASSWORD.AutoSize = true;
            LBL_PASSWORD.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_PASSWORD.Location = new Point(147, 294);
            LBL_PASSWORD.Name = "LBL_PASSWORD";
            LBL_PASSWORD.Size = new Size(79, 19);
            LBL_PASSWORD.TabIndex = 3;
            LBL_PASSWORD.Text = "Password";
            // 
            // Tbox_AdminUser
            // 
            Tbox_AdminUser.Location = new Point(147, 241);
            Tbox_AdminUser.Name = "Tbox_AdminUser";
            Tbox_AdminUser.Size = new Size(238, 27);
            Tbox_AdminUser.TabIndex = 4;
            Tbox_AdminUser.TextChanged += Tbox_AdminUser_TextChanged;
            // 
            // Tbox_AdminPass
            // 
            Tbox_AdminPass.Location = new Point(147, 316);
            Tbox_AdminPass.Name = "Tbox_AdminPass";
            Tbox_AdminPass.Size = new Size(238, 27);
            Tbox_AdminPass.TabIndex = 5;
            Tbox_AdminPass.UseSystemPasswordChar = true;
            Tbox_AdminPass.TextChanged += Tbox_AdminPass_TextChanged;
            // 
            // But_AdminLOGIN
            // 
            But_AdminLOGIN.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            But_AdminLOGIN.Location = new Point(372, 447);
            But_AdminLOGIN.Name = "But_AdminLOGIN";
            But_AdminLOGIN.Size = new Size(115, 53);
            But_AdminLOGIN.TabIndex = 6;
            But_AdminLOGIN.Text = "LOGIN  →";
            But_AdminLOGIN.UseVisualStyleBackColor = true;
            But_AdminLOGIN.Click += But_AdminLOGIN_Click;
            // 
            // LLBL_AdminFPass
            // 
            LLBL_AdminFPass.AutoSize = true;
            LLBL_AdminFPass.Font = new Font("Inter", 8F);
            LLBL_AdminFPass.LinkColor = Color.Black;
            LLBL_AdminFPass.Location = new Point(204, 356);
            LLBL_AdminFPass.Name = "LLBL_AdminFPass";
            LLBL_AdminFPass.Size = new Size(125, 17);
            LLBL_AdminFPass.TabIndex = 8;
            LLBL_AdminFPass.TabStop = true;
            LLBL_AdminFPass.Text = "Forgot Password?";
            LLBL_AdminFPass.LinkClicked += LLBL_AdminFPass_LinkClicked;
            // 
            // But_ReturnLogin
            // 
            But_ReturnLogin.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            But_ReturnLogin.Location = new Point(54, 447);
            But_ReturnLogin.Name = "But_ReturnLogin";
            But_ReturnLogin.Size = new Size(115, 53);
            But_ReturnLogin.TabIndex = 9;
            But_ReturnLogin.Text = "Return";
            But_ReturnLogin.UseVisualStyleBackColor = true;
            But_ReturnLogin.Click += But_ReturnLogin_Click;
            // 
            // G2But_ViewPass
            // 
            G2But_ViewPass.BorderColor = Color.Silver;
            G2But_ViewPass.BorderThickness = 1;
            G2But_ViewPass.CustomizableEdges = customizableEdges1;
            G2But_ViewPass.DisabledState.BorderColor = Color.DarkGray;
            G2But_ViewPass.DisabledState.CustomBorderColor = Color.DarkGray;
            G2But_ViewPass.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            G2But_ViewPass.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            G2But_ViewPass.FillColor = Color.White;
            G2But_ViewPass.Font = new Font("Segoe UI", 9F);
            G2But_ViewPass.ForeColor = Color.White;
            G2But_ViewPass.Image = (Image)resources.GetObject("G2But_ViewPass.Image");
            G2But_ViewPass.ImageOffset = new Point(0, 12);
            G2But_ViewPass.Location = new Point(357, 316);
            G2But_ViewPass.Name = "G2But_ViewPass";
            G2But_ViewPass.ShadowDecoration.CustomizableEdges = customizableEdges2;
            G2But_ViewPass.Size = new Size(28, 27);
            G2But_ViewPass.TabIndex = 16;
            G2But_ViewPass.Text = "guna2Button1";
            G2But_ViewPass.Click += G2But_ViewPass_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(532, 553);
            Controls.Add(G2But_ViewPass);
            Controls.Add(But_ReturnLogin);
            Controls.Add(LLBL_AdminFPass);
            Controls.Add(But_AdminLOGIN);
            Controls.Add(Tbox_AdminPass);
            Controls.Add(Tbox_AdminUser);
            Controls.Add(LBL_PASSWORD);
            Controls.Add(LBL_USERNAME);
            Controls.Add(LBL_HELLOADMIN);
            Controls.Add(LBL_LOGIN);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            Load += AdminLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_LOGIN;
        private Label LBL_HELLOADMIN;
        private Label LBL_USERNAME;
        private Label LBL_PASSWORD;
        private TextBox Tbox_AdminUser;
        private TextBox Tbox_AdminPass;
        private Button But_AdminLOGIN;
        private LinkLabel LLBL_AdminFPass;
        private Button But_ReturnLogin;
        private Guna.UI2.WinForms.Guna2Button G2But_ViewPass;
    }
}