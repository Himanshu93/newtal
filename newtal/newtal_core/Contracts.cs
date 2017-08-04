using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtal_core
{
    public class Contracts
    {
        public int ContractID { get; set; }
        public int Open { get; set; }
        public int Close { get; set; }
        public int High { get; set; }
        public string Type { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
