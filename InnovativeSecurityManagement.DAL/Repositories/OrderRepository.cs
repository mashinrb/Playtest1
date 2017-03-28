﻿using InnovativeSecurityManagement.DAL.Data;
using InnovativeSecurityManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InnovativeSecurityManagement.DAL.Repositories
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(DataContext context): base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        } 
    }
}
