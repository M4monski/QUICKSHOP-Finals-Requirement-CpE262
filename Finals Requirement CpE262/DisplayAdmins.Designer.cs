namespace Finals_Requirement_CpE262
{
    partial class DisplayAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAdmins));
            DGV_Admins = new DataGridView();
            But_LoadAdmin = new Button();
            But_Back = new Button();
            But_DeleteAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Admins).BeginInit();
            SuspendLayout();
            // 
            // DGV_Admins
            // 
            DGV_Admins.BackgroundColor = Color.White;
            DGV_Admins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Admins.Location = new Point(80, 68);
            DGV_Admins.Name = "DGV_Admins";
            DGV_Admins.RowHeadersWidth = 51;
            DGV_Admins.Size = new Size(771, 352);
            DGV_Admins.TabIndex = 0;
            // 
            // But_LoadAdmin
            // 
            But_LoadAdmin.Font = new Font("Inter", 9F);
            But_LoadAdmin.Location = new Point(389, 426);
            But_LoadAdmin.Name = "But_LoadAdmin";
            But_LoadAdmin.Size = new Size(152, 51);
            But_LoadAdmin.TabIndex = 1;
            But_LoadAdmin.Text = "Refresh Admins";
            But_LoadAdmin.UseVisualStyleBackColor = true;
            But_LoadAdmin.Click += But_LoadAdmin_Click;
            // 
            // But_Back
            // 
            But_Back.Font = new Font("Inter", 9F);
            But_Back.Location = new Point(699, 426);
            But_Back.Name = "But_Back";
            But_Back.Size = new Size(152, 51);
            But_Back.TabIndex = 2;
            But_Back.Text = "Back";
            But_Back.UseVisualStyleBackColor = true;
            But_Back.Click += But_Back_Click;
            // 
            // But_DeleteAdmin
            // 
            But_DeleteAdmin.BackgroundImageLayout = ImageLayout.Zoom;
            But_DeleteAdmin.Font = new Font("Inter", 9F);
            But_DeleteAdmin.Location = new Point(80, 426);
            But_DeleteAdmin.Name = "But_DeleteAdmin";
            But_DeleteAdmin.Size = new Size(152, 51);
            But_DeleteAdmin.TabIndex = 9;
            But_DeleteAdmin.Text = "Delete Admin Account";
            But_DeleteAdmin.TextAlign = ContentAlignment.BottomCenter;
            But_DeleteAdmin.UseVisualStyleBackColor = true;
            But_DeleteAdmin.Click += But_DeleteAdmin_Click;
            // 
            // DisplayAdmins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(931, 520);
            Controls.Add(But_DeleteAdmin);
            Controls.Add(But_Back);
            Controls.Add(But_LoadAdmin);
            Controls.Add(DGV_Admins);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DisplayAdmins";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DisplayAdmins";
            ((System.ComponentModel.ISupportInitialize)DGV_Admins).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button But_LoadAdmin;
        private Button But_Back;
        private Button But_DeleteAdmin;
        public DataGridView DGV_Admins;
    }
}