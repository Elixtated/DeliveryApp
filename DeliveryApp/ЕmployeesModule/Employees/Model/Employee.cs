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
        private string _ordersComplete;

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

        public string OrdersComplete
        {
            get => _ordersComplete;
            set
            {
                _ordersComplete = value;
                OnPropertyChanged("OrdersComplete");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
