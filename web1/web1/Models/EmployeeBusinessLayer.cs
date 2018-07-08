using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web1.Models
{
    //制作员工列表
    public class EmployeeBusinessLayer
    {
       
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "johnson";
            emp.LastName = " fernandes";
            emp.Salary = 14000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "Leo";
            emp.LastName = " Chens";
            emp.Salary = 300000000;
            employees.Add(emp);
            emp = new Employee();
            emp.FirstName = "Adam";
            emp.LastName = " Link";
            emp.Salary = 90000;
            employees.Add(emp);

            return employees;
        }
    }
}
