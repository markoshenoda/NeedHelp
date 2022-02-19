using HoursTrans.ViewMoudels.ViewModels;
using System.Windows.Controls;

namespace HoursTrans.DeskTop.Views
{
    /// <summary>
    /// Interaction logic for AddPepoleView.xaml
    /// </summary>
    public partial class AddPepoleView : UserControl
    {
        public AddPepoleView()
        {
            InitializeComponent();
            DataContext = new AddPepoleViewModel();
        }
    }
}
