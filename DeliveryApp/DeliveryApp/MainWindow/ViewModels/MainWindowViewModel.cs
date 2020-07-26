using System.ComponentModel;

using CommonModule.Services;
using System.Windows.Input;
using CommonModule.CommonTools;
using DeliveryApp.Orders.Views;

namespace DeliveryApp.MainWindow.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            NavigatorService = NavigatorService.GetInstance();
            NavigatorService.SetCurrentPage(new OrdersPage());

            OpenOrdersMenuCommand = new RelayCommand(OpenOrdersMenu);
        }

        public ICommand OpenOrdersMenuCommand { get; }
        public ICommand OpenEmployeesMenuCommand { get; }

        public NavigatorService NavigatorService { get; private set; }

        private void OpenOrdersMenu()
        {
            NavigatorService.SetCurrentPage(new OrdersPage());
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