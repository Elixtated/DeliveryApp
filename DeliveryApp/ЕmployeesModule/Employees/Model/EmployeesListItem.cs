using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЕmployeesModule.Employees.Model
{
    public class EmployeesListItem
    {
        public EmployeesListItem(Employee employee)
        {
            Employee = employee;
        }
        public Employee Employee { get; set; }
    }
}
