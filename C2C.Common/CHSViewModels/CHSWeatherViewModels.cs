using C2CServer.CHSWeather;
using C2CServer.TransportDevice;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace C2C.Common.CHSViewModels
{
    public class CHSWeatherViewModels
    {
        public CHSWeatherViewModels()
        {
            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
            CHSGetESSObservationCommand = new RelayCommand<object>(ExecuteCHSGetESSObservationCommand);
            CHSPublishESSObservationCommand = new RelayCommand<object>(ExecuteCHSPublishObservationCommand);
        }
        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var CHSWeather = obj as CentralNodePage.CHSWeather.CHSWeather;
            CHSWeather.Content = new CentralNodePage.CentralNodePage();
        }
        public RelayCommand<object> CHSGetESSObservationCommand { get; }
        private void ExecuteCHSGetESSObservationCommand(object obj)
        {
           var getESSObservation = new C2CServer.CHSWeather.WeatherPortType_v0p1Client();
            var getESSObservation2 = new C2CServer.CHSWeather.getESSObservationRequest();
            getESSObservation2.msgContext = new C2CServer.CHSWeather.MsgContextType();
            getESSObservation2.getESSObservation = new C2CServer.CHSWeather.getESSObservation();
            getESSObservation.getESSObservation(ref getESSObservation2.msgContext, getESSObservation2.getESSObservation);
        }
        public RelayCommand<object> CHSPublishESSObservationCommand { get; }
        private void ExecuteCHSPublishObservationCommand(object obj)
        {
            //var publishESSObservation = new C2CServer.CHSWeather.WeatherPortType_v0p1Client();
            //var publishESSObservation2 = new C2CServer.CHSWeather.publishESSObservationRequest();
            //publishESSObservation2.msgContext = new C2CServer.CHSWeather.MsgContextType();
            //publishESSObservation2.publishESSObservation = new C2CServer.CHSWeather.publishESSObservation();
            //publishESSObservation.publishESSObservation(ref publishESSObservation2.msgContext, publishESSObservation2.publishESSObservation);

            //publishESSObservation.publishESSObservation(msgContext);
            //publishESSObservation = new C2CServer.CHSWeather.getESSObservationResponse1();
            //publishESSObservation.msgContext = new C2CServer.CHSWeather.MsgContextType();
            //publishESSObservation.getESSObservationResponse = new C2CServer.CHSWeather.getESSObservationResponse();
            

            //publishESSObservation = new C2CServer.CHSWeather.publishESSObservationRequest(publishESSObservation.msgContext, publishESSObservation.publishESSObservation);
        }
    }
}
