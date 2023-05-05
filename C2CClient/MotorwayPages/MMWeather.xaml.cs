using C2CClient.MMViewModels;
using Microsoft.Extensions.DependencyInjection;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C2CClient.MotorwayPages
{
    /// <summary>
    /// Interaction logic for MMWeather.xaml
    /// </summary>
    public partial class MMWeather : UserControl
    {
        public MMWeather()
        {
            InitializeComponent();
            DataContext = App.ServiceProvider.GetService<MMWeatherViewModel>();
        }
    }
}
