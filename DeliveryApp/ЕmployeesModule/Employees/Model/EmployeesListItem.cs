using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЕmployeesModule.Employees.Model
{
    public class EmployeesListItem
    {
        private bool _isChecked;
        public EmployeesListItem(Employee employee)
        {
            Employee = employee;
        }

        public Employee Employee { get; set; }
        public bool isChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged("isChecked");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
