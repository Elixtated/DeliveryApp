using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЕmployeesModule.Employees.Model
{
    public class Employee : INotifyPropertyChanged
    {
        private string _employeeName;
        private string _employeeNumber;
        private string _emplpyeePosition;

        public Employee()
        {
            EmployeeGuid = new Guid();
        }

        public Guid EmployeeGuid { get; }

        public string EmployeeName
        {
            get => _employeeName;
            set
            {
                _employeeName = value;
                OnPropertyChanged("EmployeeName");
            }
        }

        public string EmplpyeeNumber
        {
            get => _employeeNumber;
            set
            {
                _employeeNumber = value;
                OnPropertyChanged("EmplpyeeNumber");
            }
        }

        public string EmployeePosition
        {
            get => _emplpyeePosition;
            set
            {
                _emplpyeePosition = value;
                OnPropertyChanged("EmployeePosition");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
