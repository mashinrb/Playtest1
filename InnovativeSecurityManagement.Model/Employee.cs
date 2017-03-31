using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovativeSecurityManagement.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [MaxLength(225)]
        public string ImageUrl { get; set; }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Postcode { get; set; }

        
        public int MobilePhone { get; set; }
      
        public int HomePhone { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }


        public bool Steward { get; set; }
        [MaxLength(16)]
        public string SecurityGaurd { get; set; }
        [MaxLength(16)]
        public string DoorSupervisor { get; set; }
        [MaxLength(16)]
        public string CCTV { get; set; }
        [MaxLength(16)]
        public string CloseProtection { get; set; }

        public string KinName { get; set; }
        [MaxLength(11)]
        public string KinNumber { get; set; }


    }
}
