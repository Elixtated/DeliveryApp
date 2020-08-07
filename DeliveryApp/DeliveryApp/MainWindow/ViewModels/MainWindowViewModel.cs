using System.ComponentModel;
using ЕmployeesModule.Employees.Views;
using CommonModule.Services;
using System.Windows.Input;
using CommonModule.CommonTools;
using ЕmployeesModule;
using CommonModule.Controls.Modules.ViewModel;

namespace DeliveryApp.MainWindow.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            
            ModulesListViewModel = new ModulesListViewModel();
            OrderModule orderModule = new OrderModule();
           
            EmployeeModule employeeModule = new EmployeeModule();
            ModulesListViewModel.AddModuleToList(orderModule);
            ModulesListViewModel.AddModuleToList(employeeModule);
            NavigatorService = NavigatorService.GetInstance();
            //NavigatorService.SetCurrentPage();
        }

        public NavigatorService NavigatorService { get; private set; }

        EmployeesPage EmployeesPage { get; set; }

        public ModulesListViewModel ModulesListViewModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}