namespace C968___Inventory_System_Project
{
    partial class AddProduct
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
            this.associatedSearchBox = new System.Windows.Forms.TextBox();
            this.dgvPartsInProdForm = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedPartsAdd = new System.Windows.Forms.DataGridView();
            this.searchAssociatedButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.addProductMinText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addProductMaxText = new System.Windows.Forms.TextBox();
            this.addProductPriceText = new System.Windows.Forms.TextBox();
            this.addProductInstockText = new System.Windows.Forms.TextBox();
            this.addProductNameText = new System.Windows.Forms.TextBox();
            this.addProductIDText = new System.Windows.Forms.TextBox();
            this.addPartToAssociated = new System.Windows.Forms.Button();
            this.deleteButtonAddProduct = new System.Windows.Forms.Button();
            this.saveButtonAddProduct = new System.Windows.Forms.Button();
            this.cancelButtonAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.partIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsInProdForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedPartsAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // associatedSearchBox
            // 
            this.associatedSearchBox.Location = new System.Drawing.Point(723, 34);
            this.associatedSearchBox.Name = "associatedSearchBox";
            this.associatedSearchBox.Size = new System.Drawing.Size(235, 22);
            this.associatedSearchBox.TabIndex = 1;
            // 
            // dgvPartsInProdForm
            // 
            this.dgvPartsInProdForm.AllowUserToAddRows = false;
            this.dgvPartsInProdForm.AllowUserToDeleteRows = false;
            this.dgvPartsInProdForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsInProdForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPartsInProdForm.Location = new System.Drawing.Point(463, 75);
            this.dgvPartsInProdForm.MultiSelect = false;
            this.dgvPartsInProdForm.Name = "dgvPartsInProdForm";
            this.dgvPartsInProdForm.ReadOnly = true;
            this.dgvPartsInProdForm.RowHeadersVisible = false;
            this.dgvPartsInProdForm.RowHeadersWidth = 51;
            this.dgvPartsInProdForm.RowTemplate.Height = 24;
            this.dgvPartsInProdForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartsInProdForm.Size = new System.Drawing.Size(495, 198);
            this.dgvPartsInProdForm.TabIndex = 3;
            this.dgvPartsInProdForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartsInProdForm_CellClick);
            this.dgvPartsInProdForm.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPartsInProdForm_DataBindingComplete);
            // 
            // dgvAssociatedPartsAdd
            // 
            this.dgvAssociatedPartsAdd.AllowUserToAddRows = false;
            this.dgvAssociatedPartsAdd.AllowUserToDeleteRows = false;
            this.dgvAssociatedPartsAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedPartsAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDColumn,
            this.nameColumn,
            this.instockColumn,
            this.priceColumn,
            this.minColumn,
            this.maxColumn});
            this.dgvAssociatedPartsAdd.Location = new System.Drawing.Point(463, 365);
            this.dgvAssociatedPartsAdd.MultiSelect = false;
            this.dgvAssociatedPartsAdd.Name = "dgvAssociatedPartsAdd";
            this.dgvAssociatedPartsAdd.ReadOnly = true;
            this.dgvAssociatedPartsAdd.RowHeadersVisible = false;
            this.dgvAssociatedPartsAdd.RowHeadersWidth = 51;
            this.dgvAssociatedPartsAdd.RowTemplate.Height = 24;
            this.dgvAssociatedPartsAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedPartsAdd.Size = new System.Drawing.Size(495, 197);
            this.dgvAssociatedPartsAdd.TabIndex = 4;
            this.dgvAssociatedPartsAdd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAssociatedPartsAdd_DataBindingComplete);
            // 
            // searchAssociatedButton
            // 
            this.searchAssociatedButton.Location = new System.Drawing.Point(626, 33);
            this.searchAssociatedButton.Name = "searchAssociatedButton";
            this.searchAssociatedButton.Size = new System.Drawing.Size(75, 23);
            this.searchAssociatedButton.TabIndex = 5;
            this.searchAssociatedButton.Text = "Search";
            this.searchAssociatedButton.UseVisualStyleBackColor = true;
            this.searchAssociatedButton.Click += new System.EventHandler(this.searchAssociatedButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Min:";
            // 
            // addProductMinText
            // 
            this.addProductMinText.Location = new System.Drawing.Point(319, 347);
            this.addProductMinText.Name = "addProductMinText";
            this.addProductMinText.Size = new System.Drawing.Size(66, 22);
            this.addProductMinText.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Max:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Inventory:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "ID:";
            // 
            // addProductMaxText
            // 
            this.addProductMaxText.Location = new System.Drawing.Point(166, 347);
            this.addProductMaxText.Name = "addProductMaxText";
            this.addProductMaxText.Size = new System.Drawing.Size(66, 22);
            this.addProductMaxText.TabIndex = 24;
            // 
            // addProductPriceText
            // 
            this.addProductPriceText.Location = new System.Drawing.Point(166, 310);
            this.addProductPriceText.Name = "addProductPriceText";
            this.addProductPriceText.Size = new System.Drawing.Size(100, 22);
            this.addProductPriceText.TabIndex = 23;
            // 
            // addProductInstockText
            // 
            this.addProductInstockText.Location = new System.Drawing.Point(166, 272);
            this.addProductInstockText.Name = "addProductInstockText";
            this.addProductInstockText.Size = new System.Drawing.Size(100, 22);
            this.addProductInstockText.TabIndex = 22;
            // 
            // addProductNameText
            // 
            this.addProductNameText.Location = new System.Drawing.Point(166, 233);
            this.addProductNameText.Name = "addProductNameText";
            this.addProductNameText.Size = new System.Drawing.Size(100, 22);
            this.addProductNameText.TabIndex = 21;
            // 
            // addProductIDText
            // 
            this.addProductIDText.Enabled = false;
            this.addProductIDText.Location = new System.Drawing.Point(166, 195);
            this.addProductIDText.Name = "addProductIDText";
            this.addProductIDText.Size = new System.Drawing.Size(100, 22);
            this.addProductIDText.TabIndex = 20;
            // 
            // addPartToAssociated
            // 
            this.addPartToAssociated.Location = new System.Drawing.Point(883, 289);
            this.addPartToAssociated.Name = "addPartToAssociated";
            this.addPartToAssociated.Size = new System.Drawing.Size(75, 23);
            this.addPartToAssociated.TabIndex = 32;
            this.addPartToAssociated.Text = "Add";
            this.addPartToAssociated.UseVisualStyleBackColor = true;
            this.addPartToAssociated.Click += new System.EventHandler(this.addPartToAssociated_Click);
            // 
            // deleteButtonAddProduct
            // 
            this.deleteButtonAddProduct.Location = new System.Drawing.Point(883, 584);
            this.deleteButtonAddProduct.Name = "deleteButtonAddProduct";
            this.deleteButtonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteButtonAddProduct.TabIndex = 33;
            this.deleteButtonAddProduct.Text = "Delete";
            this.deleteButtonAddProduct.UseVisualStyleBackColor = true;
            this.deleteButtonAddProduct.Click += new System.EventHandler(this.deleteButtonAddProduct_Click);
            // 
            // saveButtonAddProduct
            // 
            this.saveButtonAddProduct.Location = new System.Drawing.Point(763, 632);
            this.saveButtonAddProduct.Name = "saveButtonAddProduct";
            this.saveButtonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.saveButtonAddProduct.TabIndex = 34;
            this.saveButtonAddProduct.Text = "Save";
            this.saveButtonAddProduct.UseVisualStyleBackColor = true;
            this.saveButtonAddProduct.Click += new System.EventHandler(this.saveButtonAddProduct_Click);
            // 
            // cancelButtonAddProduct
            // 
            this.cancelButtonAddProduct.Location = new System.Drawing.Point(883, 632);
            this.cancelButtonAddProduct.Name = "cancelButtonAddProduct";
            this.cancelButtonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonAddProduct.TabIndex = 35;
            this.cancelButtonAddProduct.Text = "Cancel";
            this.cancelButtonAddProduct.UseVisualStyleBackColor = true;
            this.cancelButtonAddProduct.Click += new System.EventHandler(this.cancelButtonAddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "All Candidate Parts";
            // 
            // partIDColumn
            // 
            this.partIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.partIDColumn.FillWeight = 94F;
            this.partIDColumn.HeaderText = "Part ID";
            this.partIDColumn.MinimumWidth = 6;
            this.partIDColumn.Name = "partIDColumn";
            this.partIDColumn.ReadOnly = true;
            this.partIDColumn.Width = 80;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 74;
            // 
            // instockColumn
            // 
            this.instockColumn.FillWeight = 68.66311F;
            this.instockColumn.HeaderText = "Inventory";
            this.instockColumn.MinimumWidth = 6;
            this.instockColumn.Name = "instockColumn";
            this.instockColumn.ReadOnly = true;
            this.instockColumn.Width = 77;
            // 
            // priceColumn
            // 
            this.priceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 69;
            // 
            // minColumn
            // 
            this.minColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.minColumn.HeaderText = "Min";
            this.minColumn.MinimumWidth = 6;
            this.minColumn.Name = "minColumn";
            this.minColumn.ReadOnly = true;
            // 
            // maxColumn
            // 
            this.maxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxColumn.HeaderText = "Max";
            this.maxColumn.MinimumWidth = 6;
            this.maxColumn.Name = "maxColumn";
            this.maxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "PartID";
            this.Column1.HeaderText = "Part ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 689);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButtonAddProduct);
            this.Controls.Add(this.saveButtonAddProduct);
            this.Controls.Add(this.deleteButtonAddProduct);
            this.Controls.Add(this.addPartToAssociated);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addProductMinText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.addProductMaxText);
            this.Controls.Add(this.addProductPriceText);
            this.Controls.Add(this.addProductInstockText);
            this.Controls.Add(this.addProductNameText);
            this.Controls.Add(this.addProductIDText);
            this.Controls.Add(this.searchAssociatedButton);
            this.Controls.Add(this.dgvAssociatedPartsAdd);
            this.Controls.Add(this.dgvPartsInProdForm);
            this.Controls.Add(this.associatedSearchBox);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsInProdForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedPartsAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox associatedSearchBox;
        public  System.Windows.Forms.DataGridView dgvAssociatedPartsAdd;
        private System.Windows.Forms.Button searchAssociatedButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addProductMinText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addProductMaxText;
        private System.Windows.Forms.TextBox addProductPriceText;
        private System.Windows.Forms.TextBox addProductInstockText;
        private System.Windows.Forms.TextBox addProductNameText;
        private System.Windows.Forms.Button addPartToAssociated;
        private System.Windows.Forms.Button deleteButtonAddProduct;
        private System.Windows.Forms.Button saveButtonAddProduct;
        private System.Windows.Forms.Button cancelButtonAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvPartsInProdForm;
        protected internal System.Windows.Forms.TextBox addProductIDText;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}