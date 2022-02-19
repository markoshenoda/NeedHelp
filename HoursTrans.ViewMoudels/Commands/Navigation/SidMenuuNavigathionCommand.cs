using HoursTrans.ViewMoudels.Navigations;
using HoursTrans.ViewMoudels.ViewModels;
using System;
using System.Windows.Input;

namespace HoursTrans.ViewMoudels.Commands.Navigation
{
    public class SidMenuuNavigathionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        MainMenu _menu;

        SideNavigationMenu _sender;

        public SidMenuuNavigathionCommand(SideNavigationMenu sender, MainMenu menu)
        {
            _sender = sender;
            _menu = menu;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is SideMenu sm)
            {
                switch (sm)
                {
                    case SideMenu.Home:
                        switch (_menu)
                        {
                            case MainMenu.Pepole:
                                _sender.SelectedView = new PepoleHomeViewModel();
                                break;
                            case MainMenu.Cars:
                                break;
                            case MainMenu.PcInspation:
                                break;
                            case MainMenu.MobileInspation:
                                break;
                            case MainMenu.Trips:
                                break;
                        }
                        break;
                    case SideMenu.Add:
                        switch (_menu)
                        {
                            case MainMenu.Pepole:
                                _sender.SelectedView = new AddPepoleViewModel();
                                break;
                            case MainMenu.Cars:
                                break;
                            case MainMenu.PcInspation:
                                break;
                            case MainMenu.MobileInspation:
                                break;
                            case MainMenu.Trips:
                                break;
                        }
                        break;
                    case SideMenu.Edite:
                        break;
                    case SideMenu.Delete:
                        break;
                    case SideMenu.Report:
                        break;
                }
            }
        }
    }
}