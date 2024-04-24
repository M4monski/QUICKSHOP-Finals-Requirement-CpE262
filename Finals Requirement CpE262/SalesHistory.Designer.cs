namespace Finals_Requirement_CpE262
{
    partial class SalesHistory
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            But_Back = new Button();
            But_LoadSales = new Button();
            G2DGV_SalesHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            G2CBox_Year = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            label3 = new Label();
            G2Cbox_Month = new Guna.UI2.WinForms.Guna2ComboBox();
            label4 = new Label();
            G2Cbox_Week = new Guna.UI2.WinForms.Guna2ComboBox();
            G2CRB_SalesToday = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            label5 = new Label();
            But_GenerateSalesReport = new Button();
            Lbl_DataGrossSales = new Label();
            Lbl_GrossSales = new Label();
            But_DeleteSalesRecord = new Button();
            label7 = new Label();
            G2CRB_LifetimeSales = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            But_ClearSearchFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)G2DGV_SalesHistory).BeginInit();
            SuspendLayout();
            // 
            // But_Back
            // 
            But_Back.Location = new Point(796, 435);
            But_Back.Name = "But_Back";
            But_Back.Size = new Size(123, 74);
            But_Back.TabIndex = 28;
            But_Back.Text = "Back";
            But_Back.UseVisualStyleBackColor = true;
            But_Back.Click += But_Back_Click;
            // 
            // But_LoadSales
            // 
            But_LoadSales.Location = new Point(454, 435);
            But_LoadSales.Name = "But_LoadSales";
            But_LoadSales.Size = new Size(108, 73);
            But_LoadSales.TabIndex = 29;
            But_LoadSales.Text = "Load Sales History";
            But_LoadSales.UseVisualStyleBackColor = true;
            But_LoadSales.Click += But_LoadSales_Click;
            // 
            // G2DGV_SalesHistory
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(254, 248, 196);
            G2DGV_SalesHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            G2DGV_SalesHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(254, 192, 7);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            G2DGV_SalesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            G2DGV_SalesHistory.ColumnHeadersHeight = 40;
            G2DGV_SalesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(254, 250, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(254, 213, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            G2DGV_SalesHistory.DefaultCellStyle = dataGridViewCellStyle3;
            G2DGV_SalesHistory.GridColor = Color.FromArgb(254, 235, 177);
            G2DGV_SalesHistory.Location = new Point(12, 12);
            G2DGV_SalesHistory.Name = "G2DGV_SalesHistory";
            G2DGV_SalesHistory.RowHeadersVisible = false;
            G2DGV_SalesHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            G2DGV_SalesHistory.Size = new Size(907, 357);
            G2DGV_SalesHistory.TabIndex = 30;
            G2DGV_SalesHistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            G2DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(254, 248, 196);
            G2DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            G2DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            G2DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            G2DGV_SalesHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            G2DGV_SalesHistory.ThemeStyle.BackColor = Color.White;
            G2DGV_SalesHistory.ThemeStyle.GridColor = Color.FromArgb(254, 235, 177);
            G2DGV_SalesHistory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(254, 192, 7);
            G2DGV_SalesHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            G2DGV_SalesHistory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            G2DGV_SalesHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            G2DGV_SalesHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            G2DGV_SalesHistory.ThemeStyle.HeaderStyle.Height = 40;
            G2DGV_SalesHistory.ThemeStyle.ReadOnly = false;
            G2DGV_SalesHistory.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(254, 250, 215);
            G2DGV_SalesHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            G2DGV_SalesHistory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            G2DGV_SalesHistory.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            G2DGV_SalesHistory.ThemeStyle.RowsStyle.Height = 29;
            G2DGV_SalesHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(254, 213, 89);
            G2DGV_SalesHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 12F);
            label1.Location = new Point(12, 372);
            label1.Name = "label1";
            label1.Size = new Size(115, 24);
            label1.TabIndex = 31;
            label1.Text = "Filter Sales";
            // 
            // G2CBox_Year
            // 
            G2CBox_Year.BackColor = Color.Transparent;
            G2CBox_Year.CustomizableEdges = customizableEdges1;
            G2CBox_Year.DrawMode = DrawMode.OwnerDrawFixed;
            G2CBox_Year.DropDownStyle = ComboBoxStyle.DropDownList;
            G2CBox_Year.FocusedColor = Color.FromArgb(94, 148, 255);
            G2CBox_Year.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2CBox_Year.Font = new Font("Segoe UI", 10F);
            G2CBox_Year.ForeColor = Color.Black;
            G2CBox_Year.ItemHeight = 30;
            G2CBox_Year.Items.AddRange(new object[] { "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990" });
            G2CBox_Year.Location = new Point(15, 435);
            G2CBox_Year.Name = "G2CBox_Year";
            G2CBox_Year.ShadowDecoration.CustomizableEdges = customizableEdges2;
            G2CBox_Year.Size = new Size(112, 36);
            G2CBox_Year.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F);
            label2.Location = new Point(15, 408);
            label2.Name = "label2";
            label2.Size = new Size(51, 24);
            label2.TabIndex = 34;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 12F);
            label3.Location = new Point(135, 408);
            label3.Name = "label3";
            label3.Size = new Size(71, 24);
            label3.TabIndex = 36;
            label3.Text = "Month";
            // 
            // G2Cbox_Month
            // 
            G2Cbox_Month.BackColor = Color.Transparent;
            G2Cbox_Month.CustomizableEdges = customizableEdges3;
            G2Cbox_Month.DrawMode = DrawMode.OwnerDrawFixed;
            G2Cbox_Month.DropDownStyle = ComboBoxStyle.DropDownList;
            G2Cbox_Month.FocusedColor = Color.FromArgb(94, 148, 255);
            G2Cbox_Month.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Cbox_Month.Font = new Font("Segoe UI", 10F);
            G2Cbox_Month.ForeColor = Color.Black;
            G2Cbox_Month.ItemHeight = 30;
            G2Cbox_Month.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            G2Cbox_Month.Location = new Point(135, 435);
            G2Cbox_Month.Name = "G2Cbox_Month";
            G2Cbox_Month.ShadowDecoration.CustomizableEdges = customizableEdges4;
            G2Cbox_Month.Size = new Size(134, 36);
            G2Cbox_Month.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 12F);
            label4.Location = new Point(276, 408);
            label4.Name = "label4";
            label4.Size = new Size(63, 24);
            label4.TabIndex = 38;
            label4.Text = "Week";
            // 
            // G2Cbox_Week
            // 
            G2Cbox_Week.BackColor = Color.Transparent;
            G2Cbox_Week.CustomizableEdges = customizableEdges5;
            G2Cbox_Week.DrawMode = DrawMode.OwnerDrawFixed;
            G2Cbox_Week.DropDownStyle = ComboBoxStyle.DropDownList;
            G2Cbox_Week.FocusedColor = Color.FromArgb(94, 148, 255);
            G2Cbox_Week.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2Cbox_Week.Font = new Font("Segoe UI", 10F);
            G2Cbox_Week.ForeColor = Color.Black;
            G2Cbox_Week.ItemHeight = 30;
            G2Cbox_Week.Items.AddRange(new object[] { "1st (1-7)", "2nd (8-16)", "3rd (17-24)", "4th (25-31)" });
            G2Cbox_Week.Location = new Point(276, 435);
            G2Cbox_Week.Name = "G2Cbox_Week";
            G2Cbox_Week.ShadowDecoration.CustomizableEdges = customizableEdges6;
            G2Cbox_Week.Size = new Size(172, 36);
            G2Cbox_Week.TabIndex = 37;
            // 
            // G2CRB_SalesToday
            // 
            G2CRB_SalesToday.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2CRB_SalesToday.CheckedState.BorderThickness = 0;
            G2CRB_SalesToday.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            G2CRB_SalesToday.CheckedState.InnerColor = Color.White;
            G2CRB_SalesToday.Location = new Point(88, 484);
            G2CRB_SalesToday.Name = "G2CRB_SalesToday";
            G2CRB_SalesToday.ShadowDecoration.CustomizableEdges = customizableEdges7;
            G2CRB_SalesToday.Size = new Size(25, 25);
            G2CRB_SalesToday.TabIndex = 39;
            G2CRB_SalesToday.Text = "guna2CustomRadioButton1";
            G2CRB_SalesToday.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            G2CRB_SalesToday.UncheckedState.BorderThickness = 2;
            G2CRB_SalesToday.UncheckedState.FillColor = Color.Transparent;
            G2CRB_SalesToday.UncheckedState.InnerColor = Color.Transparent;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 12F);
            label5.Location = new Point(15, 484);
            label5.Name = "label5";
            label5.Size = new Size(67, 24);
            label5.TabIndex = 40;
            label5.Text = "Today";
            // 
            // But_GenerateSalesReport
            // 
            But_GenerateSalesReport.Location = new Point(682, 436);
            But_GenerateSalesReport.Name = "But_GenerateSalesReport";
            But_GenerateSalesReport.Size = new Size(108, 73);
            But_GenerateSalesReport.TabIndex = 43;
            But_GenerateSalesReport.Text = "Generate Sales Report";
            But_GenerateSalesReport.UseVisualStyleBackColor = true;
            But_GenerateSalesReport.Click += But_GenerateSalesReport_Click;
            // 
            // Lbl_DataGrossSales
            // 
            Lbl_DataGrossSales.AutoSize = true;
            Lbl_DataGrossSales.Font = new Font("Inter", 12F);
            Lbl_DataGrossSales.Location = new Point(768, 372);
            Lbl_DataGrossSales.Name = "Lbl_DataGrossSales";
            Lbl_DataGrossSales.Size = new Size(22, 24);
            Lbl_DataGrossSales.TabIndex = 45;
            Lbl_DataGrossSales.Text = "  ";
            // 
            // Lbl_GrossSales
            // 
            Lbl_GrossSales.AutoSize = true;
            Lbl_GrossSales.Font = new Font("Inter", 12F);
            Lbl_GrossSales.Location = new Point(635, 372);
            Lbl_GrossSales.Name = "Lbl_GrossSales";
            Lbl_GrossSales.Size = new Size(127, 24);
            Lbl_GrossSales.TabIndex = 44;
            Lbl_GrossSales.Text = "Gross Sales:";
            // 
            // But_DeleteSalesRecord
            // 
            But_DeleteSalesRecord.Location = new Point(568, 436);
            But_DeleteSalesRecord.Name = "But_DeleteSalesRecord";
            But_DeleteSalesRecord.Size = new Size(108, 73);
            But_DeleteSalesRecord.TabIndex = 46;
            But_DeleteSalesRecord.Text = "Delete Sales Record";
            But_DeleteSalesRecord.UseVisualStyleBackColor = true;
            But_DeleteSalesRecord.Click += But_DeleteSalesRecord_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 12F);
            label7.Location = new Point(135, 484);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 48;
            label7.Text = "Lifetime";
            // 
            // G2CRB_LifetimeSales
            // 
            G2CRB_LifetimeSales.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            G2CRB_LifetimeSales.CheckedState.BorderThickness = 0;
            G2CRB_LifetimeSales.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            G2CRB_LifetimeSales.CheckedState.InnerColor = Color.White;
            G2CRB_LifetimeSales.Location = new Point(227, 484);
            G2CRB_LifetimeSales.Name = "G2CRB_LifetimeSales";
            G2CRB_LifetimeSales.ShadowDecoration.CustomizableEdges = customizableEdges8;
            G2CRB_LifetimeSales.Size = new Size(25, 25);
            G2CRB_LifetimeSales.TabIndex = 47;
            G2CRB_LifetimeSales.Text = "G2CRB_LifetimeSales";
            G2CRB_LifetimeSales.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            G2CRB_LifetimeSales.UncheckedState.BorderThickness = 2;
            G2CRB_LifetimeSales.UncheckedState.FillColor = Color.Transparent;
            G2CRB_LifetimeSales.UncheckedState.InnerColor = Color.Transparent;
            // 
            // But_ClearSearchFilters
            // 
            But_ClearSearchFilters.Location = new Point(276, 474);
            But_ClearSearchFilters.Name = "But_ClearSearchFilters";
            But_ClearSearchFilters.Size = new Size(172, 34);
            But_ClearSearchFilters.TabIndex = 49;
            But_ClearSearchFilters.Text = "Clear Search Filters";
            But_ClearSearchFilters.UseVisualStyleBackColor = true;
            But_ClearSearchFilters.Click += But_ClearSearchFilters_Click;
            // 
            // SalesHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(931, 520);
            Controls.Add(But_ClearSearchFilters);
            Controls.Add(label7);
            Controls.Add(G2CRB_LifetimeSales);
            Controls.Add(But_DeleteSalesRecord);
            Controls.Add(Lbl_DataGrossSales);
            Controls.Add(Lbl_GrossSales);
            Controls.Add(But_GenerateSalesReport);
            Controls.Add(label5);
            Controls.Add(G2CRB_SalesToday);
            Controls.Add(label4);
            Controls.Add(G2Cbox_Week);
            Controls.Add(label3);
            Controls.Add(G2Cbox_Month);
            Controls.Add(label2);
            Controls.Add(G2CBox_Year);
            Controls.Add(label1);
            Controls.Add(G2DGV_SalesHistory);
            Controls.Add(But_LoadSales);
            Controls.Add(But_Back);
            DoubleBuffered = true;
            Name = "SalesHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales History";
            Load += SalesHistory_Load;
            ((System.ComponentModel.ISupportInitialize)G2DGV_SalesHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button But_Back;
        private Button But_LoadSales;
        private Guna.UI2.WinForms.Guna2DataGridView G2DGV_SalesHistory;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox G2CBox_Year;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox G2Cbox_Month;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox G2Cbox_Week;
        private Guna.UI2.WinForms.Guna2CustomRadioButton G2CRB_SalesToday;
        private Label label5;
        private Button But_GenerateSalesReport;
        private Label Lbl_DataGrossSales;
        private Label Lbl_GrossSales;
        private Button But_DeleteSalesRecord;
        private Label label7;
        private Guna.UI2.WinForms.Guna2CustomRadioButton G2CRB_LifetimeSales;
        private Button But_ClearSearchFilters;
    }
}