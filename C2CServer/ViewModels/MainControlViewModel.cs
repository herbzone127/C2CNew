using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace C2C.Server.ViewModels
{
    public class MainControlViewModel: ObservableObject
    {
        public RelayCommand<object> CHSCommand { get;}
        public MainControlViewModel()
        {
            CHSCommand = new RelayCommand<object>(ExecuteCHSCommand);
            MMCommand = new RelayCommand<object>(ExecuteMMCommand);
            TMCCommand = new RelayCommand<object>(ExecuteTMCCommand);
        }

        private void ExecuteCHSCommand(object obj)
        {
            var mainControl = obj as MainControl;
            mainControl.Content = new CentralNodePage.CentralNodePage();
        }
        public RelayCommand<object> MMCommand { get;}
        private void ExecuteMMCommand(object obj)
        {
            var mainControl = obj as MainControl;
            mainControl.Content = new MotorwayPage.MM();
        }
        public RelayCommand<object> TMCCommand { get;}
        private void ExecuteTMCCommand(object obj)
        {
            var mainControl = obj as MainControl;
            mainControl.Content = new TMCPage.TMC();
        }
    }
}
