using CommonModule.CommonTools;
using CommonModule.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ЕmployeesModule.Employees.Model;

namespace ЕmployeesModule.Employees.ViewModels
{
    public class EmployeesViewModel : INotifyPropertyChanged
    {
        private NavigatorService _navigatorService;
        public EmployeesViewModel()
        {
            _navigatorService = NavigatorService.GetInstance();
            Employees = new ObservableCollection<EmployeesListItem>();

            CreateEmployeeCommand = new RelayCommand<Employee>((employee) => CreateEmployee(employee), (o) => true);
            RemoveEmployeeCommand = new RelayCommand(RemoveEmployee);
        }

        public ICommand CreateEmployeeCommand { get; }
        public ICommand RemoveEmployeeCommand { get; }

        public ObservableCollection<EmployeesListItem> Employees { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private void CreateEmployee(Employee employee)
        {
            
        }

        private void RemoveEmployee()
        {

        }
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
