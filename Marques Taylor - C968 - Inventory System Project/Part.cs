using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968___Inventory_System_Project
{
    public abstract class Part
    {
        

        public Part(int parID, string nm, int inst, decimal pr, int mi, int ma)
        {
            PartID = parID;
            Name = nm;
            Instock = inst;
            Price = pr;
            Min = mi;
            Max = ma;
        }
        public int PartID { get; set; }
        public string Name { get; set; }

        public int Instock { get; set; }

        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
