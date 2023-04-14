using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Collections.Generic;

namespace PR5
{
    /// <summary>
    /// Логика взаимодействия для DayPage.xaml
    /// </summary>
    public partial class DayPage : Page
    {
        public DayPage(string daynow)
        {
            string rootFolder = System.IO.Path.GetFullPath(@"..\..\..\");
            rootFolder = rootFolder + "\\icon\\";
            InitializeComponent();
            bool first = true;
            Wether sun = new Wether();
            sun.wetherChkbx.Content = "Солнечно";

            Wether cloudSun = new Wether();
            cloudSun.wetherChkbx.Content = "Облачно с прояснениями";
            cloudSun.wetherIcon.Source = new BitmapImage(new Uri(rootFolder + "free-icon-cloud-sun-4814268.png", UriKind.Absolute));

            Wether cloud = new Wether();
            cloud.wetherChkbx.Content = "Облачно";
            cloud.wetherIcon.Source = new BitmapImage(new Uri(rootFolder + "free-icon-cloud-4814293.png", UriKind.Absolute));

            Wether rain = new Wether();
            rain.wetherChkbx.Content = "Даждливо";
            rain.wetherIcon.Source = new BitmapImage(new Uri(rootFolder + "free-icon-rain-4814304.png", UriKind.Absolute));

            Wether storm = new Wether();
            storm.wetherChkbx.Content = "Гроза";
            storm.wetherIcon.Source = new BitmapImage(new Uri(rootFolder + "free-icon-storm-4814379.png", UriKind.Absolute));

            List<Wether> wethers = new List<Wether>() { sun, cloudSun, cloud, rain, storm };
            inDayList.ItemsSource = wethers;
            
        }
    }
}
