namespace Finals_Requirement_CpE262
{
    partial class ManageProducts
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            RTB_EProdDesc = new RichTextBox();
            But_ELoadProducts = new Button();
            But_Back = new Button();
            G2Tbox_EProdQuant = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            G2Tbox_EProdPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label3 = new Label();
            G2Tbox_EProdName = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            G2DGV_EProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            But_UpdateProd = new Button();
            But_ViewPhotos = new Button();
            IButton_EInsertPhoto = new FontAwesome.Sharp.IconButton();
            G2Tbox_IDnum = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)G2DGV_EProducts).BeginInit();
            SuspendLayout();
            // 
            // RTB_EProdDesc
            // 
            RTB_EProdDesc.Location = new Point(22, 161);
            RTB_EProdDesc.Name = "RTB_EProdDesc";
            RTB_EProdDesc.Size = new Size(347, 120);
            RTB_EProdDesc.TabIndex = 28;
            RTB_EProdDesc.Text = "";
            // 
            // But_ELoadProducts
            // 
            But_ELoadProducts.Font = new Font("Inter", 9F);
            But_ELoadProducts.Location = new Point(391, 453);
            But_ELoadProducts.Name = "But_ELoadProducts";
            But_ELoadProducts.Size = new Size(137, 56);
            But_ELoadProducts.TabIndex = 27;
            But_ELoadProducts.Text = "Refresh Products";
            But_ELoadProducts.UseVisualStyleBackColor = true;
            But_ELoadProducts.Click += But_ELoadProducts_Click;
            // 
            // But_Back
            // 
            But_Back.Location = new Point(799, 453);
            But_Back.Name = "But_Back";
            But_Back.Size = new Size(112, 56);
            But_Back.TabIndex = 26;
            But_Back.Text = "Back";
            But_Back.UseVisualStyleBackColor = true;
            But_Back.Click += But_Back_Click;
            // 
            // G2Tbox_EProdQuant
            // 
            G2Tbox_EProdQuant.CustomizableEdges = customizableEdges1;
            G2Tbox_EProdQuant.DefaultText = "";
            G2Tbox_EProdQuant.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            G2Tbox_EProdQuant.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            G2Tbox_EProdQuant.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            G2Tbox_EProdQuant.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            G2Tbox_EProdQuant.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Tbox_EProdQuant.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            G2Tbox_EProdQuant.ForeColor = Color.Black;
            G2Tbox_EProdQuant.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Tbox_EProdQuant.Location = new Point(22, 399);
            G2Tbox_EProdQuant.Margin = new Padding(3, 4, 3, 4);
            G2Tbox_EProdQuant.Name = "G2Tbox_EProdQuant";
            G2Tbox_EProdQuant.PasswordChar = '\0';
            G2Tbox_EProdQuant.PlaceholderText = "";
            G2Tbox_EProdQuant.SelectedText = "";
            G2Tbox_EProdQuant.ShadowDecoration.CustomizableEdges = customizableEdges2;
            G2Tbox_EProdQuant.Size = new Size(347, 32);
            G2Tbox_EProdQuant.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 368);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 24;
            label5.Text = "Quantity";
            // 
            // G2Tbox_EProdPrice
            // 
            G2Tbox_EProdPrice.CustomizableEdges = customizableEdges3;
            G2Tbox_EProdPrice.DefaultText = "";
            G2Tbox_EProdPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            G2Tbox_EProdPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            G2Tbox_EProdPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            G2Tbox_EProdPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            G2Tbox_EProdPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Tbox_EProdPrice.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            G2Tbox_EProdPrice.ForeColor = Color.Black;
            G2Tbox_EProdPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Tbox_EProdPrice.Location = new Point(19, 316);
            G2Tbox_EProdPrice.Margin = new Padding(3, 4, 3, 4);
            G2Tbox_EProdPrice.Name = "G2Tbox_EProdPrice";
            G2Tbox_EProdPrice.PasswordChar = '\0';
            G2Tbox_EProdPrice.PlaceholderText = "";
            G2Tbox_EProdPrice.SelectedText = "";
            G2Tbox_EProdPrice.ShadowDecoration.CustomizableEdges = customizableEdges4;
            G2Tbox_EProdPrice.Size = new Size(350, 32);
            G2Tbox_EProdPrice.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 285);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 22;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 134);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 21;
            label3.Text = "Description";
            // 
            // G2Tbox_EProdName
            // 
            G2Tbox_EProdName.CustomizableEdges = customizableEdges5;
            G2Tbox_EProdName.DefaultText = "";
            G2Tbox_EProdName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            G2Tbox_EProdName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            G2Tbox_EProdName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            G2Tbox_EProdName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            G2Tbox_EProdName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Tbox_EProdName.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            G2Tbox_EProdName.ForeColor = Color.Black;
            G2Tbox_EProdName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Tbox_EProdName.Location = new Point(22, 91);
            G2Tbox_EProdName.Margin = new Padding(3, 4, 3, 4);
            G2Tbox_EProdName.Name = "G2Tbox_EProdName";
            G2Tbox_EProdName.PasswordChar = '\0';
            G2Tbox_EProdName.PlaceholderText = "";
            G2Tbox_EProdName.SelectedText = "";
            G2Tbox_EProdName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            G2Tbox_EProdName.Size = new Size(347, 32);
            G2Tbox_EProdName.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 11);
            label1.Name = "label1";
            label1.Size = new Size(355, 34);
            label1.TabIndex = 18;
            label1.Text = "Manage Product Details";
            // 
            // G2DGV_EProducts
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(254, 248, 196);
            G2DGV_EProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            G2DGV_EProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(254, 192, 7);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            G2DGV_EProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            G2DGV_EProducts.ColumnHeadersHeight = 40;
            G2DGV_EProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(254, 250, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(254, 213, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            G2DGV_EProducts.DefaultCellStyle = dataGridViewCellStyle3;
            G2DGV_EProducts.GridColor = Color.FromArgb(254, 235, 177);
            G2DGV_EProducts.Location = new Point(391, 11);
            G2DGV_EProducts.Name = "G2DGV_EProducts";
            G2DGV_EProducts.RowHeadersVisible = false;
            G2DGV_EProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            G2DGV_EProducts.Size = new Size(521, 436);
            G2DGV_EProducts.TabIndex = 17;
            G2DGV_EProducts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            G2DGV_EProducts.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(254, 248, 196);
            G2DGV_EProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            G2DGV_EProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            G2DGV_EProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            G2DGV_EProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            G2DGV_EProducts.ThemeStyle.BackColor = Color.White;
            G2DGV_EProducts.ThemeStyle.GridColor = Color.FromArgb(254, 235, 177);
            G2DGV_EProducts.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(254, 192, 7);
            G2DGV_EProducts.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            G2DGV_EProducts.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            G2DGV_EProducts.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            G2DGV_EProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            G2DGV_EProducts.ThemeStyle.HeaderStyle.Height = 40;
            G2DGV_EProducts.ThemeStyle.ReadOnly = false;
            G2DGV_EProducts.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(254, 250, 215);
            G2DGV_EProducts.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            G2DGV_EProducts.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            G2DGV_EProducts.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            G2DGV_EProducts.ThemeStyle.RowsStyle.Height = 29;
            G2DGV_EProducts.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(254, 213, 89);
            G2DGV_EProducts.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            G2DGV_EProducts.CellClick += G2DGV_EProducts_CellClick;
            // 
            // But_UpdateProd
            // 
            But_UpdateProd.Font = new Font("Inter", 9F);
            But_UpdateProd.Location = new Point(591, 452);
            But_UpdateProd.Name = "But_UpdateProd";
            But_UpdateProd.Size = new Size(137, 56);
            But_UpdateProd.TabIndex = 29;
            But_UpdateProd.Text = "Update Product";
            But_UpdateProd.UseVisualStyleBackColor = true;
            But_UpdateProd.Click += But_UpdateProd_Click;
            // 
            // But_ViewPhotos
            // 
            But_ViewPhotos.Location = new Point(221, 451);
            But_ViewPhotos.Name = "But_ViewPhotos";
            But_ViewPhotos.Size = new Size(149, 56);
            But_ViewPhotos.TabIndex = 31;
            But_ViewPhotos.Text = "Preview Products";
            But_ViewPhotos.UseVisualStyleBackColor = true;
            But_ViewPhotos.Click += But_ViewPhotos_Click;
            // 
            // IButton_EInsertPhoto
            // 
            IButton_EInsertPhoto.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IButton_EInsertPhoto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            IButton_EInsertPhoto.IconColor = Color.Black;
            IButton_EInsertPhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IButton_EInsertPhoto.Location = new Point(22, 451);
            IButton_EInsertPhoto.Name = "IButton_EInsertPhoto";
            IButton_EInsertPhoto.Size = new Size(149, 57);
            IButton_EInsertPhoto.TabIndex = 30;
            IButton_EInsertPhoto.Text = "Insert New Photo";
            IButton_EInsertPhoto.TextImageRelation = TextImageRelation.ImageBeforeText;
            IButton_EInsertPhoto.UseVisualStyleBackColor = true;
            IButton_EInsertPhoto.Click += IButton_EInsertPhoto_Click;
            // 
            // G2Tbox_IDnum
            // 
            G2Tbox_IDnum.CustomizableEdges = customizableEdges7;
            G2Tbox_IDnum.DefaultText = "";
            G2Tbox_IDnum.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            G2Tbox_IDnum.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            G2Tbox_IDnum.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            G2Tbox_IDnum.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            G2Tbox_IDnum.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Tbox_IDnum.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            G2Tbox_IDnum.ForeColor = Color.Black;
            G2Tbox_IDnum.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Tbox_IDnum.Location = new Point(277, 49);
            G2Tbox_IDnum.Margin = new Padding(3, 4, 3, 4);
            G2Tbox_IDnum.Name = "G2Tbox_IDnum";
            G2Tbox_IDnum.PasswordChar = '\0';
            G2Tbox_IDnum.PlaceholderText = "";
            G2Tbox_IDnum.SelectedText = "";
            G2Tbox_IDnum.ShadowDecoration.CustomizableEdges = customizableEdges8;
            G2Tbox_IDnum.Size = new Size(92, 31);
            G2Tbox_IDnum.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 12F);
            label6.Location = new Point(236, 49);
            label6.Name = "label6";
            label6.Size = new Size(35, 24);
            label6.TabIndex = 33;
            label6.Text = "ID:";
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(931, 520);
            Controls.Add(label6);
            Controls.Add(G2Tbox_IDnum);
            Controls.Add(But_ViewPhotos);
            Controls.Add(IButton_EInsertPhoto);
            Controls.Add(But_UpdateProd);
            Controls.Add(RTB_EProdDesc);
            Controls.Add(But_ELoadProducts);
            Controls.Add(But_Back);
            Controls.Add(G2Tbox_EProdQuant);
            Controls.Add(label5);
            Controls.Add(G2Tbox_EProdPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(G2Tbox_EProdName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(G2DGV_EProducts);
            DoubleBuffered = true;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Products";
            ((System.ComponentModel.ISupportInitialize)G2DGV_EProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RTB_EProdDesc;
        private Button But_ELoadProducts;
        private Button But_Back;
        private Guna.UI2.WinForms.Guna2TextBox G2Tbox_EProdQuant;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox G2Tbox_EProdPrice;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox G2Tbox_EProdName;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView G2DGV_EProducts;
        private Button But_UpdateProd;
        private Button But_ViewPhotos;
        private FontAwesome.Sharp.IconButton IButton_EInsertPhoto;
        private Guna.UI2.WinForms.Guna2TextBox G2Tbox_IDnum;
        private Label label2;
        private Label label6;
    }
}