using System.Windows;
using WpfApp6.Servers;
using WpfApp6.View.Pages;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyNavigation.MyConnect = MainFrame;

            MainFrame.Navigate(new MainPage());
        }
    }
}
