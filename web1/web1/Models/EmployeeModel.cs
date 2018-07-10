using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace web1.Models
{
    public class Employee
    {
        /*public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Salary { set; get; }*/

        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}
