using CommonModule.CommonTools;
using CommonModule.Services;
using DeliveryApp.OrderCreator.ViewModels;
using DeliveryApp.OrderCreator.Views;
using DeliveryApp.Orders.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using System.Data.Entity;
using CommonModule;

namespace DeliveryApp.Orders.ViewModels
{
    public class OrdersViewModel : INotifyPropertyChanged
    {
        private NavigatorService _navigatorService;
        public OrdersViewModel()
        {
            _navigatorService = NavigatorService.Instance;
            OpenCreatePageCommand = new RelayCommand<Order>((order) => OpenCreatePage(order), (o) => true);
            RemoveOrderCommand = new RelayCommand(RemoveOrder);
            DataBaseService = DataBaseService.GetInstance();
            var DataBaseOrder = DataBaseService.GetAllOrders();
            Orders = new ObservableCollection<OrderListItem>(DataBaseOrder.Select(o => new OrderListItem(o)));
        }

        public ObservableCollection<OrderListItem> Orders { get; set; }

        public DataBaseService DataBaseService { get; set; }

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
            if (Orders.Any(o => o.Order.Id == newOrder.Id))
            {
                var oldListItem = Orders.FirstOrDefault(order => order.Order.Id == newOrder.Id);
                oldListItem.Order = newOrder;
            }
            else
            {
                DataBaseService.AddOrder(newOrder);
            }
            var DataBaseOrder = DataBaseService.GetAllOrders();
            Orders.Clear();
            foreach (var order in DataBaseOrder)
            {
                Orders.Add(new OrderListItem(order));
            }
        }
        private void RemoveOrder()
        {
            var checkedOrderItems = Orders.Where(o => o.isChecked).ToArray();

            foreach (var checkedItem in checkedOrderItems)
            {
                Orders.Remove(checkedItem);
                DataBaseService.RemoveOrder(checkedItem.Order);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
