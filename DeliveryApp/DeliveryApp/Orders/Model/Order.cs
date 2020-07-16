
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace DeliveryApp.Orders.Model
{
    public class Order : INotifyPropertyChanged
    {
        private string _orderNumber;
        private string _dateOrder;
        private string _leaderOrder;
        
        

        public Order()
        {
            OrderGuid = Guid.NewGuid();
        }
        public Guid OrderGuid { get;}

        public string OrderNumber
        {
            get => _orderNumber;
            set
            {
                _orderNumber = value;
                OnPropertyChanged("OrderNumber");
            }
        }
        
        

        public string DateOrder
        {
            get => _dateOrder;
            set
            {
                _dateOrder = value;
                OnPropertyChanged("DateOrder");
            }
        }
        

        public string LeaderOrder
        {
            get => _leaderOrder;
            set
            {
                _leaderOrder = value;
                OnPropertyChanged("LeaderOrder");
            }
        }
        

        public string DateComplete { get; set; }
        

        public string AboutOrder { get; set; }

       

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
