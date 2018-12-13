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
using System.Xml;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            XmlDocument saaTiedot = new XmlDocument();
            saaTiedot.Load("http://catalog.fmi.fi/geonetwork/srv/api/records/43282657-3329-4c82-bd31-2631f41357f5/formatters/xml");
        }

        private void Rovaniemi_Click(object sender, RoutedEventArgs e)
        {
            Window1 sääTiedot = new Window1();
            sääTiedot.Show();
        }

        private void Rovaniemi_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Rovaniemi_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
