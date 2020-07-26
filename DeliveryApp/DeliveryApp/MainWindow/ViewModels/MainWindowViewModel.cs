using System.ComponentModel;
using ЕmployeesModule.Employees.Views;
using CommonModule.Services;
using System.Windows.Input;
using CommonModule.CommonTools;
using DeliveryApp.Orders.Views;
using System.Windows.Controls;

namespace DeliveryApp.MainWindow.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            OrdersPage = new OrdersPage();
            EmployeesPage = new EmployeesPage();
            NavigatorService = NavigatorService.GetInstance();
            NavigatorService.SetCurrentPage(OrdersPage);

            OpenOrdersMenuCommand = new RelayCommand(OpenOrdersMenu);
            OpenEmployeesMenuCommand = new RelayCommand(OpenEmployeesMenu);
            
        }
        
        public ICommand OpenOrdersMenuCommand { get; }
        public ICommand OpenEmployeesMenuCommand { get; }

        public Page OrdersPage { get; set; }
        public Page EmployeesPage { get; set; }

        public NavigatorService NavigatorService { get; private set; }

        private void OpenOrdersMenu()
        {
            NavigatorService.SetCurrentPage(OrdersPage);
        }

        private void OpenEmployeesMenu()
        {
            NavigatorService.SetCurrentPage(new EmployeesPage());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}