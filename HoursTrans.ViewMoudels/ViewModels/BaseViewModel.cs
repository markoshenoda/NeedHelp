using System.ComponentModel;

namespace HoursTrans.ViewMoudels.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sendr, e) => { };
    }
}