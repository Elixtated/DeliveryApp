using CommonModule.CommonTools;
using CommonModule.Services;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CommonModule.Controls.Modules.ViewModel
{
    public class ModulesListViewModel
    {
        private IModule _selectedModule;
        public ModulesListViewModel()
        {
            NavigatorService = NavigatorService.Instance;
            Modules = new ObservableCollection<IModule>();
            OpenModulePageCommand = new RelayCommand<IModule>(OpenModulePage);
        }
        public ICommand OpenModulePageCommand { get; }

        public ObservableCollection<IModule> Modules { get; set; }

        public void AddModuleToList(IModule module)
        {
            Modules.Add(module);
        }

        public NavigatorService NavigatorService { get; private set; }

        public IModule SelectedModule
        {
            get => _selectedModule;
            set
            {
                _selectedModule = value;
                OpenModulePage(_selectedModule);
            }
        }

        
        private void OpenModulePage(IModule module)
        {
            NavigatorService.SetCurrentPage(module.ModulePage);
        }

        
    }
}
