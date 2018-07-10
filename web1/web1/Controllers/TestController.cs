using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web1.Models;
using web1.ViewModels;
namespace web1.Controllers
{

    public class Person
    {
        public string Name { set; get; }
        public int Age { set; get;  }

        public override string ToString()
        {
            return "name:" + this.Name + " | age: " + this.Age; 
        }
    }
    public class TestController : Controller
    {
        // [NonAction] 标志为nonaction时 此方法不会被触发 
        //1
        public Person GetPerson()
        {
            Person p = new Person();
            p.Name = "Leochens";
            p.Age = 22;
            return p;
        }

        //2
        public ActionResult GetView()
        {

            EmployeeListViewModel employeeListView = new EmployeeListViewModel();
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach(Employee emp in employees)
            {
                EmployeeViewModel vmEmp = new EmployeeViewModel();
                vmEmp.Name = emp.FirstName + " " + emp.LastName;
                vmEmp.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 200000)
                {
                    vmEmp.SalaryColror = "red";
                }
                else
                {
                    vmEmp.SalaryColror = "blue";
                }
                empViewModels.Add(vmEmp);
            }

            employeeListView.Employees = empViewModels;

            employeeListView.UserName = "Admin";







            //3. 获取到模型类的数据
           //Employee emp = new Employee();
            /* emp.FirstName = "Leo";
            emp.LastName = "chens";
            emp.Salary = 300000000;*/


            //注册变量 使用ViewData
            //ViewData["Employee"] = emp;


            //使用ViewBag
            //ViewBag.Employee = emp;

            //使用VM


            return View("L_View", employeeListView);//这里对应的是具体的额视图名称
        }


        public ActionResult zhl()
        {
            /*string connString = "server=127.0.0.1;database=mvc_test;user id=root;pwd=123456;";

            SqlConnection con = new SqlConnection(connString);
            con.Open();*/

            return View("Z_View");
        }

    }
}