using C2CClient.CHS_WeatherPortTypeService;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace C2CClient.MMViewModels
{
    public class MMWeatherViewModel
    {
        WeatherPortType_v0p1 _weatherPortType_V0P1;
        public MMWeatherViewModel(WeatherPortType_v0p1 weatherPortType_V0P1)
        {
            _weatherPortType_V0P1=weatherPortType_V0P1;
            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
            MMGetESSObservationCommand = new RelayCommand<object>(ExecuteMMGetESSObservationCommand);
        }
        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var MMIncident = obj as MotorwayPages.MMWeather;
            MMIncident.Content = new MotorwayControl();

        }
        public RelayCommand<object> MMGetESSObservationCommand { get; }
        private void ExecuteMMGetESSObservationCommand(object obj)
        {

            //var getESSObservation = new C2CServer.MMWeather.WeatherPortType_v0p1Client();
           var getESSObservation2 = new getESSObservationRequest();
            var getESS = new getESSObservation();
            getESS.deviceInformationRequestMsgField = new DeviceInformationRequest();
            getESS.deviceInformationRequestMsgField.authenticationField = new Authentication();
            var auth = getESS.deviceInformationRequestMsgField.authenticationField;
            auth.useridField = StaticVariables.UserIdField;
            auth.operatoridField = StaticVariables.OperationIdField;
            auth.passwordField = StaticVariables.PasswordField;
            getESSObservation2.getESSObservation = getESS;
          var result=  _weatherPortType_V0P1.getESSObservation(getESSObservation2);
            var serialize = JsonConvert.SerializeObject(result);
            MessageBox.Show(serialize);
            //getESSObservation2.msgContext = new C2CServer.MMWeather.MsgContextType();
            //getESSObservation2.getESSObservation = new C2CServer.MMWeather.getESSObservation();
            //getESSObservation.getESSObservation(ref getESSObservation2.msgContext, getESSObservation2.getESSObservation);
        }
    }
}
