using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovativeSecurityManagement.Model
{
    public class Contractor
    {
        public int ContractorId { get; set; }

        public string ContractorCompanyName { get; set; }
        public string ContractorAddress1 { get; set; }
        public string ContractorAddress2 { get; set; }
        public string ContractorPostcode { get; set; }

        public int ContractorPhone { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }

        public ICollection<ContractorEmployee> ContractorEmployees { get; set; }
    }
}
