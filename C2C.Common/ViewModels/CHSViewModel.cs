using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C.Common.ViewModels
{
    public class CHSViewModel:ObservableObject
    {
        //public RelayCommand CHSCommand { get; set; }
        public CHSViewModel() {
            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
            CHSDeviceCommand = new RelayCommand<object>(ExecuteCHSDeviceCommand);
            CHSIncidentCommand = new RelayCommand<object>(ExecuteCHSIncidentCommand);
            CHSWeatherCommand = new RelayCommand<object>(ExecuteCHSWeatherCommand);

        }

        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var CHSControl = obj as CentralNodePage.CentralNodePage;
            CHSControl.Content = new MainControl();
        }
        public RelayCommand<object> CHSDeviceCommand { get; }
        private void ExecuteCHSDeviceCommand(object obj)
        {
            var CHSControl = obj as CentralNodePage.CentralNodePage;
            CHSControl.Content = new CentralNodePage.CHS_Device.CHSDevice();
        }
        public RelayCommand<object> CHSIncidentCommand { get; }
        private void ExecuteCHSIncidentCommand(object obj)
        {
            var CHSControl = obj as CentralNodePage.CentralNodePage;
            CHSControl.Content = new CentralNodePage.CHSIncident.CHSIncident();
        }
        public RelayCommand<object> CHSWeatherCommand { get; }
        private void ExecuteCHSWeatherCommand(object obj)
        {
            var CHSControl = obj as CentralNodePage.CentralNodePage;
            CHSControl.Content = new CentralNodePage.CHSWeather.CHSWeather();
        }
    }
}
