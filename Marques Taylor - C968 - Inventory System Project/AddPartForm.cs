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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void outsourcedRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            machineAndCompany.Text = "Company Name:";
        }

        private void Company_Click(object sender, EventArgs e)
        {

        }

        private void inHouseRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            machineAndCompany.Text = "Machine ID:";
        }

        private void SavePart_Click(object sender, EventArgs e)///THIS HANDLES SAVING PARTS
        {

            try
            {

                if (Convert.ToInt32(addPartMinText.Text) <= Convert.ToInt32(addPartMaxText.Text) && Convert.ToInt32(addPartInstockText.Text) >= Convert.ToInt32(addPartMinText.Text) && Convert.ToInt32(addPartInstockText.Text) <= Convert.ToInt32(addPartMaxText.Text))
                {
                    if ((machineAndCompany.Text) == ("Machine ID:"))
                    {

                        Inventory partAdding = new Inventory();
                        Inhouse inhousePart = new Inhouse(Convert.ToInt32(addPartIDText.Text), addPartNameText.Text, Convert.ToInt32(addPartInstockText.Text), Convert.ToDecimal(addPartPriceText.Text), Convert.ToInt32(addPartMinText.Text), Convert.ToInt32(addPartMaxText.Text), Convert.ToInt32(addPartMachAndCompText.Text));
                        partAdding.AddPart(inhousePart);

                    }
                    else
                    {
                        Inventory partAdding = new Inventory();
                        Outsourced outsourcedPart = new Outsourced(Convert.ToInt32(addPartIDText.Text), addPartNameText.Text, Convert.ToInt32(addPartInstockText.Text), Convert.ToDecimal(addPartPriceText.Text), Convert.ToInt32(addPartMinText.Text), Convert.ToInt32(addPartMaxText.Text), addPartMachAndCompText.Text);

                        partAdding.AddPart(outsourcedPart);


                    }
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
                if (!Int32.TryParse(addPartInstockText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Inventory field must be a number.");

                }
                if (!Decimal.TryParse(addPartPriceText.Text.Trim(), out d))
                {
                    stringBuild.AppendLine("The value in the Price field must be a decimal number.");

                }
                if (!Int32.TryParse(addPartMinText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Min field must be a number.");

                }
                if (!Int32.TryParse(addPartMaxText.Text.Trim(), out v))
                {
                    stringBuild.AppendLine("The value in the Max field must be a number.");

                }

                if (addPartMachAndCompText.Text == "Machine ID:")
                {
                    if (!Int32.TryParse(addPartMachAndCompText.Text.Trim(), out v))
                    {
                        stringBuild.AppendLine("The value in the Machine ID field must be a number.");

                    }
                }



                MessageBox.Show(stringBuild.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
