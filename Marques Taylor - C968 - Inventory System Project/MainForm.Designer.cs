namespace C968___Inventory_System_Project
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.SearchProducts = new System.Windows.Forms.Button();
            this.AddPartMain = new System.Windows.Forms.Button();
            this.ModifyPartMain = new System.Windows.Forms.Button();
            this.DeletePartMain = new System.Windows.Forms.Button();
            this.DeleteProductMain = new System.Windows.Forms.Button();
            this.ModifyProductMain = new System.Windows.Forms.Button();
            this.AddProductMain = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.Location = new System.Drawing.Point(227, 75);
            this.searchPartsButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(100, 26);
            this.searchPartsButton.TabIndex = 10;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = true;
            this.searchPartsButton.Click += new System.EventHandler(this.searchPartsButton_Click);
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(335, 75);
            this.partSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(163, 22);
            this.partSearchBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Products";
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(872, 75);
            this.productSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(163, 22);
            this.productSearchBox.TabIndex = 6;
            // 
            // SearchProducts
            // 
            this.SearchProducts.Location = new System.Drawing.Point(764, 75);
            this.SearchProducts.Margin = new System.Windows.Forms.Padding(4);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(100, 26);
            this.SearchProducts.TabIndex = 5;
            this.SearchProducts.Text = "Search";
            this.SearchProducts.UseVisualStyleBackColor = true;
            this.SearchProducts.Click += new System.EventHandler(this.SearchProducts_Click);
            // 
            // AddPartMain
            // 
            this.AddPartMain.Location = new System.Drawing.Point(239, 436);
            this.AddPartMain.Margin = new System.Windows.Forms.Padding(4);
            this.AddPartMain.Name = "AddPartMain";
            this.AddPartMain.Size = new System.Drawing.Size(69, 26);
            this.AddPartMain.TabIndex = 1;
            this.AddPartMain.Text = "Add";
            this.AddPartMain.UseVisualStyleBackColor = true;
            this.AddPartMain.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // ModifyPartMain
            // 
            this.ModifyPartMain.Location = new System.Drawing.Point(335, 436);
            this.ModifyPartMain.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyPartMain.Name = "ModifyPartMain";
            this.ModifyPartMain.Size = new System.Drawing.Size(69, 26);
            this.ModifyPartMain.TabIndex = 10;
            this.ModifyPartMain.Text = "Modify";
            this.ModifyPartMain.UseVisualStyleBackColor = true;
            this.ModifyPartMain.Click += new System.EventHandler(this.ModifyPartMain_Click);
            // 
            // DeletePartMain
            // 
            this.DeletePartMain.Location = new System.Drawing.Point(428, 436);
            this.DeletePartMain.Margin = new System.Windows.Forms.Padding(4);
            this.DeletePartMain.Name = "DeletePartMain";
            this.DeletePartMain.Size = new System.Drawing.Size(69, 26);
            this.DeletePartMain.TabIndex = 11;
            this.DeletePartMain.Text = "Delete";
            this.DeletePartMain.UseVisualStyleBackColor = true;
            this.DeletePartMain.Click += new System.EventHandler(this.DeletePartMain_Click);
            // 
            // DeleteProductMain
            // 
            this.DeleteProductMain.Location = new System.Drawing.Point(967, 436);
            this.DeleteProductMain.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteProductMain.Name = "DeleteProductMain";
            this.DeleteProductMain.Size = new System.Drawing.Size(69, 26);
            this.DeleteProductMain.TabIndex = 14;
            this.DeleteProductMain.Text = "Delete";
            this.DeleteProductMain.UseVisualStyleBackColor = true;
            this.DeleteProductMain.Click += new System.EventHandler(this.DeleteProductMain_Click);
            // 
            // ModifyProductMain
            // 
            this.ModifyProductMain.Location = new System.Drawing.Point(872, 436);
            this.ModifyProductMain.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyProductMain.Name = "ModifyProductMain";
            this.ModifyProductMain.Size = new System.Drawing.Size(69, 26);
            this.ModifyProductMain.TabIndex = 13;
            this.ModifyProductMain.Text = "Modify";
            this.ModifyProductMain.UseVisualStyleBackColor = true;
            this.ModifyProductMain.Click += new System.EventHandler(this.ModifyProductMain_Click);
            // 
            // AddProductMain
            // 
            this.AddProductMain.Location = new System.Drawing.Point(776, 436);
            this.AddProductMain.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductMain.Name = "AddProductMain";
            this.AddProductMain.Size = new System.Drawing.Size(69, 26);
            this.AddProductMain.TabIndex = 12;
            this.AddProductMain.Text = "Add";
            this.AddProductMain.UseVisualStyleBackColor = true;
            this.AddProductMain.Click += new System.EventHandler(this.AddProductMain_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(967, 513);
            this.ExitProgram.Margin = new System.Windows.Forms.Padding(4);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(69, 26);
            this.ExitProgram.TabIndex = 15;
            this.ExitProgram.Text = "Exit";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridProducts.Location = new System.Drawing.Point(564, 108);
            this.dataGridProducts.MultiSelect = false;
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.RowHeadersVisible = false;
            this.dataGridProducts.RowHeadersWidth = 51;
            this.dataGridProducts.RowTemplate.Height = 24;
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.Size = new System.Drawing.Size(472, 308);
            this.dataGridProducts.TabIndex = 18;
            this.dataGridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProducts_CellClick);
            this.dataGridProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridProducts_DataBindingComplete);
            // 
            // dataGridParts
            // 
            this.dataGridParts.AllowUserToAddRows = false;
            this.dataGridParts.AllowUserToDeleteRows = false;
            this.dataGridParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridParts.Location = new System.Drawing.Point(26, 108);
            this.dataGridParts.MultiSelect = false;
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.ReadOnly = true;
            this.dataGridParts.RowHeadersVisible = false;
            this.dataGridParts.RowHeadersWidth = 51;
            this.dataGridParts.RowTemplate.Height = 24;
            this.dataGridParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParts.Size = new System.Drawing.Size(472, 308);
            this.dataGridParts.TabIndex = 19;
            this.dataGridParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridParts_CellClick);
            this.dataGridParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridParts_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "PartID";
            this.Column1.HeaderText = "Part ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Instock";
            this.Column3.HeaderText = "Inventory";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 95;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 69;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Min";
            this.Column5.HeaderText = "Min";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Max";
            this.Column6.HeaderText = "Max";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.DataPropertyName = "ProductID";
            this.Column7.HeaderText = "Product ID";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 103;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Name";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 74;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column9.DataPropertyName = "Instock";
            this.Column9.HeaderText = "Inventory";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 95;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.DataPropertyName = "Price";
            this.Column10.HeaderText = "Price";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 69;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "Min";
            this.Column11.HeaderText = "Min";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "Max";
            this.Column12.HeaderText = "Max";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridParts);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.ExitProgram);
            this.Controls.Add(this.DeleteProductMain);
            this.Controls.Add(this.ModifyProductMain);
            this.Controls.Add(this.AddProductMain);
            this.Controls.Add(this.DeletePartMain);
            this.Controls.Add(this.ModifyPartMain);
            this.Controls.Add(this.AddPartMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.SearchProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.searchPartsButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button SearchProducts;
        private System.Windows.Forms.Button AddPartMain;
        private System.Windows.Forms.Button ModifyPartMain;
        private System.Windows.Forms.Button DeletePartMain;
        private System.Windows.Forms.Button DeleteProductMain;
        private System.Windows.Forms.Button ModifyProductMain;
        private System.Windows.Forms.Button AddProductMain;
        private System.Windows.Forms.Button ExitProgram;
        public System.Windows.Forms.DataGridView dataGridProducts;
        public System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

