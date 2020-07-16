using System.ComponentModel;
using DeliveryApp.Orders.Views;
using CommonModule.Services;

namespace DeliveryApp.MainWindow.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            NavigatorService = NavigatorService.GetInstance();
            NavigatorService.SetCurrentPage(new OrdersPage());
        }
        
        public NavigatorService NavigatorService { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}