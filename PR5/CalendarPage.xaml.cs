using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PR5
{
    public partial class CalendarPage : Page
    {
        public CalendarPage()
        {
            InitializeComponent();
            mydatepicker.SelectedDate = DateTime.Now;
            update();
        }
        public void update()
        {
            DayPanel.Children.Clear();
            int daysCount = DateTime.DaysInMonth(((DateTime)mydatepicker.SelectedDate).Year, ((DateTime)mydatepicker.SelectedDate).Month);
            int size = 80;
            for (int i = 1; i <= daysCount; i++)
            {
                DayControl day = new DayControl();
                day.Width = size;
                day.Height = size;
                day.daytext.Text = i.ToString();
                day.DayBtn.Click += dayclk;
                day.DayBtn.Name = "daybtn" + i.ToString();
                DayPanel.Children.Add(day);
            }
        }

        private void prevclk(object sender, RoutedEventArgs e)
        {
            mydatepicker.SelectedDate = ((DateTime)mydatepicker.SelectedDate).AddMonths(-1);
            update();
        }

        private void nextclk(object sender, RoutedEventArgs e)
        {
            mydatepicker.SelectedDate = ((DateTime)mydatepicker.SelectedDate).AddMonths(1);
            update();
        }
        private void dayclk(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            MainWindow.Instance.MyFrame.Content = new DayPage(button.Name);
        }
        class userselect
        {
            public DateTime date { get; set; }
            public List<bool> isselected { get; set;}
        }
    }
}
