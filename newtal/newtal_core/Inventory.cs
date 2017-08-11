using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtal_core
{
    public class Inventory
    {
        public int AccountID { get; set; }
        public int ContractID { get; set; }
        public int BuyID { get; set; }
        public int SellID { get; set; }
        //public DateTime DateInInventory { get; set; }
        public decimal CostPrice { get; set; }
    }
}
