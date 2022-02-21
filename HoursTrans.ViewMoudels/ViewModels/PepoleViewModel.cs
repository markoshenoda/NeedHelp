using HoursTrans.ViewMoudels.Commands.Navigation;
using HoursTrans.ViewMoudels.Navigations;
using System.Windows.Input;

namespace HoursTrans.ViewMoudels.ViewModels
{
    public class PepoleViewModel : BaseViewModel
    {
        
        public SideNavigationMenu SideNaveer { get; } = new SideNavigationMenu(MainMenu.Pepole);
    }
}