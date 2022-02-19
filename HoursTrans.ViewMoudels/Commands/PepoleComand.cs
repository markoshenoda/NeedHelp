using HoursTrans.ViewMoudels.Navigations;
using HoursTrans.ViewMoudels.ViewModels;
using System;
using System.Windows.Input;

namespace HoursTrans.ViewMoudels.Commands
{
    public class PepoleComand : ICommand
    {
        private PepoleViewModel _pepoleViewModel;
        private readonly SideMenu _sideMenu;

        public PepoleComand(PepoleViewModel pepoleViewModel, SideMenu sideMenu)
        {
            _pepoleViewModel = pepoleViewModel;
            _sideMenu = sideMenu;
        }

        public event EventHandler CanExecuteChanged;



        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}