using DeliveryApp.MainWindow.ViewModels;
using System.Windows;

namespace DeliveryApp.MainWindow.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            DataContext = new MainWindowViewModel();
            InitializeComponent();
        }
    }
}
