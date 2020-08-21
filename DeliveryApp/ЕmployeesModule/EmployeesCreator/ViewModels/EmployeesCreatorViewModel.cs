using CommonModule.CommonTools;
using CommonModule.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ЕmployeesModule.Employees.Model;

namespace ЕmployeesModule.EmployeesCreator.ViewModels
{
    public class EmployeesCreatorViewModel
    {
        private Employee _employee;

        private NavigatorService _navigatorService;

        public EmployeesCreatorViewModel(Employee employee)
        {
            _employee = employee ?? new Employee();
            SaveEmployeeCommand = new RelayCommand(SaveEmployee);

            _navigatorService = NavigatorService.Instance;
        }

        public string EmployeeName
        {
            get => _employee.EmployeeName;
            set
            {
                _employee.EmployeeName = value;
                OnPropertyChanged("EmployeeName");
            }
        }

        public string EmployeePosition
        {
            get => _employee.EmployeePosition;
            set
            {
                _employee.EmployeePosition = value;
                OnPropertyChanged("EmployeeName");
            }
        }

        public string EmployeeNumber
        {
            get => _employee.EmplpyeeNumber;
            set
            {
                _employee.EmplpyeeNumber = value;
                OnPropertyChanged("EmployeeName");
            }
        }


        public ICommand SaveEmployeeCommand { get; private set; }

        public event EventHandler<Employee> CardSaved;
        private void SaveEmployee()
        {
            CardSaved?.Invoke(this, _employee);
            _navigatorService.BackToPreviousPage();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
