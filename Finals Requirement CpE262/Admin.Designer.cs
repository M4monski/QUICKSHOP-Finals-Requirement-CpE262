namespace Finals_Requirement_CpE262
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Label_ADash = new Label();
            But_ManageProducts = new Button();
            But_ManageAcc = new Button();
            But_SalesRep = new Button();
            But_AddProd = new Button();
            But_DelProd = new Button();
            But_AdminExit = new Button();
            But_Back = new Button();
            SuspendLayout();
            // 
            // Label_ADash
            // 
            Label_ADash.AutoSize = true;
            Label_ADash.BackColor = SystemColors.Window;
            Label_ADash.Font = new Font("Inter Black", 24F, FontStyle.Bold);
            Label_ADash.Location = new Point(289, 9);
            Label_ADash.Name = "Label_ADash";
            Label_ADash.Size = new Size(382, 49);
            Label_ADash.TabIndex = 1;
            Label_ADash.Text = "Admin Dashboard";
            // 
            // But_ManageProducts
            // 
            But_ManageProducts.BackColor = Color.White;
            But_ManageProducts.BackgroundImage = Properties.Resources.PRODUCTS_removebg_preview;
            But_ManageProducts.BackgroundImageLayout = ImageLayout.Zoom;
            But_ManageProducts.Font = new Font("Inter", 15F);
            But_ManageProducts.Location = new Point(277, 92);
            But_ManageProducts.Name = "But_ManageProducts";
            But_ManageProducts.Size = new Size(382, 328);
            But_ManageProducts.TabIndex = 4;
            But_ManageProducts.Text = "Manage Products";
            But_ManageProducts.TextAlign = ContentAlignment.BottomCenter;
            But_ManageProducts.UseVisualStyleBackColor = false;
            But_ManageProducts.Click += But_ManageProducts_Click;
            // 
            // But_ManageAcc
            // 
            But_ManageAcc.BackColor = Color.White;
            But_ManageAcc.BackgroundImage = (Image)resources.GetObject("But_ManageAcc.BackgroundImage");
            But_ManageAcc.BackgroundImageLayout = ImageLayout.Zoom;
            But_ManageAcc.Font = new Font("Inter", 10F);
            But_ManageAcc.Location = new Point(697, 92);
            But_ManageAcc.Name = "But_ManageAcc";
            But_ManageAcc.Size = new Size(201, 154);
            But_ManageAcc.TabIndex = 8;
            But_ManageAcc.Text = "Manage Accounts";
            But_ManageAcc.TextAlign = ContentAlignment.BottomCenter;
            But_ManageAcc.UseVisualStyleBackColor = false;
            But_ManageAcc.Click += But_ManageAcc_Click;
            // 
            // But_SalesRep
            // 
            But_SalesRep.BackColor = Color.White;
            But_SalesRep.BackgroundImage = (Image)resources.GetObject("But_SalesRep.BackgroundImage");
            But_SalesRep.BackgroundImageLayout = ImageLayout.Zoom;
            But_SalesRep.Font = new Font("Inter", 11F);
            But_SalesRep.Location = new Point(697, 266);
            But_SalesRep.Name = "But_SalesRep";
            But_SalesRep.Size = new Size(201, 154);
            But_SalesRep.TabIndex = 7;
            But_SalesRep.Text = "Sales";
            But_SalesRep.TextAlign = ContentAlignment.BottomCenter;
            But_SalesRep.UseVisualStyleBackColor = false;
            But_SalesRep.Click += But_SalesRep_Click;
            // 
            // But_AddProd
            // 
            But_AddProd.BackColor = Color.White;
            But_AddProd.BackgroundImage = (Image)resources.GetObject("But_AddProd.BackgroundImage");
            But_AddProd.BackgroundImageLayout = ImageLayout.Zoom;
            But_AddProd.Font = new Font("Inter", 10F);
            But_AddProd.Location = new Point(33, 92);
            But_AddProd.Name = "But_AddProd";
            But_AddProd.Size = new Size(201, 154);
            But_AddProd.TabIndex = 6;
            But_AddProd.Text = "Add Product";
            But_AddProd.TextAlign = ContentAlignment.BottomCenter;
            But_AddProd.UseVisualStyleBackColor = false;
            But_AddProd.Click += But_AddProd_Click;
            // 
            // But_DelProd
            // 
            But_DelProd.BackColor = Color.White;
            But_DelProd.BackgroundImage = (Image)resources.GetObject("But_DelProd.BackgroundImage");
            But_DelProd.BackgroundImageLayout = ImageLayout.Zoom;
            But_DelProd.Font = new Font("Inter", 10F);
            But_DelProd.Location = new Point(33, 266);
            But_DelProd.Name = "But_DelProd";
            But_DelProd.Size = new Size(201, 154);
            But_DelProd.TabIndex = 5;
            But_DelProd.Text = "Delete Product";
            But_DelProd.TextAlign = ContentAlignment.BottomCenter;
            But_DelProd.UseVisualStyleBackColor = false;
            But_DelProd.Click += But_DelProd_Click;
            // 
            // But_AdminExit
            // 
            But_AdminExit.BackColor = Color.White;
            But_AdminExit.Font = new Font("Inter", 9F);
            But_AdminExit.Location = new Point(786, 452);
            But_AdminExit.Name = "But_AdminExit";
            But_AdminExit.Size = new Size(124, 47);
            But_AdminExit.TabIndex = 9;
            But_AdminExit.Text = "Exit";
            But_AdminExit.UseVisualStyleBackColor = false;
            But_AdminExit.Click += But_AdminExit_Click;
            // 
            // But_Back
            // 
            But_Back.BackColor = Color.White;
            But_Back.Font = new Font("Inter", 9F);
            But_Back.Location = new Point(21, 452);
            But_Back.Name = "But_Back";
            But_Back.Size = new Size(124, 47);
            But_Back.TabIndex = 10;
            But_Back.Text = "Return";
            But_Back.UseVisualStyleBackColor = false;
            But_Back.Click += But_Back_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImage = Properties.Resources._2;
            ClientSize = new Size(931, 520);
            Controls.Add(But_Back);
            Controls.Add(But_AdminExit);
            Controls.Add(But_ManageAcc);
            Controls.Add(But_SalesRep);
            Controls.Add(But_AddProd);
            Controls.Add(But_DelProd);
            Controls.Add(But_ManageProducts);
            Controls.Add(Label_ADash);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Label_ADash;
        private Button But_ManageProducts;
        private Button But_ManageAcc;
        private Button But_SalesRep;
        private Button But_AddProd;
        private Button But_DelProd;
        private Button But_AdminExit;
        private Button But_Back;
    }
}