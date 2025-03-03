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
    /// Логика взаимодействия для Page19Task.xaml
    /// </summary>
    public partial class Page19Task : Page
    {
        public Page19Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, a, b, K;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);
            a = Convert.ToDouble(TbA.Text);
            b = Convert.ToDouble(TbB.Text);
            K = Convert.ToDouble(TbK.Text);

            TbRes.Text = $"{(Math.Pow(K, -x) - a * Math.Sqrt(6) - Math.Cos(3 * a * b)) / (Math.Pow(Math.Sin(a * Math.Acos(x) + Math.Log(y)), 2))}";

            TbK.Text = string.Empty;
            TbA.Text = string.Empty;
            TbB.Text = string.Empty;
            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page20Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
