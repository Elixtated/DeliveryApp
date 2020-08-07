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
            NavigatorService = NavigatorService.GetInstance();
            Modules = new ObservableCollection<IModule>();
            //OpenModulePageCommand = new RelayCommand<IModule>(OpenModulePage);
            
        }

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

        //public ICommand OpenModulePageCommand { get; }
        private void OpenModulePage(IModule module)
        {
            NavigatorService.SetCurrentPage(module.ModulePage);
        }

        public ObservableCollection<IModule> Modules { get; set; }
    }
}
