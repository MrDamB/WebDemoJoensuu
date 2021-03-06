﻿using System;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            XmlDocument saaTiedot = new XmlDocument();
            saaTiedot.Load("http://api.openweathermap.org/data/2.5/weather?q=Oulu,fi&APPID=fc1e75b8dbbcabd75b50acb117c87da9&mode=xml&units=metric");
            XmlNode temperature = saaTiedot.SelectSingleNode("//current/temperature");
            string temperatureArvo = temperature.Attributes["value"].Value;
            temperatureArvo = temperatureArvo.Replace(".", ",");
            decimal arvo = Convert.ToDecimal(temperatureArvo);
            InitializeComponent();
            Lämpötila.Text = arvo.ToString("0");
        }
    }
}
