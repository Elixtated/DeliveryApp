using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModule
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string DateOrder { get; set; }
        public string LeaderOrder { get; set; }
        public string DateComplete { get; set; }
        public string AboutOrder { get; set; }
    }
}
