using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___Inventory_System_Project
{
    public class Product 
    {
        private BindingList<Part> associatedParts = new BindingList<Part>(); 
        public BindingList<Part> AssociatedParts 
        {
            get { return associatedParts; }
            set { associatedParts = value; }
        }

        public static int SearchAssociatedIndex { get; set; }


        public int ProductID {get; set;}
        public string Name { get; set; }
        
        public int Instock { get; set; }

        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int proID, string nm, int inst, decimal pr, int mi, int ma)
        {
            ProductID = proID;
            Name = nm;
            Instock = inst;
            Price = pr;
            Min = mi;
            Max = ma;
        }
        
         
        
        public void AddAssociatedPart(Part assocPart) {
            int prodCount = Inventory.Products.Count;
            prodCount -= 1;
            Inventory.Products[prodCount].AssociatedParts.Add(assocPart);
        
        }
        
        public bool RemoveAssociatedPart(int k) {
            

            Inventory.Products[MainForm.Indx].AssociatedParts.RemoveAt(k);

            return true;
        }

        public Part LookupAssociatedPart(int f)
        {
            if (f > Inventory.AllParts.Count)
            {
                MessageBox.Show("Error: Item not found. Please enter the ID number of an existing part.");

            }
            else
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID.Equals(f))
                    {

                        SearchAssociatedIndex = i;
                    }

                }
            }
            


            return null;
        }
        
    }
}
