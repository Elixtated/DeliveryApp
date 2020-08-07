using CommonModule;
using CommonModule.Controls;
using CommonModule.Controls.Modules.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ЕmployeesModule
{
    public class EmployeeModule : IModule
    {
        public Page ModulePage => new Employees.Views.EmployeesPage();

        public string Name => "Сотрудники";
    }
}
