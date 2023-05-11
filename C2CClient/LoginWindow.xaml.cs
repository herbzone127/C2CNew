using C2CClient.CHS_WeatherPortTypeService;
using C2CClient.MMViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace C2CClient
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        WeatherPortType_v0p1 _weatherPortType_V0P1;
        public LoginWindow(WeatherPortType_v0p1 weatherPortType_V0P1)
        {
            
            InitializeComponent();
            _weatherPortType_V0P1 = weatherPortType_V0P1;

           
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string UserId = textUserId.Text;
            string OperationId = textOperationId.Text;
            string Password = passwordBox1.Password;
            var request = new getESSObservationRequest();
            var getESS = new getESSObservation();
            getESS.deviceInformationRequestMsgField = new DeviceInformationRequest();
            getESS.deviceInformationRequestMsgField.authenticationField = new Authentication();
            var auth =getESS.deviceInformationRequestMsgField.authenticationField;
            auth.useridField = UserId;
            auth.operatoridField = OperationId;
            auth.passwordField = Password;
            request.getESSObservation=getESS;
            var cert = Selfsigned.Certificates.LoadCertificate("Test");
           var result = _weatherPortType_V0P1.getESSObservation(request);

            if (result!=null)
            {
                StaticVariables.PasswordField = Password;
                StaticVariables.UserIdField = UserId;
                StaticVariables.OperationIdField = OperationId;
                MainWindow MW = new MainWindow();
                this.Close();
                MW.Show();
               
                
            }
            else
            {
                MessageBox.Show("Please Enter Valid Credentials", "Invalid User Credentials");
            }
        }
    }
}
