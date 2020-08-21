using CommonModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Orders.Model
{
    public class OrderListItem : INotifyPropertyChanged
    {
        private bool _isChecked;
        public OrderListItem(Order order)
        {
            Order = order;
        }
        
        public Order Order { get; set; }

        public bool isChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged("isChecked");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

