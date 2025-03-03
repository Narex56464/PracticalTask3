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
using WpfApp6.Servers;

namespace WpfApp6.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page3Task.xaml
    /// </summary>
    public partial class Page3Task : Page
    {
        public Page3Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double y, h;

            y = Convert.ToDouble(TbY.Text);
            h = Convert.ToDouble(TbH.Text);

            TbRes.Text = $"{(Math.Tan(Math.Pow(y, 3) - Math.Pow(h, 4)) + Math.Pow(h, 2)) / (Math.Pow(Math.Sin(h + y), 3))}";

            TbY.Text = string.Empty;
            TbH.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page4Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
