using HoursTrans.ViewMoudels.Commands.MainNavigation;
using HoursTrans.ViewMoudels.ViewModels;
using System.Windows.Input;

namespace HoursTrans.ViewMoudels.Navigations
{
    public class MainNavigationMenue : BaseViewModel
    {
        public BaseViewModel ViewModel { get; set; }

        public ICommand Navigator => new MainMenuNavigatioCommand(this);
    }
}