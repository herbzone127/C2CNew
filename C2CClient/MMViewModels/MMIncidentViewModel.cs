using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CClient.MMViewModels
{
    public class MMIncidentViewModel:ObservableObject
    {
        public MMIncidentViewModel()
        {
            BackCommand = new RelayCommand<object>(ExecuteBackCommand);
            MMGetIncidentInformationCommand = new RelayCommand<object>(ExecuteMMGetIncidentInformationCommand);
            MMActionLogInfoCommand = new RelayCommand<object>(ExecuteMMActionInfoCommand);
        }
        public RelayCommand<object> BackCommand { get; }
        private void ExecuteBackCommand(object obj)
        {
            var MMIncident = obj as MotorwayPages.MMIncident;
            MMIncident.Content = new MotorwayControl();
            
        }
        public RelayCommand<object> MMGetIncidentInformationCommand { get; }
        private void ExecuteMMGetIncidentInformationCommand(object obj)
        {
            //var getIncidentInfo = new C2CServer.MMIncident.IncidentPortType_v0p1Client();
            //var getIncidentInformation = new C2CServer.MMIncident.getIncidentInformationRequest();
            //getIncidentInformation.msgContext = new C2CServer.MMIncident.MsgContextType();
            //getIncidentInformation.getIncidentInformation = new C2CServer.MMIncident.getIncidentInformation();
            //getIncidentInfo.getIncidentInformation(ref getIncidentInformation.msgContext, getIncidentInformation.getIncidentInformation);
        }
        public RelayCommand<object> MMActionLogInfoCommand { get; }
        private void ExecuteMMActionInfoCommand(object obj)
        {
            //var ActionInfo = new C2CServer.MMIncident.IncidentPortType_v0p1Client();
            //var actionInfo = new C2CServer.MMIncident.publishActionLogInformationRequest();
            //actionInfo.msgContext = new C2CServer.MMIncident.MsgContextType();
            //actionInfo.publishActionLogInformation = new C2CServer.MMIncident.publishActionLogInformation();
            //ActionInfo.publishActionLogInformation(ref actionInfo.msgContext, actionInfo.publishActionLogInformation);

        }
    }
}
