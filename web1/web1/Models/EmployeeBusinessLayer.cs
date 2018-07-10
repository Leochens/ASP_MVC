using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web1.Data_Access_Layer;
using System.Configuration;

namespace web1.Models
{
    //制作员工列表
    public class EmployeeBusinessLayer
    {
       
        public List<Employee> GetEmployees()
        {
            // string connStr = ConfigurationManager.AppSettings["ConnectionString"];
            // string conn = ConfigurationManager.ConnectionStrings["JXC_SQLConnString"].ConnectionString;
            string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["strCon"].ToString();
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }
    }
}
