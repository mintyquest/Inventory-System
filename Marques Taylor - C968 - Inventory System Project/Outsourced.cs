using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace C968___Inventory_System_Project
{
    public class Outsourced : Part
    {
        

        
        public Outsourced(int parID, string nm, int inst, decimal pr, int mi, int ma, string compNm)
            : base(parID, nm, inst, pr, mi, ma)
        {
            CompanyName = compNm;
        }
        public string CompanyName { get; set; }

    }
}
