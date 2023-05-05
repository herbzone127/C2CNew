using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C.Server.ViewModels
{
    public class MMViewModel : ObservableObject
    {
        public MMViewModel() {

            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
        }
        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var MMControl = obj as MotorwayPage.MM;
            MMControl.Content = new MainControl();
        }
    }
    
}
