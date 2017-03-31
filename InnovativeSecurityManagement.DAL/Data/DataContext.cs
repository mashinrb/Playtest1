using InnovativeSecurityManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovativeSecurityManagement.DAL.Data
{
    public class DataContext: DbContext
    {
        /// <summary>
        /// you can either pass the NAME of a conenction string (e.g. from a web.config), and explicitly delcare it.
        /// </summary>
        public DataContext()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        /// any entity to be persisted must me delcared here.
        /// Like so...
        ///public DbSet<Product> Products { get; set; }
        /// </summary>

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ContractorEmployee> ContractorEmployees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
