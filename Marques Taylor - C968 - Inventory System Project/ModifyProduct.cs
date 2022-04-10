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
    public partial class ModifyProduct : Form
    {

        public int loadedProd = 0;
        public static int howManyToRemove = 0;
        public ModifyProduct()
        {
            InitializeComponent();
            howManyToRemove = 0;
            modifyProductIDText.Text = Inventory.Products[MainForm.Indx].ProductID.ToString();
            modifyProductNameText.Text = Inventory.Products[MainForm.Indx].Name.ToString();
            modifyProductInstockText.Text = Inventory.Products[MainForm.Indx].Instock.ToString();
            modifyProductPriceText.Text = Inventory.Products[MainForm.Indx].Price.ToString();
            modifyProductMaxText.Text = Inventory.Products[MainForm.Indx].Max.ToString();
            modifyProductMinText.Text = Inventory.Products[MainForm.Indx].Min.ToString();
            dataGridView1.DataSource = Inventory.AllParts;

            dataGridView2.DataSource = Inventory.Products[MainForm.Indx].AssociatedParts;
            loadedProd = MainForm.Indx;
        }

        private void button5_Click(object sender, EventArgs e) //CANCEL BUTTON
        {
            if (howManyToRemove > 0)
            {
                do
                {
                    Inventory.Products[loadedProd].AssociatedParts.RemoveAt(Inventory.Products[loadedProd].AssociatedParts.Count - 1);
                    --howManyToRemove;
                }
                while (howManyToRemove > 0);
            }
            this.Close();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection(); 
        }

        private void button2_Click(object sender, EventArgs e) //ADDS ASSOCIATED PART
        {
            Inventory.Products[loadedProd].AssociatedParts.Add(Inventory.AllParts[MainForm.PartIndx]);
            ++howManyToRemove;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainForm.PartIndx = e.RowIndex;
        }

        private void saveModifyProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(modifyProductMinText.Text) <= Convert.ToInt32(modifyProductMaxText.Text) && Convert.ToInt32(modifyProductInstockText.Text) >= Convert.ToInt32(modifyProductMinText.Text) && Convert.ToInt32(modifyProductInstockText.Text) <= Convert.ToInt32(modifyProductMaxText.Text))
                {
                    Inventory productUpdater = new Inventory();
                    Product prodHolder = new Product();
                    prodHolder.ProductID = Convert.ToInt32(modifyProductIDText.Text);
                    prodHolder.Name = modifyProductNameText.Text;
                    prodHolder.Instock = Convert.ToInt32(modifyProductInstockText.Text);
                    prodHolder.Price = Convert.ToDecimal(modifyProductPriceText.Text);
                    prodHolder.Max = Convert.ToInt32(modifyProductMaxText.Text);
                    prodHolder.Min = Convert.ToInt32(modifyProductMinText.Text);


                    productUpdater.UpdateProduct(loadedProd, prodHolder);


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
                if (!Int32.TryParse(modifyProductInstockText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Inventory field must be a number.");

                }
                if (!Decimal.TryParse(modifyProductPriceText.Text.Trim(), out d))
                {
                    stringBuild.AppendLine("The value in the Price field must be a decimal number.");

                }
                if (!Int32.TryParse(modifyProductMinText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Min field must be a number.");

                }
                if (!Int32.TryParse(modifyProductMaxText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Max field must be a number.");

                }


                MessageBox.Show(stringBuild.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        private void searchAssociatedButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            Product searchAssociated = new Product();
            try
            {
                searchAssociated.LookupAssociatedPart(Convert.ToInt32(associatedSearchBox.Text));
                dataGridView1.Rows[Product.SearchAssociatedIndex].Selected = true;
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
            Product deleteAssociated = new Product();
            ;
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {

                deleteAssociated.RemoveAssociatedPart(row.Index);

                //BELOW IS PRIOR CODE THAT CAUSED CRASH EVERYTIME YOU TRY TO DELETE AN ASSOCIATED PART OF LOWER PART ID
                /*
                for ( int i = 0; i <= Inventory.Products[loadedProd].AssociatedParts.Count;  ++i)
                {
                    if (Convert.ToInt32(dataGridView2.Rows[row.Index].Cells[0].Value) == Inventory.Products[loadedProd].AssociatedParts[i].PartID)
                    {
                        deleteAssociated.RemoveAssociatedPart(i);
                    }
                }
                */
            }
        }
    }
}
