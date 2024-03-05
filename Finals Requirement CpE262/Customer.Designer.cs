namespace Finals_Requirement_CpE262
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            label1 = new Label();
            But_Browse = new Button();
            But_OpenCart = new Button();
            But_CustBack = new Button();
            But_CustExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 9);
            label1.Name = "label1";
            label1.Size = new Size(453, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome to QUICKSHOP!";
            // 
            // But_Browse
            // 
            But_Browse.Location = new Point(119, 114);
            But_Browse.Name = "But_Browse";
            But_Browse.Size = new Size(322, 248);
            But_Browse.TabIndex = 1;
            But_Browse.Text = "Browse Products";
            But_Browse.UseVisualStyleBackColor = true;
            But_Browse.Click += But_Browse_Click;
            // 
            // But_OpenCart
            // 
            But_OpenCart.Location = new Point(511, 114);
            But_OpenCart.Name = "But_OpenCart";
            But_OpenCart.Size = new Size(303, 248);
            But_OpenCart.TabIndex = 2;
            But_OpenCart.Text = "View Cart";
            But_OpenCart.UseVisualStyleBackColor = true;
            // 
            // But_CustBack
            // 
            But_CustBack.Location = new Point(119, 423);
            But_CustBack.Name = "But_CustBack";
            But_CustBack.Size = new Size(121, 51);
            But_CustBack.TabIndex = 3;
            But_CustBack.Text = "Back";
            But_CustBack.UseVisualStyleBackColor = true;
            But_CustBack.Click += But_CustBack_Click;
            // 
            // But_CustExit
            // 
            But_CustExit.Location = new Point(693, 423);
            But_CustExit.Name = "But_CustExit";
            But_CustExit.Size = new Size(121, 51);
            But_CustExit.TabIndex = 4;
            But_CustExit.Text = "Exit";
            But_CustExit.UseVisualStyleBackColor = true;
            But_CustExit.Click += But_CustExit_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 520);
            Controls.Add(But_CustExit);
            Controls.Add(But_CustBack);
            Controls.Add(But_OpenCart);
            Controls.Add(But_Browse);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button But_Browse;
        private Button But_OpenCart;
        private Button But_CustBack;
        private Button But_CustExit;
    }
}