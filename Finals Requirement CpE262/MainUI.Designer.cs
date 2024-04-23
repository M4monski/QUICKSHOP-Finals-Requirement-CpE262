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
            But_Exit = new Button();
            But_Admin = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Inter", 22.2F, FontStyle.Bold);
            Label_Welcome.ForeColor = SystemColors.ActiveCaptionText;
            Label_Welcome.Location = new Point(361, 30);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(227, 45);
            Label_Welcome.TabIndex = 0;
            Label_Welcome.Text = "WELCOME!";
            // 
            // But_Exit
            // 
            But_Exit.Font = new Font("Inter", 9F);
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
            But_Admin.Font = new Font("Inter SemiBold", 22.2F, FontStyle.Bold);
            But_Admin.Location = new Point(502, 83);
            But_Admin.Name = "But_Admin";
            But_Admin.Size = new Size(365, 346);
            But_Admin.TabIndex = 4;
            But_Admin.Text = "Admin";
            But_Admin.TextAlign = ContentAlignment.BottomCenter;
            But_Admin.UseVisualStyleBackColor = false;
            But_Admin.Click += But_Admin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.Customer;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Inter SemiBold", 22.2F, FontStyle.Bold);
            button1.Location = new Point(67, 83);
            button1.Name = "button1";
            button1.Size = new Size(371, 346);
            button1.TabIndex = 5;
            button1.Text = "Customer";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += But_Customer_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.Customer;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Inter SemiBold", 22.2F, FontStyle.Bold);
            button2.Location = new Point(502, 438);
            button2.Name = "button2";
            button2.Size = new Size(81, 51);
            button2.TabIndex = 6;
            button2.Text = "Customer";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(931, 520);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(But_Admin);
            Controls.Add(But_Exit);
            Controls.Add(Label_Welcome);
            DoubleBuffered = true;
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
        private Button But_Exit;
        private Button But_Admin;
        private Button button1;
        private Button button2;
    }
}
