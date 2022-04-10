using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___Inventory_System_Project
{
    public partial class MainForm : Form
    {
        public static int Indx { get; set; }
        public static int PartIndx { get; set; }
        public void DisplayList()
        {
            dataGridProducts.AutoGenerateColumns = true;
            dataGridProducts.DataSource = Inventory.Products;
            dataGridProducts.ClearSelection();
            
            dataGridParts.AutoGenerateColumns = true;
            dataGridParts.DataSource = Inventory.AllParts;
            dataGridParts.ClearSelection();
        }

        public MainForm()
        {
            InitializeComponent();
            DisplayList();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddPart_Click(object sender, EventArgs e) //iterates the ID number
        {
            
            AddPartForm ap1 = new AddPartForm();
            ap1.Show();
            int newProdCount = Inventory.AllParts.Count;
            newProdCount += 1;
            ap1.addPartIDText.Text = newProdCount.ToString(); //Alternatively Convert.ToString(newProdCount) will work.

        }

        private void DataGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Indx = e.RowIndex;
        }

        private void DataGridParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PartIndx = e.RowIndex;
        }

        private void DeleteProductMain_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (Indx >= 0)
                {


                    if (Inventory.Products[Indx].AssociatedParts.Count <= 0) //THIS IS INTENDED TO KEEP FROM DELETING ASSOCIATED PART WITH PRODUCT
                    {
                        for (int j = 0; j < Inventory.Products.Count; j++)
                        {
                            if (Inventory.Products[j].ProductID == (int)dataGridProducts.Rows[Indx].Cells[0].Value)
                            {
                                Inventory deleteProd = new Inventory();
                                deleteProd.RemoveProduct(j);
                            }
                        }
                        DisplayList();
                        Indx = -1;
                    }
                    else
                    {
                        MessageBox.Show("Error: You cannot delete a product with a part associated with it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

            
            
        }

        private void AddProductMain_Click(object sender, EventArgs e)
        {
            AddProduct ap2 = new AddProduct();
            ap2.Show();
            int newProdCount = Inventory.Products.Count;
            newProdCount += 1;
            ap2.addProductIDText.Text = newProdCount.ToString();

            
        }

        private void ModifyPartMain_Click(object sender, EventArgs e)
        {
            ModifyPart mpart = new ModifyPart();
            mpart.Show();

        }

        private void ModifyProductMain_Click(object sender, EventArgs e)
        {
            ModifyProduct mproduct = new ModifyProduct();
            mproduct.Show();
        }

        private void dataGridParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //This and the lower one clear the selection of the cell whenever the bindinglist is changed. Basically it turns the blue overlay off.
        {
            dataGridParts.ClearSelection();
        }

        private void dataGridProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridProducts.ClearSelection();
        }

        private void DeletePartMain_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this part?","Delete Part",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (PartIndx >= 0)
                {
                    Inventory yellowflush3 = new Inventory();
                    yellowflush3.DeletePart(Inventory.AllParts[PartIndx]);
                    DisplayList();
                    PartIndx = -1;
                }
            }

            
        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {
            dataGridParts.ClearSelection();
            Inventory searchInv = new Inventory();
            try
            {
                searchInv.LookupPart(Convert.ToInt32(partSearchBox.Text));
                dataGridParts.Rows[Inventory.SearchPartIndex].Selected = true;
                PartIndx = Inventory.SearchPartIndex;
            }
            catch (Exception ex)
            {
                StringBuilder stringBuild = new StringBuilder();

                stringBuild.AppendLine(ex.Message);
                stringBuild.AppendLine("Please enter the ID number of an existing part.");
                MessageBox.Show(stringBuild.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void SearchProducts_Click(object sender, EventArgs e)
        {
            dataGridProducts.ClearSelection();
            Inventory searchInv = new Inventory();
            try
            {
                searchInv.LookupProduct(Convert.ToInt32(productSearchBox.Text));
                dataGridProducts.Rows[Inventory.SearchProductIndex].Selected = true;
                PartIndx = Inventory.SearchProductIndex;
            }
            catch (Exception ex)
            {
                StringBuilder stringBuild = new StringBuilder();

                stringBuild.AppendLine(ex.Message);
                stringBuild.AppendLine("Please enter the ID number of an existing product.");
                MessageBox.Show(stringBuild.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
