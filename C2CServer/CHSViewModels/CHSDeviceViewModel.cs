using C2C.Server.CentralNodePage.CHS_Device;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C.Server.CHSViewModels
{
    public class CHSDeviceViewModel : ObservableObject
    {
        public CHSDeviceViewModel()
        {
            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
            CHSGetSignalCommand = new RelayCommand<object>(ExecuteCHSGetSignalCommand);
            CHSPublishSignalCommand = new RelayCommand<object>(ExecuteCHSPublishSignalCommand);
            CHSGetGateStatusCommand = new RelayCommand<object>(ExecuteCHSGetGateStatusCommand);
            CHSPublishGateStatusCommand = new RelayCommand<object>(ExecuteCHSPublishGateStatusCommand);

        }
        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var CHSDevice1 = obj as CentralNodePage.CHS_Device.CHSDevice;
            CHSDevice1.Content = new CentralNodePage.CentralNodePage();

        }
        public RelayCommand<object> CHSGetSignalCommand { get; }
        private void ExecuteCHSGetSignalCommand(object obj)
        {
            //var signalStatus = new C2CServer.CHSDevice.DevicePortType_v0p1Client();
            //var signalStatus2 = new C2CServer.CHSDevice.getSignalStatusRequest();
            //signalStatus2.msgContext = new C2CServer.CHSDevice.MsgContextType();
            //signalStatus2.getSignalStatus = new C2CServer.CHSDevice.getSignalStatus();
            //signalStatus.getSignalStatus(ref signalStatus2.msgContext, signalStatus2.getSignalStatus);
            //var signalStatus1 = new C2CServer.CHSDevice.getSignalStatusResponse1();
            //signalStatus1.msgContext = new C2CServer.CHSDevice.MsgContextType();
            //signalStatus1.getSignalStatusResponse = new C2CServer.CHSDevice.getSignalStatusResponse();
            //signalStatus = new C2CServer.CHSDevice.getSignalStatusResponse1(signalStatus.msgContext, signalStatus.getSignalStatusResponse);
        }
        public RelayCommand<object> CHSPublishSignalCommand { get; }
        private void ExecuteCHSPublishSignalCommand(object obj)
        {
            //var publishSignal = new C2CServer.CHSDevice.DevicePortType_v0p1Client();
            //var publishSignal2 = new C2CServer.CHSDevice.publishSignalStatusRequest();
            //publishSignal2.msgContext = new C2CServer.CHSDevice.MsgContextType();
            //publishSignal2.publishSignalStatus = new C2CServer.CHSDevice.publishSignalStatus();
            //var publishSignal3 = new C2CServer.CHSDevice.publishDetectorStatusResponse();

            //publishSignal.publishSignalStatus(ref publishSignal2.msgContext, publishSignal2.publishSignalStatus);

        }
        public RelayCommand<object> CHSGetGateStatusCommand { get; }
        private void ExecuteCHSGetGateStatusCommand(object obj)
        {
            //var gateStatus = new C2CServer.CHSDevice.DevicePortType_v0p1Client();
            //var gateStatus2 = new C2CServer.CHSDevice.getGateStatusRequest();
            //gateStatus2.msgContext = new C2CServer.CHSDevice.MsgContextType();
            //gateStatus2.getGateStatus = new C2CServer.CHSDevice.getGateStatus();
            //gateStatus.getGateStatus(ref gateStatus2.msgContext, gateStatus2.getGateStatus);
        }
        public RelayCommand<object> CHSPublishGateStatusCommand { get; }
        private void ExecuteCHSPublishGateStatusCommand(object obj)
        {
            //var publishGate = new C2CServer.CHSDevice.DevicePortType_v0p1Client();
            //var publishGate2 = new C2CServer.CHSDevice.publishGateStatusRequest();
            //publishGate2.msgContext = new C2CServer.CHSDevice.MsgContextType();
            //publishGate2.publishGateStatus = new C2CServer.CHSDevice.publishGateStatus();
            //publishGate.publishGateStatus(ref publishGate2.msgContext, publishGate2.publishGateStatus);
        }

    }
}
