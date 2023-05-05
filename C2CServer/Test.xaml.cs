using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
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

namespace C2CServer
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
           // Uri baseAddress = new Uri("http://localhost:9080/CHS_MTW_Weather-mediationWeb/sca/CHS_MTW_WeatherExport");
           // string address = "http://localhost:9080/CHS_MTW_Weather-mediationWeb/sca/CHS_MTW_WeatherExport";
           //// C2CServer.CHSWeather.getESSObservationResponse1 getESSObservation(C2CServer.CHSWeather.getESSObservationRequest request);
           // using (ServiceHost serviceHost = new ServiceHost(typeof(CHSWeather.WeatherPortType_v0p1Client), baseAddress))
           // {
                
           //    serviceHost.AddServiceEndpoint(typeof(CHSWeather.WeatherPortType_v0p1), new BasicHttpBinding(), address);
           //     serviceHost.Open();
           //     lblShow.Content = "Service is Started";
           //     //Console.WriteLine("Press <enter> to terminate service");
           //     //Console.ReadLine();
           //    // serviceHost.Close();
           // }
          
        }
    }
}
