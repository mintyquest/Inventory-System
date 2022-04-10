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
    public partial class AddProduct : Form
    {


        public AddProduct()
        {
            InitializeComponent();
            dgvPartsInProdForm.DataSource = Inventory.AllParts;

        }


        private void saveButtonAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(addProductMinText.Text) <= Convert.ToInt32(addProductMaxText.Text) && Convert.ToInt32(addProductInstockText.Text) >= Convert.ToInt32(addProductMinText.Text) && Convert.ToInt32(addProductInstockText.Text) <= Convert.ToInt32(addProductMaxText.Text))
                {
                    
                    var newProduct = new Product(Convert.ToInt32(addProductIDText.Text), addProductNameText.Text, Convert.ToInt32(addProductInstockText.Text), Convert.ToDecimal(addProductPriceText.Text), Convert.ToInt32(addProductMinText.Text), Convert.ToInt32(addProductMaxText.Text));
                    Inventory prodAdder = new Inventory();
                    prodAdder.AddProduct(newProduct);
                    Product associatedPartAdder = new Product();
                    int iterate = 0;
                    foreach (DataGridViewRow row in dgvAssociatedPartsAdd.Rows)
                    {

                        for (int i = 0; i > 10; ++i){
                            if (Convert.ToInt32(dgvAssociatedPartsAdd.Rows[iterate].Cells[0].Value) == Inventory.AllParts[i].PartID)
                            {
                                associatedPartAdder.AddAssociatedPart(Inventory.AllParts[i]);
                                ++iterate;
                            }
                        }
                    }

                    associatedPartAdder.AddAssociatedPart(Inventory.AllParts[MainForm.PartIndx]);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: The value in the Min field must be lower than the Max field and the Inventory value must be in-between those two values.");
                }
            }

            catch (Exception ex)
            {
                StringBuilder stringBuild = new StringBuilder();
                stringBuild.AppendLine(ex.Message);
                int v;
                decimal d;
                if (!Int32.TryParse(addProductInstockText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Inventory field must be a number.");

                }
                if (!Decimal.TryParse(addProductPriceText.Text.Trim(), out d))
                {
                    stringBuild.AppendLine("The value in the Price field must be a decimal number.");

                }
                if (!Int32.TryParse(addProductMinText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Min field must be a number.");

                }
                if (!Int32.TryParse(addProductMaxText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Max field must be a number.");

                }


                MessageBox.Show(stringBuild.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addPartToAssociated_Click(object sender, EventArgs e)
        {
           

            dgvAssociatedPartsAdd.Rows.Add(Inventory.AllParts[MainForm.PartIndx].PartID, Inventory.AllParts[MainForm.PartIndx].Name, Inventory.AllParts[MainForm.PartIndx].Instock, Inventory.AllParts[MainForm.PartIndx].Price, Inventory.AllParts[MainForm.PartIndx].Min, Inventory.AllParts[MainForm.PartIndx].Max);
            
        }



        private void cancelButtonAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPartsInProdForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainForm.PartIndx = e.RowIndex;
        }

        private void dgvPartsInProdForm_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPartsInProdForm.ClearSelection();
        }

        private void dgvAssociatedPartsAdd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAssociatedPartsAdd.ClearSelection();
        }

        private void searchAssociatedButton_Click(object sender, EventArgs e)
        {
            dgvPartsInProdForm.ClearSelection();
            Product searchAssociated = new Product();
            try
            {
                searchAssociated.LookupAssociatedPart(Convert.ToInt32(associatedSearchBox.Text));
                dgvPartsInProdForm.Rows[Product.SearchAssociatedIndex].Selected = true;
                MainForm.PartIndx = Product.SearchAssociatedIndex;
            }
            catch (Exception ex)
            {
                StringBuilder stringBuild = new StringBuilder();

                stringBuild.AppendLine(ex.Message);
                stringBuild.AppendLine("Please enter the ID number of an existing part.");
                MessageBox.Show(stringBuild.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButtonAddProduct_Click(object sender, EventArgs e)
        {

                foreach (DataGridViewRow row in dgvAssociatedPartsAdd.SelectedRows)
            {
                dgvAssociatedPartsAdd.Rows.RemoveAt(row.Index);
            }
        }
    }
}
