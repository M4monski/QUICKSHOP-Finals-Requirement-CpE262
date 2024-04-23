namespace Finals_Requirement_CpE262
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            But_SalesReport = new Button();
            But_SalesHistory = new Button();
            But_Back = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // But_SalesReport
            // 
            But_SalesReport.BackColor = Color.White;
            But_SalesReport.BackgroundImage = (Image)resources.GetObject("But_SalesReport.BackgroundImage");
            But_SalesReport.BackgroundImageLayout = ImageLayout.Zoom;
            But_SalesReport.Font = new Font("Inter", 11F);
            But_SalesReport.Location = new Point(34, 75);
            But_SalesReport.Name = "But_SalesReport";
            But_SalesReport.Size = new Size(307, 261);
            But_SalesReport.TabIndex = 9;
            But_SalesReport.Text = "Sales Report";
            But_SalesReport.TextAlign = ContentAlignment.BottomCenter;
            But_SalesReport.UseVisualStyleBackColor = false;
            But_SalesReport.Click += But_SalesReport_Click;
            // 
            // But_SalesHistory
            // 
            But_SalesHistory.BackColor = Color.White;
            But_SalesHistory.BackgroundImage = (Image)resources.GetObject("But_SalesHistory.BackgroundImage");
            But_SalesHistory.BackgroundImageLayout = ImageLayout.Zoom;
            But_SalesHistory.Font = new Font("Inter", 11F);
            But_SalesHistory.Location = new Point(392, 75);
            But_SalesHistory.Name = "But_SalesHistory";
            But_SalesHistory.Size = new Size(307, 261);
            But_SalesHistory.TabIndex = 10;
            But_SalesHistory.Text = "Sales History";
            But_SalesHistory.TextAlign = ContentAlignment.BottomCenter;
            But_SalesHistory.UseVisualStyleBackColor = false;
            But_SalesHistory.Click += But_SalesHistory_Click;
            // 
            // But_Back
            // 
            But_Back.Location = new Point(608, 385);
            But_Back.Name = "But_Back";
            But_Back.Size = new Size(112, 56);
            But_Back.TabIndex = 27;
            But_Back.Text = "Back";
            But_Back.UseVisualStyleBackColor = true;
            But_Back.Click += But_Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 19);
            label1.Name = "label1";
            label1.Size = new Size(287, 34);
            label1.TabIndex = 28;
            label1.Text = "Manage Sales Data";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 453);
            Controls.Add(label1);
            Controls.Add(But_Back);
            Controls.Add(But_SalesHistory);
            Controls.Add(But_SalesReport);
            DoubleBuffered = true;
            Name = "Sales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button But_SalesReport;
        private Button But_SalesHistory;
        private Button But_Back;
        private Label label1;
    }
}