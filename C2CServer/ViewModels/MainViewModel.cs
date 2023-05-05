using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using C2C.Server;

namespace C2CServer.ViewModels
{
    public class MainViewModel:ObservableObject
    {
        private UserControl _controlPage;

        public UserControl ControlPage
        {
            get { return _controlPage; }
            set { SetProperty(ref _controlPage, value); }
        }

        public MainViewModel()
        {

            ControlPage = new MainControl();
        }
    }
}
