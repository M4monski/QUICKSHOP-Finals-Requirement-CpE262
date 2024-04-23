namespace Finals_Requirement_CpE262
{
    partial class DeleteProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            But_LoadProducts = new Button();
            But_Back = new Button();
            IButton_DelProd = new FontAwesome.Sharp.IconButton();
            G2DGV_Products = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)G2DGV_Products).BeginInit();
            SuspendLayout();
            // 
            // But_LoadProducts
            // 
            But_LoadProducts.Font = new Font("Inter", 9F);
            But_LoadProducts.Location = new Point(236, 442);
            But_LoadProducts.Name = "But_LoadProducts";
            But_LoadProducts.Size = new Size(137, 56);
            But_LoadProducts.TabIndex = 19;
            But_LoadProducts.Text = "Refresh Products";
            But_LoadProducts.UseVisualStyleBackColor = true;
            But_LoadProducts.Click += But_LoadProducts_Click;
            // 
            // But_Back
            // 
            But_Back.Location = new Point(428, 442);
            But_Back.Name = "But_Back";
            But_Back.Size = new Size(137, 56);
            But_Back.TabIndex = 18;
            But_Back.Text = "Back";
            But_Back.UseVisualStyleBackColor = true;
            But_Back.Click += But_Back_Click;
            // 
            // IButton_DelProd
            // 
            IButton_DelProd.Font = new Font("Inter", 9F);
            IButton_DelProd.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            IButton_DelProd.IconColor = Color.DeepSkyBlue;
            IButton_DelProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IButton_DelProd.Location = new Point(44, 442);
            IButton_DelProd.Name = "IButton_DelProd";
            IButton_DelProd.Size = new Size(137, 56);
            IButton_DelProd.TabIndex = 17;
            IButton_DelProd.Text = "Delete Product";
            IButton_DelProd.TextImageRelation = TextImageRelation.ImageBeforeText;
            IButton_DelProd.UseVisualStyleBackColor = true;
            IButton_DelProd.Click += IButton_DelProd_Click;
            // 
            // G2DGV_Products
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(254, 248, 196);
            G2DGV_Products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            G2DGV_Products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(254, 192, 7);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            G2DGV_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            G2DGV_Products.ColumnHeadersHeight = 40;
            G2DGV_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(254, 250, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(254, 213, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            G2DGV_Products.DefaultCellStyle = dataGridViewCellStyle3;
            G2DGV_Products.GridColor = Color.FromArgb(254, 235, 177);
            G2DGV_Products.Location = new Point(45, 12);
            G2DGV_Products.Name = "G2DGV_Products";
            G2DGV_Products.RowHeadersVisible = false;
            G2DGV_Products.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            G2DGV_Products.Size = new Size(521, 393);
            G2DGV_Products.TabIndex = 16;
            G2DGV_Products.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            G2DGV_Products.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(254, 248, 196);
            G2DGV_Products.ThemeStyle.AlternatingRowsStyle.Font = null;
            G2DGV_Products.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            G2DGV_Products.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            G2DGV_Products.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            G2DGV_Products.ThemeStyle.BackColor = Color.White;
            G2DGV_Products.ThemeStyle.GridColor = Color.FromArgb(254, 235, 177);
            G2DGV_Products.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(254, 192, 7);
            G2DGV_Products.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            G2DGV_Products.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            G2DGV_Products.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            G2DGV_Products.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            G2DGV_Products.ThemeStyle.HeaderStyle.Height = 40;
            G2DGV_Products.ThemeStyle.ReadOnly = false;
            G2DGV_Products.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(254, 250, 215);
            G2DGV_Products.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            G2DGV_Products.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            G2DGV_Products.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            G2DGV_Products.ThemeStyle.RowsStyle.Height = 29;
            G2DGV_Products.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(254, 213, 89);
            G2DGV_Products.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // DeleteProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(610, 520);
            Controls.Add(But_LoadProducts);
            Controls.Add(But_Back);
            Controls.Add(IButton_DelProd);
            Controls.Add(G2DGV_Products);
            DoubleBuffered = true;
            Font = new Font("Inter", 9F);
            Name = "DeleteProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteProduct";
            ((System.ComponentModel.ISupportInitialize)G2DGV_Products).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button But_LoadProducts;
        private Button But_Back;
        private FontAwesome.Sharp.IconButton IButton_DelProd;
        private Guna.UI2.WinForms.Guna2DataGridView G2DGV_Products;
    }
}