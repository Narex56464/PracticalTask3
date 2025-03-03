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
    /// Логика взаимодействия для Page24Task.xaml
    /// </summary>
    public partial class Page24Task : Page
    {
        public Page24Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, a, z, b;

            x = Convert.ToDouble(TbX.Text);
            a = Convert.ToDouble(TbA.Text);
            b = Convert.ToDouble(TbB.Text);
            z = Convert.ToDouble(TbZ.Text);

            TbRes.Text = $"{(Math.Pow(Math.Cos(b * Math.Pow(x, 5)), 7) - (Math.Sin(Math.Pow(a, 2) + Math.Cos(Math.Pow(x, 3) + Math.Pow(z, 5) - Math.Pow(a, 2))))) / (Math.Asin(Math.Pow(a, 2)) + Math.Acos(Math.Pow(x, 7) - Math.Pow(a, 2)))}";

            TbA.Text = string.Empty;
            TbB.Text = string.Empty;
            TbX.Text = string.Empty;
            TbZ.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page25Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
