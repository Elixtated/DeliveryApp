﻿using DeliveryApp.Orders.ViewModels;
using System.Windows.Controls;

namespace DeliveryApp.Orders.Views
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            DataContext = new OrdersViewModel();
            InitializeComponent();
        }
    }
}
