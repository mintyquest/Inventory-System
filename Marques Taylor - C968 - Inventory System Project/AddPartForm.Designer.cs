namespace C968___Inventory_System_Project
{
    partial class AddPartForm
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
            this.inHouseRadioAddPart = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioAddPart = new System.Windows.Forms.RadioButton();
            this.SavePart = new System.Windows.Forms.Button();
            this.CancelAddPart = new System.Windows.Forms.Button();
            this.addPartMachAndCompText = new System.Windows.Forms.TextBox();
            this.machineAndCompany = new System.Windows.Forms.Label();
            this.addPartIDText = new System.Windows.Forms.TextBox();
            this.addPartNameText = new System.Windows.Forms.TextBox();
            this.addPartInstockText = new System.Windows.Forms.TextBox();
            this.addPartPriceText = new System.Windows.Forms.TextBox();
            this.addPartMaxText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addPartMinText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // inHouseRadioAddPart
            // 
            this.inHouseRadioAddPart.AutoSize = true;
            this.inHouseRadioAddPart.Checked = true;
            this.inHouseRadioAddPart.Location = new System.Drawing.Point(137, 9);
            this.inHouseRadioAddPart.Margin = new System.Windows.Forms.Padding(4);
            this.inHouseRadioAddPart.Name = "inHouseRadioAddPart";
            this.inHouseRadioAddPart.Size = new System.Drawing.Size(86, 21);
            this.inHouseRadioAddPart.TabIndex = 1;
            this.inHouseRadioAddPart.TabStop = true;
            this.inHouseRadioAddPart.Text = "In-House";
            this.inHouseRadioAddPart.UseVisualStyleBackColor = true;
            this.inHouseRadioAddPart.CheckedChanged += new System.EventHandler(this.inHouseRadioAddPart_CheckedChanged);
            // 
            // outsourcedRadioAddPart
            // 
            this.outsourcedRadioAddPart.AutoSize = true;
            this.outsourcedRadioAddPart.Location = new System.Drawing.Point(243, 9);
            this.outsourcedRadioAddPart.Margin = new System.Windows.Forms.Padding(4);
            this.outsourcedRadioAddPart.Name = "outsourcedRadioAddPart";
            this.outsourcedRadioAddPart.Size = new System.Drawing.Size(103, 21);
            this.outsourcedRadioAddPart.TabIndex = 2;
            this.outsourcedRadioAddPart.Text = "Outsourced";
            this.outsourcedRadioAddPart.UseVisualStyleBackColor = true;
            this.outsourcedRadioAddPart.CheckedChanged += new System.EventHandler(this.outsourcedRadioAddPart_CheckedChanged);
            // 
            // SavePart
            // 
            this.SavePart.Location = new System.Drawing.Point(297, 301);
            this.SavePart.Name = "SavePart";
            this.SavePart.Size = new System.Drawing.Size(69, 26);
            this.SavePart.TabIndex = 3;
            this.SavePart.Text = "Save";
            this.SavePart.UseVisualStyleBackColor = true;
            this.SavePart.Click += new System.EventHandler(this.SavePart_Click);
            // 
            // CancelAddPart
            // 
            this.CancelAddPart.Location = new System.Drawing.Point(386, 301);
            this.CancelAddPart.Name = "CancelAddPart";
            this.CancelAddPart.Size = new System.Drawing.Size(69, 26);
            this.CancelAddPart.TabIndex = 4;
            this.CancelAddPart.Text = "Cancel";
            this.CancelAddPart.UseVisualStyleBackColor = true;
            this.CancelAddPart.Click += new System.EventHandler(this.CancelAddPart_Click);
            // 
            // addPartMachAndCompText
            // 
            this.addPartMachAndCompText.Location = new System.Drawing.Point(182, 238);
            this.addPartMachAndCompText.Name = "addPartMachAndCompText";
            this.addPartMachAndCompText.Size = new System.Drawing.Size(100, 22);
            this.addPartMachAndCompText.TabIndex = 11;
            // 
            // machineAndCompany
            // 
            this.machineAndCompany.Location = new System.Drawing.Point(36, 238);
            this.machineAndCompany.Name = "machineAndCompany";
            this.machineAndCompany.Size = new System.Drawing.Size(126, 22);
            this.machineAndCompany.TabIndex = 17;
            this.machineAndCompany.Text = "Machine ID:";
            this.machineAndCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addPartIDText
            // 
            this.addPartIDText.Enabled = false;
            this.addPartIDText.Location = new System.Drawing.Point(182, 50);
            this.addPartIDText.Name = "addPartIDText";
            this.addPartIDText.Size = new System.Drawing.Size(100, 22);
            this.addPartIDText.TabIndex = 5;
            // 
            // addPartNameText
            // 
            this.addPartNameText.Location = new System.Drawing.Point(182, 88);
            this.addPartNameText.Name = "addPartNameText";
            this.addPartNameText.Size = new System.Drawing.Size(100, 22);
            this.addPartNameText.TabIndex = 6;
            // 
            // addPartInstockText
            // 
            this.addPartInstockText.Location = new System.Drawing.Point(182, 127);
            this.addPartInstockText.Name = "addPartInstockText";
            this.addPartInstockText.Size = new System.Drawing.Size(100, 22);
            this.addPartInstockText.TabIndex = 7;
            // 
            // addPartPriceText
            // 
            this.addPartPriceText.Location = new System.Drawing.Point(182, 165);
            this.addPartPriceText.Name = "addPartPriceText";
            this.addPartPriceText.Size = new System.Drawing.Size(100, 22);
            this.addPartPriceText.TabIndex = 8;
            // 
            // addPartMaxText
            // 
            this.addPartMaxText.Location = new System.Drawing.Point(182, 202);
            this.addPartMaxText.Name = "addPartMaxText";
            this.addPartMaxText.Size = new System.Drawing.Size(66, 22);
            this.addPartMaxText.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(110, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(80, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(77, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Inventory:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(95, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(107, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Max:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addPartMinText
            // 
            this.addPartMinText.Location = new System.Drawing.Point(332, 202);
            this.addPartMinText.Name = "addPartMinText";
            this.addPartMinText.Size = new System.Drawing.Size(66, 22);
            this.addPartMinText.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Min:";
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 352);
            this.Controls.Add(this.addPartMachAndCompText);
            this.Controls.Add(this.machineAndCompany);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addPartMinText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPartMaxText);
            this.Controls.Add(this.addPartPriceText);
            this.Controls.Add(this.addPartInstockText);
            this.Controls.Add(this.addPartNameText);
            this.Controls.Add(this.addPartIDText);
            this.Controls.Add(this.CancelAddPart);
            this.Controls.Add(this.SavePart);
            this.Controls.Add(this.outsourcedRadioAddPart);
            this.Controls.Add(this.inHouseRadioAddPart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPartForm";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inHouseRadioAddPart;
        private System.Windows.Forms.RadioButton outsourcedRadioAddPart;
        private System.Windows.Forms.Button SavePart;
        private System.Windows.Forms.Button CancelAddPart;
        private System.Windows.Forms.Label machineAndCompany;
        private System.Windows.Forms.TextBox addPartNameText;
        private System.Windows.Forms.TextBox addPartInstockText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.TextBox addPartMaxText;
        protected internal System.Windows.Forms.TextBox addPartMinText;
        protected internal System.Windows.Forms.TextBox addPartMachAndCompText;
        protected internal System.Windows.Forms.TextBox addPartIDText;
        protected internal System.Windows.Forms.TextBox addPartPriceText;
    }
}