using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2C.Common.CHSViewModels
{
    public class CHSIncidentViewModel
    {
        public CHSIncidentViewModel()
        {
            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
            CHSGetIncidentInformationCommand = new RelayCommand<object>(ExecuteCHSGetIncidentInformationCommand);
            CHSPublishIncidetInformationCommand = new RelayCommand<object>(ExecuteCHSPublishIncidentInformationCommand);
            CHSActionLogInfoCommand = new RelayCommand<object>(ExecuteCHSActionInfoCommand);
        }
        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var CHSIncident = obj as CentralNodePage.CHSIncident.CHSIncident;
            CHSIncident.Content = new CentralNodePage.CentralNodePage();
        }
        public RelayCommand<object> CHSGetIncidentInformationCommand { get; }
        private void ExecuteCHSGetIncidentInformationCommand(object obj)
        {
            var getIncidentInfo = new C2CServer.CHSIncident.IncidentPortType_v0p1Client();
            var getIncidentInformation = new C2CServer.CHSIncident.getIncidentInformationRequest();
                getIncidentInformation.msgContext = new C2CServer.CHSIncident.MsgContextType();
            getIncidentInformation.getIncidentInformation = new C2CServer.CHSIncident.getIncidentInformation();
            getIncidentInfo.getIncidentInformation(ref getIncidentInformation.msgContext, getIncidentInformation.getIncidentInformation);
        }
        public RelayCommand<object> CHSPublishIncidetInformationCommand { get; }
        private void ExecuteCHSPublishIncidentInformationCommand(object obj)
        {
            var IncidentInfo = new C2CServer.CHSIncident.IncidentPortType_v0p1Client();
            var publishIncidentInfo = new C2CServer.CHSIncident.publishIncidentInformationRequest();
            publishIncidentInfo.msgContext = new C2CServer.CHSIncident.MsgContextType();
            publishIncidentInfo.publishIncidentInformation = new C2CServer.CHSIncident.publishIncidentInformation();
            IncidentInfo.publishIncidentInformation(ref publishIncidentInfo.msgContext, publishIncidentInfo.publishIncidentInformation);
        }
        public RelayCommand<object> CHSActionLogInfoCommand { get; }
        private void ExecuteCHSActionInfoCommand(object obj)
        {
            var ActionInfo = new C2CServer.CHSIncident.IncidentPortType_v0p1Client();
            var actionInfo = new C2CServer.CHSIncident.publishActionLogInformationRequest();
            actionInfo.msgContext = new C2CServer.CHSIncident.MsgContextType();
            actionInfo.publishActionLogInformation = new C2CServer.CHSIncident.publishActionLogInformation();
            ActionInfo.publishActionLogInformation(ref actionInfo.msgContext, actionInfo.publishActionLogInformation);
            
        }
    }
}
