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
using System.Xml;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            XmlDocument saaTiedot = new XmlDocument();
            saaTiedot.Load("http://api.openweathermap.org/data/2.5/weather?q=Vaasa,fi&APPID=fc1e75b8dbbcabd75b50acb117c87da9&mode=xml&units=metric");
            XmlNode temperature = saaTiedot.SelectSingleNode("//current/temperature");
            InitializeComponent();
            Lämpötila.Text = temperature.Attributes["value"].Value;
        }
    }
}
