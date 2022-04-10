using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___Inventory_System_Project
{
    public class Inhouse : Part
    {
        
        public Inhouse(int parID, string nm, int inst, decimal pr, int mi, int ma, int MachID)
            : base(parID, nm, inst, pr, mi, ma)
        {
             MachineID = MachID;
        }

        public int MachineID { get; set; }
    }
        
    
}
