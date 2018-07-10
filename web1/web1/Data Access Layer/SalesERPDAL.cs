using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using web1.Models;

namespace web1.Data_Access_Layer
{

        public class SalesERPDAL:DbContext
        {
            public DbSet<Employee> Employees { get; set; }
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Employee>().ToTable("TblEmployee");
                base.OnModelCreating(modelBuilder);
            }
    }
}
