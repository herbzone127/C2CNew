
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CClient.MMViewModels
{
    public class MMDeviceViewModel:ObservableObject
    {
        public MMDeviceViewModel()
        {
            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
            MMDeviceCommand = new RelayCommand<object>(ExecuteMMDeviceCommand);
            MMIncidentCommand = new RelayCommand<object>(ExecuteMMIncidentCommand);
            MMWeatherCommand = new RelayCommand<object>(ExecuteMMWeatherCommand);
            MMGetSignalCommand = new RelayCommand<object>(ExecuteMMGetSignalCommand);
            MMGetGateStatusCommand = new RelayCommand<object>(ExecuteMMGetGateStatusCommand);

        }
        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var MMDevice1 = obj as MotorwayPages.MMDevice;
            MMDevice1.Content = new MotorwayControl();

        }
        public RelayCommand<object> MMDeviceCommand { get; }
        private void ExecuteMMDeviceCommand(object obj)
        {
            var MMControl = obj as MotorwayControl;
            MMControl.Content = new MotorwayPages.MMDevice();
        }
        public RelayCommand<object> MMIncidentCommand { get; }
        private void ExecuteMMIncidentCommand(object obj)
        {
            var MMControl = obj as MotorwayControl;
            MMControl.Content = new MotorwayPages.MMIncident();

        }
        public RelayCommand<object> MMWeatherCommand { get; }
        private void ExecuteMMWeatherCommand(object obj)
        {
            var MMControl = obj as MotorwayControl;
            MMControl.Content = new MotorwayPages.MMWeather();
        }
        public RelayCommand<object> MMGetSignalCommand { get; }
        private void ExecuteMMGetSignalCommand(object obj)
        {
            //var signalStatus = new C2CServer.MMDevice.DevicePortType_v0p1Client();
            //var signalStatus2 = new C2CServer.MMDevice.getSignalStatusRequest();
            //signalStatus2.msgContext = new C2CServer.MMDevice.MsgContextType();
            //signalStatus2.getSignalStatus = new C2CServer.MMDevice.getSignalStatus();
            //signalStatus.getSignalStatus(ref signalStatus2.msgContext, signalStatus2.getSignalStatus);
        }
        public RelayCommand<object> MMGetGateStatusCommand { get; }
        private void ExecuteMMGetGateStatusCommand(object obj)
        {
            //var gateStatus = new C2CServer.MMDevice.DevicePortType_v0p1Client();
            //var gateStatus2 = new C2CServer.MMDevice.getGateStatusRequest();
            //gateStatus2.msgContext = new C2CServer.MMDevice.MsgContextType();
            //gateStatus2.getGateStatus = new C2CServer.MMDevice.getGateStatus();
            //gateStatus.getGateStatus(ref gateStatus2.msgContext, gateStatus2.getGateStatus);
        }


    }
}
