using C2CClient.CHS_WeatherPortTypeService;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2CClient.MMViewModels
{
    public class LoginWindowViewModel:ObservableObject
    {
        WeatherPortType_v0p1 _weatherPortType_V0P1;
        public LoginWindowViewModel(WeatherPortType_v0p1 weatherPortType_V0P1)
        {
            _weatherPortType_V0P1= weatherPortType_V0P1;
        }

    }

}
