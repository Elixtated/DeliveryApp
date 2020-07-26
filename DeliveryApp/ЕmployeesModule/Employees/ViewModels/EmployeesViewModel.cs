using CommonModule.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public ObservableCollection<EmployeesListItem> Employees { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
