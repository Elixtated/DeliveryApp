using CommonModule;
using CommonModule.Controls;

using CommonModule.Controls.Modules.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DeliveryApp
{
    public class OrderModule : IModule
    {
        public Page ModulePage => new Orders.Views.OrdersPage();

        public string Name => "Заявки";
    }
}
