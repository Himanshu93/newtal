using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtal_core
{
    public class Buy
    {
        public int BuyID { get; set; }
        public int AccountID { get; set; }
        public int ContractID { get; set; }
        public decimal Rate { get; set; }
        public int Quantity { get; set; }
        public DateTime BuyDate { get; set; }
    }
}
