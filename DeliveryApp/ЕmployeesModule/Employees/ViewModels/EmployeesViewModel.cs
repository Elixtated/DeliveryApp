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
using ЕmployeesModule.EmployeesCreator.ViewModels;
using ЕmployeesModule.EmployeesCreator.Views;

namespace ЕmployeesModule.Employees.ViewModels
{
    public class EmployeesViewModel : INotifyPropertyChanged
    {
        private NavigatorService _navigatorService;
        public EmployeesViewModel()
        {
            _navigatorService = NavigatorService.Instance;
            Employees = new ObservableCollection<EmployeesListItem>();

            CreateEmployeeCommand = new RelayCommand<Employee>((employee) => CreateEmployee(employee), (o) => true);
            RemoveEmployeeCommand = new RelayCommand(RemoveEmployee);
        }

        public ObservableCollection<EmployeesListItem> Employees { get; set; }

        public ICommand CreateEmployeeCommand { get; }
        public ICommand RemoveEmployeeCommand { get; }

        
        

        private void CreateEmployee(Employee employee)
        {
            var employeeCreatorViewModel = new EmployeesCreatorViewModel(employee);
            employeeCreatorViewModel.CardSaved += EmployeeCreatorViewModelOnCardSaved;

            var employeeCreatorPage = new EmployeesCreatorPage
            {
                DataContext = employeeCreatorViewModel
            };

            _navigatorService.SetCurrentPage(employeeCreatorPage);
        }

        private void EmployeeCreatorViewModelOnCardSaved(object sender, Employee newEmployee)
        {
            if (Employees.Any(o => o.Employee.EmployeeGuid == newEmployee.EmployeeGuid))
            {
                var oldListItem = Employees.FirstOrDefault(employee => employee.Employee.EmployeeGuid == newEmployee.EmployeeGuid);
                oldListItem.Employee = newEmployee;
            }
            else
            {
                Employees.Add(new EmployeesListItem(newEmployee));
            }
        }

        private void RemoveEmployee()
        {
            var checkedEmployeesItem = Employees.Where(o => o.isChecked).ToArray();

            foreach (var checkedItem in checkedEmployeesItem)
            {
                Employees.Remove(checkedItem);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
