using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C.Server.ViewModels
{
    public class TMCViewModel : ObservableObject
    {
        public TMCViewModel()
        {

            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
        }
        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var TMCControl = obj as TMCPage.TMC;
            TMCControl.Content = new MainControl();
        }
    }
}
