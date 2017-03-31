using InnovativeSecurityManagement.DAL.Data;
using InnovativeSecurityManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovativeSecurityManagement.DAL.Repositories
{
    public class ContractorRepository : RepositoryBase<Contractor>
    {
        public ContractorRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
