using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovativeSecurityManagement.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int EmployeeId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }

        public DateTime WorkHours { get; set; }
    }
}
