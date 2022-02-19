using HoursTrans.ViewMoudels.Navigations;
using HoursTrans.ViewMoudels.ViewModels;
using System;
using System.Windows.Input;

namespace HoursTrans.ViewMoudels.Commands.MainNavigation
{
    public class MainMenuNavigatioCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly MainNavigationMenue _navigation;

        public MainMenuNavigatioCommand(BaseViewModel navigation)
        {
            _navigation = (MainNavigationMenue)navigation;

            Execute(MainMenu.Home);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is MainMenu menu)
            {
                switch (menu)
                {
                    case MainMenu.Home:
                        _navigation.ViewModel = new MainViewModel();
                        break;
                    case MainMenu.Pepole:
                        _navigation.ViewModel = new PepoleViewModel();
                        break;
                    case MainMenu.Cars:
                        break;
                    case MainMenu.PcInspation:
                        break;
                    case MainMenu.MobileInspation:
                        break;
                    case MainMenu.Trips:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}