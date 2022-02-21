using HoursTrans.ViewMoudels.Navigations;

namespace HoursTrans.ViewMoudels.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainNavigationMenue Naveer { get; set; } = new MainNavigationMenue();
    }
}