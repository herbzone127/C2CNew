
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace C2CClient.MMViewModels
{
    public class MotorwayMainViewModel : ObservableObject
    {
        public MotorwayMainViewModel()
        {
            //MMCommand = new RelayCommand<object>(ExecuteMMCommand);
           
            MMControlPage = new MotorwayControl();
        }
        private UserControl _mmcontrolPage;

        public UserControl MMControlPage
        {
            get { return _mmcontrolPage; }
            set { SetProperty(ref _mmcontrolPage, value); }
        }
        //public RelayCommand<object> MMCommand { get; }
        //private void ExecuteMMCommand(object obj)
        //{
        //    var motorwayControl = obj as MainWindow;
        //    motorwayControl.Content = new MotorwayControl();
        //}
    }
}
