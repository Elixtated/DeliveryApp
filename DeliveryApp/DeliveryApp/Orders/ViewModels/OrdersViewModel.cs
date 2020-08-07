using CommonModule.CommonTools;
using CommonModule.Services;
using DeliveryApp.OrderCreator.ViewModels;
using DeliveryApp.OrderCreator.Views;
using DeliveryApp.Orders.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace DeliveryApp.Orders.ViewModels
{
    public class OrdersViewModel : INotifyPropertyChanged
    {
        private NavigatorService _navigatorService;
        public OrdersViewModel()
        {
            _navigatorService = NavigatorService.GetInstance();
            Orders = new ObservableCollection<OrderListItem>();

            OpenCreatePageCommand = new RelayCommand<Order>((order) => OpenCreatePage(order), (o) => true);
            RemoveOrderCommand = new RelayCommand(RemoveOrder);
           

        }

        public ObservableCollection<OrderListItem> Orders { get; set; }

        public ICommand OpenCreatePageCommand { get; }
        public ICommand RemoveOrderCommand { get; }

        private void OpenCreatePage(Order order)
        {
            var orderCreatorViewModel = new OrderCreatorViewModel(order);
            orderCreatorViewModel.CardSaved += OrderCreatorViewModelOnCardSaved;

            var orderCreatorPage = new OrdersCreatorPage
            {
                DataContext = orderCreatorViewModel
            };

            _navigatorService.SetCurrentPage(orderCreatorPage);
        }

        private void OrderCreatorViewModelOnCardSaved(object sender, Order newOrder)
        {
            if (Orders.Any(o => o.Order.OrderGuid == newOrder.OrderGuid))
            {
                var oldListItem = Orders.FirstOrDefault(order => order.Order.OrderGuid == newOrder.OrderGuid);
                oldListItem.Order = newOrder;
            }
            else
            {
                Orders.Add(new OrderListItem(newOrder));
            }
        }
        private void RemoveOrder()
        {
            var checkedOrderItems = Orders.Where(o => o.isChecked).ToArray();

            foreach (var checkedItem in checkedOrderItems)
            {
                Orders.Remove(checkedItem);
            }     
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
