using System.Windows.Controls;
using CommonModule.Navigator.ViewModels;

namespace CommonModule.Services
{
    public class NavigatorService
    {
        private static NavigatorService _instance;

        private Page _previousPage;
        
        private NavigatorService()
        {
            NavigatorViewModel = new NavigatorViewModel();
        }

        public static NavigatorService GetInstance()
        {
            return _instance ?? (_instance = new NavigatorService());
        }
        
        public NavigatorViewModel NavigatorViewModel { get; }

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