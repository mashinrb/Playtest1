using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovativeSecurityManagement.Model
{
    public class ContractorEmployee
    {
        public int ContractorEmployeeId { get; set; }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        [MaxLength(11)]
        public int MobilePhone { get; set; }

        [MaxLength(11)]
        public int CompanyPhone { get; set; }

        [MaxLength(11)]
        public int ExtentionNumber { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
