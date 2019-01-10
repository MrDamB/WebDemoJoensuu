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

           
        }

        private void Rovaniemi_Click(object sender, RoutedEventArgs e)
        {
            Window1 sääTiedot1 = new Window1();
            sääTiedot1.Show();
        }

        private void Rovaniemi_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Rovaniemi_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Oulu_Click(object sender, RoutedEventArgs e)
        {
            Window2 sääTiedot2 = new Window2();
            sääTiedot2.Show();
        }

        private void Vaasa_Click(object sender, RoutedEventArgs e)
        {
            Window3 sääTiedot3 = new Window3();
            sääTiedot3.Show();
        }

        private void Kuopio_Click(object sender, RoutedEventArgs e)
        {
            Window4 sääTiedot4 = new Window4();
            sääTiedot4.Show();
        }

        private void Joensuu_Click(object sender, RoutedEventArgs e)
        {
            Window5 sääTiedot5 = new Window5();
            sääTiedot5.Show();
        }

        private void Mikkeli_Click(object sender, RoutedEventArgs e)
        {
            Window6 sääTiedot6 = new Window6();
            sääTiedot6.Show();
        }

        private void Jyväskylä_Click(object sender, RoutedEventArgs e)
        {
            Window7 sääTiedot7 = new Window7();
            sääTiedot7.Show();
        }

        private void Tampere_Click(object sender, RoutedEventArgs e)
        {
            Window8 sääTiedot8 = new Window8();
            sääTiedot8.Show();
        }

        private void Helsinki_Click(object sender, RoutedEventArgs e)
        {
            Window9 sääTiedot9 = new Window9();
            sääTiedot9.Show();
        }
    }
}
