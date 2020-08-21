using System;
using System.Windows.Controls;
using CommonModule.Navigator.ViewModels;

namespace CommonModule.Services
{
    public class NavigatorService
    {
        private static readonly Lazy<NavigatorService> _instance = new Lazy<NavigatorService>(() => new NavigatorService());

        private Page _previousPage;
        
        private NavigatorService()
        {
            NavigatorViewModel = new NavigatorViewModel();
        }
        public NavigatorViewModel NavigatorViewModel { get; }

        public static NavigatorService Instance { get => _instance.Value; }
        

        public void SetCurrentPage(Page currentPage)
        {
            _previousPage = NavigatorViewModel.CurrentContent;
            NavigatorViewModel.CurrentContent = currentPage;
        }

        public void BackToPreviousPage()
        {
            NavigatorViewModel.CurrentContent = _previousPage;
        }
    }
}