namespace Finals_Requirement_CpE262
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            Label_Welcome = new Label();
            But_Customer = new Button();
            But_Exit = new Button();
            But_Admin = new Button();
            SuspendLayout();
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Welcome.ForeColor = SystemColors.ActiveCaptionText;
            Label_Welcome.Location = new Point(361, 30);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(215, 50);
            Label_Welcome.TabIndex = 0;
            Label_Welcome.Text = "WELCOME!";
            // 
            // But_Customer
            // 
            But_Customer.BackgroundImage = Properties.Resources.Customer;
            But_Customer.BackgroundImageLayout = ImageLayout.Zoom;
            But_Customer.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            But_Customer.Location = new Point(67, 83);
            But_Customer.Name = "But_Customer";
            But_Customer.Size = new Size(371, 346);
            But_Customer.TabIndex = 1;
            But_Customer.Text = "Customer";
            But_Customer.TextAlign = ContentAlignment.BottomCenter;
            But_Customer.UseVisualStyleBackColor = true;
            But_Customer.Click += this.But_Customer_Click;
            // 
            // But_Exit
            // 
            But_Exit.Location = new Point(762, 448);
            But_Exit.Name = "But_Exit";
            But_Exit.Size = new Size(157, 60);
            But_Exit.TabIndex = 3;
            But_Exit.Text = "Exit";
            But_Exit.UseVisualStyleBackColor = true;
            But_Exit.Click += But_Exit_Click;
            // 
            // But_Admin
            // 
            But_Admin.BackColor = Color.White;
            But_Admin.BackgroundImage = Properties.Resources.Admin;
            But_Admin.BackgroundImageLayout = ImageLayout.Zoom;
            But_Admin.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            But_Admin.Location = new Point(502, 83);
            But_Admin.Name = "But_Admin";
            But_Admin.Size = new Size(365, 346);
            But_Admin.TabIndex = 4;
            But_Admin.Text = "Admin";
            But_Admin.TextAlign = ContentAlignment.BottomCenter;
            But_Admin.UseVisualStyleBackColor = false;
            But_Admin.Click += this.But_Admin_Click;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Store_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(931, 520);
            Controls.Add(But_Admin);
            Controls.Add(But_Exit);
            Controls.Add(But_Customer);
            Controls.Add(Label_Welcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUICKSHOP";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Welcome;
        private Button But_Customer;
        private Button But_Exit;
        private Button But_Admin;
    }
}
