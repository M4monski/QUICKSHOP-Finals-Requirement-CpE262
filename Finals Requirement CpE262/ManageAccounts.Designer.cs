namespace Finals_Requirement_CpE262
{
    partial class ManageAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccounts));
            But_AdminBack = new Button();
            LBL_ADMINACC = new Label();
            But_DisplayAdmins = new Button();
            But_AddAdmin = new Button();
            SuspendLayout();
            // 
            // But_AdminBack
            // 
            But_AdminBack.BackColor = Color.White;
            But_AdminBack.Font = new Font("Inter", 9F);
            But_AdminBack.Location = new Point(789, 448);
            But_AdminBack.Name = "But_AdminBack";
            But_AdminBack.Size = new Size(121, 51);
            But_AdminBack.TabIndex = 4;
            But_AdminBack.Text = "Back";
            But_AdminBack.UseVisualStyleBackColor = false;
            But_AdminBack.Click += But_AdminBack_Click;
            // 
            // LBL_ADMINACC
            // 
            LBL_ADMINACC.AutoSize = true;
            LBL_ADMINACC.Font = new Font("Inter", 22.2F, FontStyle.Bold);
            LBL_ADMINACC.ForeColor = SystemColors.ActiveCaptionText;
            LBL_ADMINACC.Location = new Point(304, 42);
            LBL_ADMINACC.Name = "LBL_ADMINACC";
            LBL_ADMINACC.Size = new Size(322, 45);
            LBL_ADMINACC.TabIndex = 5;
            LBL_ADMINACC.Text = "Admin Accounts";
            // 
            // But_DisplayAdmins
            // 
            But_DisplayAdmins.BackgroundImage = (Image)resources.GetObject("But_DisplayAdmins.BackgroundImage");
            But_DisplayAdmins.BackgroundImageLayout = ImageLayout.Zoom;
            But_DisplayAdmins.Font = new Font("Inter", 12F);
            But_DisplayAdmins.Location = new Point(123, 131);
            But_DisplayAdmins.Name = "But_DisplayAdmins";
            But_DisplayAdmins.Size = new Size(316, 259);
            But_DisplayAdmins.TabIndex = 6;
            But_DisplayAdmins.Text = "Display Admin Accounts";
            But_DisplayAdmins.TextAlign = ContentAlignment.BottomCenter;
            But_DisplayAdmins.UseVisualStyleBackColor = true;
            But_DisplayAdmins.Click += But_DisplayAdmins_Click;
            // 
            // But_AddAdmin
            // 
            But_AddAdmin.BackgroundImage = (Image)resources.GetObject("But_AddAdmin.BackgroundImage");
            But_AddAdmin.BackgroundImageLayout = ImageLayout.Zoom;
            But_AddAdmin.Font = new Font("Inter", 12F);
            But_AddAdmin.Location = new Point(491, 131);
            But_AddAdmin.Name = "But_AddAdmin";
            But_AddAdmin.Size = new Size(316, 259);
            But_AddAdmin.TabIndex = 7;
            But_AddAdmin.Text = "Add Admin Account";
            But_AddAdmin.TextAlign = ContentAlignment.BottomCenter;
            But_AddAdmin.UseVisualStyleBackColor = true;
            But_AddAdmin.Click += But_AddAdmin_Click;
            // 
            // ManageAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            ClientSize = new Size(931, 520);
            Controls.Add(But_AddAdmin);
            Controls.Add(But_DisplayAdmins);
            Controls.Add(LBL_ADMINACC);
            Controls.Add(But_AdminBack);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageAccounts";
            Load += ManageAccounts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button But_AdminBack;
        private Label LBL_ADMINACC;
        private Button But_DisplayAdmins;
        private Button But_AddAdmin;
    }
}