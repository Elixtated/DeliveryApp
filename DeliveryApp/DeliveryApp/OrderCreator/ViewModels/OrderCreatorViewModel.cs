using CommonModule;
using CommonModule.CommonTools;
using CommonModule.Services;
using DeliveryApp.Orders.Model;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace DeliveryApp.OrderCreator.ViewModels
{
    public class OrderCreatorViewModel : INotifyPropertyChanged
    {
        
        
        private Order _order;

        private NavigatorService _navigatorService;

        public OrderCreatorViewModel(Order order)
        {
           
            _order = order ?? new Order();
            SaveOrderCommand = new RelayCommand(SaveOrder);
           dataBaseService = DataBaseService.GetInstance();
            _navigatorService = NavigatorService.Instance;
        }

        public event EventHandler<Order> CardSaved;
        
        public DataBaseService dataBaseService;
        public string OrderNumber
        {
            get => _order.OrderNumber;
            set
            {
                _order.OrderNumber = value;
                OnPropertyChanged("OrderNumber");
            }
        }

        public string DateOrder
        {
            get => _order.DateOrder;
            set
            {
                _order.DateOrder = value;

                OnPropertyChanged("DateOrder");
            }
        }

        public string LeaderOrder
        {
            get => _order.LeaderOrder;
            set
            {
                _order.LeaderOrder = value;

                OnPropertyChanged("LeaderOrder");
            }
        }

        public string DateComplete
        {
            get => _order.DateComplete;
            set
            {
                _order.DateComplete = value;

                OnPropertyChanged("DateComplete");
            }
        }

        public string AboutOrder
        {
            get => _order.AboutOrder;
            set
            {
                _order.AboutOrder = value;

                OnPropertyChanged("AboutOrder");
            }
        }

        public ICommand SaveOrderCommand { get; private set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        private void SaveOrder()
        {
            
            dataBaseService.SaveOrder(_order);
            CardSaved?.Invoke(this, _order);
            _navigatorService.BackToPreviousPage();
        }
    }
}
