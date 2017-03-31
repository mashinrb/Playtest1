using InnovativeSecurityManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InnovativeSecurityManagement.DAL.Data;

namespace InnovativeSecurityManagement.DAL.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>
    {
        public EmployeeRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
