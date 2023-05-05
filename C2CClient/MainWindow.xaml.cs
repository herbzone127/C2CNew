//using C2C.Common.CentralNodePage.CHS_Device;
//using C2CServer.CHSWeather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C2CClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //string baseAddress = "http://localhost:9080/CHS_MTW_Weather-mediationWeb/sca/CHS_MTW_WeatherExport";

            ////var getESSObservation = new C2CServer.CHSWeather.WeatherPortType_v0p1Client("WeatherSoapHttpBinding_v0p11",baseAddress);
            //var getESSObservation2 = new C2CServer.CHSWeather.getESSObservationRequest();
            ////getESSObservation2.msgContext = new C2CServer.CHSWeather.MsgContextType();
            ////getESSObservation2.getESSObservation = new C2CServer.CHSWeather.getESSObservation();
            ////getESSObservation.getESSObservation(ref getESSObservation2.msgContext, getESSObservation2.getESSObservation);

            //BasicHttpBinding myBinding = new BasicHttpBinding();
            //EndpointAddress myEndpoint = new EndpointAddress(baseAddress);
            //ChannelFactory<C2CServer.CHSWeather.WeatherPortType_v0p1> myChannelFactory = new ChannelFactory<WeatherPortType_v0p1>(myBinding, myEndpoint);

            //WeatherPortType_v0p1 instance = myChannelFactory.CreateChannel();
            //instance.getESSObservation(getESSObservation2);

            //myChannelFactory.Close();
        }
    }
}
