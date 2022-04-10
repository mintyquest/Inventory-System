using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___Inventory_System_Project
{
     class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts
        {
            get { return allParts; }
            set { allParts = value; }
        }


        public static int SearchPartIndex { get; set; }

        public static int SearchProductIndex { get; set; }



        public void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        public bool RemoveProduct(int delete)
        {
            Inventory.Products.RemoveAt(delete);
            return true;
        }    

        public Product LookupProduct(int f)
        {
            if (f > Products.Count)
            {
                MessageBox.Show("Error: Item not found. Please enter the ID number of an existing product.");

            }
            else
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].ProductID.Equals(f))
                    {

                        SearchProductIndex = i;
                    }

                }
            }

            return null;
        }
        
        public void UpdateProduct(int indexParam, Product prodParam)
        {
            Inventory.Products[indexParam].ProductID = prodParam.ProductID;
            Inventory.Products[indexParam].Name = prodParam.Name;
            Inventory.Products[indexParam].Instock = prodParam.Instock;
            Inventory.Products[indexParam].Price = prodParam.Price;
            Inventory.Products[indexParam].Max = prodParam.Max;
            Inventory.Products[indexParam].Min = prodParam.Min;
        }
        public void AddPart(Part par)
        {
            AllParts.Add(par);
        }

        
        public bool DeletePart(Part par)
        {
           
            AllParts.Remove(par);

            return true;


        }
        
        public Part LookupPart(int f)
        {

            if (f > AllParts.Count)
            {
                MessageBox.Show("Error: Item not found. Please enter the ID number of an existing part.");

            }
            else
            {
                for (int i = 0; i < AllParts.Count; i++)
                {
                    if (AllParts[i].PartID.Equals(f))
                    {

                        SearchPartIndex = i;
                    }

                }
            }
            

            return null;
        }

        public void updatePart(int indexParam, Part partParam) 
        {
            Inventory.AllParts.RemoveAt(indexParam);
            partParam = null; //Not Needed
        }
        
    }

    


}