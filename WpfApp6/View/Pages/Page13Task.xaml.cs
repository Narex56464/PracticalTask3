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
    /// Логика взаимодействия для Page13Task.xaml
    /// </summary>
    public partial class Page13Task : Page
    {
        public Page13Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, b, a;

            x = Convert.ToDouble(TbX.Text);
            b = Convert.ToDouble(TbB.Text);
            a = Convert.ToDouble(TbA.Text);

            TbRes.Text = $"{(a) / (x - a) + (Math.Pow(b, x) + Math.Pow(Math.Cos(x), 3)) / (Math.Pow(Math.Log(a), 3) + 4.5)}";

            TbX.Text = string.Empty;
            TbA.Text = string.Empty;
            TbB.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page14Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
