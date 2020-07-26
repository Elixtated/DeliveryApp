

using System.Windows.Controls;
using ЕmployeesModule.Employees.ViewModels;

namespace ЕmployeesModule.Employees.Views
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            DataContext = new EmployeesViewModel();
            InitializeComponent();
        }
    }
}
