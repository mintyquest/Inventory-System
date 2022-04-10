using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___Inventory_System_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Inventory.Products.Clear();

            Inventory.Products.Add(new Product(1, "High-End PC", 11, 2894.12m, 5, 15));
            Inventory.Products.Add(new Product(2, "Mid-Tier PC", 7, 1015.64m, 5, 15));
            Inventory.Products.Add(new Product(3, "Low-End PC", 21, 523.97m, 10, 30));

            Inventory.AllParts.Add(new Inhouse(1, "Graphics Card", 10, 200.41m, 10, 20, 30010));
            Inventory.AllParts.Add(new Inhouse(2, "Processor", 11, 163.75m, 10, 20, 30511));
            Inventory.AllParts.Add(new Outsourced(3, "Power Supply", 26, 97.32m, 10, 40, "Telm"));

            Application.Run(new MainForm());
            

        }
    }
}
