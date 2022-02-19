using HoursTrans.ViewMoudels.Commands.Navigation;
using HoursTrans.ViewMoudels.ViewModels;
using System.Windows.Input;

namespace HoursTrans.ViewMoudels.Navigations
{
    public class SideNavigationMenu : BaseViewModel
    {
        MainMenu _menu;

        public SideNavigationMenu(MainMenu menu)
        {
            _menu = menu;
        }

        public BaseViewModel SelectedView { get; set; }

        public ICommand SideNavigator => new SidMenuuNavigathionCommand(this, _menu);
    }
}