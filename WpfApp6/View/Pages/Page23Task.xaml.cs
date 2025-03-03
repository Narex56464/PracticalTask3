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
    /// Логика взаимодействия для Page23Task.xaml
    /// </summary>
    public partial class Page23Task : Page
    {
        public Page23Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, z, b, a;

            x = Convert.ToDouble(TbX.Text);
            z = Convert.ToDouble(TbZ.Text);
            b = Convert.ToDouble(TbB.Text);
            a = Convert.ToDouble(TbA.Text);

            TbRes.Text = $"{(Math.Sqrt(Math.Abs(x) + Math.Pow(Math.Cos(x), 3) + Math.Pow(z, 4))) / (Math.Log(x) - Math.Asin(b * x - a))}";

            TbX.Text = string.Empty;
            TbB.Text = string.Empty;
            TbZ.Text = string.Empty;
            TbA.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page24Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
