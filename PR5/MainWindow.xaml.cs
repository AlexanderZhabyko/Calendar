using System.Windows;

namespace PR5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            MyFrame.Content = new CalendarPage();
        }
    }
}
