using System.Windows.Controls;
using System.Windows;

namespace HoursTrans.DeskTop.Views.Navigation
{
    /// <summary>
    /// Interaction logic for MenueBar.xaml
    /// </summary>
    public partial class MenueBar : UserControl
    {
        public MenueBar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                return;
            }
            if(Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                return;
            }
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Application.Current.MainWindow.DragMove();
        }
    }
}