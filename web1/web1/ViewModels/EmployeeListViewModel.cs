using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web1.ViewModels
{

    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { set; get; }
        public string UserName { set; get; }
    }
}
