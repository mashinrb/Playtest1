using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovativeSecurityManagement.Model
{
    public class Order
    {

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public int ContractorId { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
