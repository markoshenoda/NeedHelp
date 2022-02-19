using HoursTrans.ViewMoudels.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HoursTrans.DeskTop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Window mainWindow;

        protected override void OnStartup(StartupEventArgs e)
        {
            mainWindow = new MainWindow();

            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}