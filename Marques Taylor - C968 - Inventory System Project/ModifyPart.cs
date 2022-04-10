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
    public partial class ModifyPart : Form
    {
        
        public ModifyPart()
        {
            InitializeComponent();
            Show();
            
            
            modifyPartIDText.Text = Inventory.AllParts[MainForm.PartIndx].PartID.ToString();
            modifyPartNameText.Text = Inventory.AllParts[MainForm.PartIndx].Name.ToString();
            modifyPartInstockText.Text = Inventory.AllParts[MainForm.PartIndx].Instock.ToString();
            modifyPartPriceText.Text = Inventory.AllParts[MainForm.PartIndx].Price.ToString();
            modifyPartMaxText.Text = Inventory.AllParts[MainForm.PartIndx].Max.ToString();
            modifyPartMinText.Text = Inventory.AllParts[MainForm.PartIndx].Min.ToString();

            
            if (Inventory.AllParts[MainForm.PartIndx] is Inhouse)
            {
                Inhouse inhousePart = (Inhouse)Inventory.allParts[MainForm.PartIndx];
                inHouseRadioAddPart.Checked = true;
                machineAndCompany.Text = "Machine ID:";
                outsourcedRadioAddPart.Checked = false;
                modifyPartMachAndCompText.Text = Convert.ToString(inhousePart.MachineID);
            }

            else
            {
                Outsourced outsourcedPart = (Outsourced)Inventory.allParts[MainForm.PartIndx];
                inHouseRadioAddPart.Checked = false;
                machineAndCompany.Text = "Company Name:";
                outsourcedRadioAddPart.Checked = true;
                modifyPartMachAndCompText.Text = Convert.ToString(outsourcedPart.CompanyName);
            }            
        }

        private void inHouseRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            machineAndCompany.Text = "Machine ID:";
        }

        private void outsourcedRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            machineAndCompany.Text = "Company Name:";
        }

        private void SavePart_Click(object sender, EventArgs e)
        {
            if (machineAndCompany.Text == "Machine ID:")
            {
                try
                {
                    if (Convert.ToInt32(modifyPartMinText.Text) <= Convert.ToInt32(modifyPartMaxText.Text) && Convert.ToInt32(modifyPartInstockText.Text) >= Convert.ToInt32(modifyPartMinText.Text) && Convert.ToInt32(modifyPartInstockText.Text) <= Convert.ToInt32(modifyPartMaxText.Text))
                    {
                        Inhouse inhouseHolder = new Inhouse(Convert.ToInt32(modifyPartIDText.Text), modifyPartNameText.Text, Convert.ToInt32(modifyPartInstockText.Text), Convert.ToDecimal(modifyPartPriceText.Text), Convert.ToInt32(modifyPartMinText.Text), Convert.ToInt32(modifyPartMaxText.Text), Convert.ToInt32(modifyPartMachAndCompText.Text));

                        Inventory savePart = new Inventory();
                        savePart.updatePart(MainForm.PartIndx, inhouseHolder);
                        Inventory.AllParts.Add(new Inhouse(inhouseHolder.PartID, inhouseHolder.Name, inhouseHolder.Instock, inhouseHolder.Price, inhouseHolder.Min, inhouseHolder.Max, inhouseHolder.MachineID));

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
                    if (!Int32.TryParse(modifyPartInstockText.Text.Trim(), out v))
                    {
                        stringBuild.AppendLine("The value in the Inventory field must be a number.");

                    }
                    if (!Decimal.TryParse(modifyPartPriceText.Text.Trim(), out d))
                    {
                        stringBuild.AppendLine("The value in the Price field must be a decimal number.");

                    }
                    if (!Int32.TryParse(modifyPartMinText.Text.Trim(), out v))
                    {
                        stringBuild.AppendLine("The value in the Min field must be a number.");

                    }
                    if (!Int32.TryParse(modifyPartMaxText.Text.Trim(), out v))
                    {
                        stringBuild.AppendLine("The value in the Max field must be a number.");

                    }
                    if (machineAndCompany.Text == "Machine ID:")
                    {
                        if (!Int32.TryParse(modifyPartMachAndCompText.Text.Trim(), out v))
                        {
                            stringBuild.AppendLine("The value in the Machine ID field must be a number.");
                        }

                    }
                    MessageBox.Show(stringBuild.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    

                }
                

                
                
            }

            else
            {


                
                Outsourced outsourcedHolder = new Outsourced(Convert.ToInt32(modifyPartIDText.Text), modifyPartNameText.Text, Convert.ToInt32(modifyPartInstockText.Text), Convert.ToDecimal(modifyPartPriceText.Text), Convert.ToInt32(modifyPartMinText.Text), Convert.ToInt32(modifyPartMaxText.Text), modifyPartMachAndCompText.Text);
                
                Inventory savePart = new Inventory();
                savePart.updatePart(MainForm.PartIndx, outsourcedHolder);
                Inventory.AllParts.Add(new Outsourced(outsourcedHolder.PartID, outsourcedHolder.Name, outsourcedHolder.Instock, outsourcedHolder.Price, outsourcedHolder.Min, outsourcedHolder.Max, outsourcedHolder.CompanyName));

                this.Close();
            }
            

        }

        private void CancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
