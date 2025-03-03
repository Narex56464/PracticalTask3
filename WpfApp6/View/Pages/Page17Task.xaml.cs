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
    /// Логика взаимодействия для Page17Task.xaml
    /// </summary>
    public partial class Page17Task : Page
    {
        public Page17Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, b, a, y;

            x = Convert.ToDouble(TbX.Text);
            b = Convert.ToDouble(TbB.Text);
            a = Convert.ToDouble(TbA.Text);
            y = Convert.ToDouble(TbY.Text);

            TbRes.Text = $"{(Math.Sqrt(x + b - a) + Math.Log(y)) / (Math.Tan(b + a))}";

            TbX.Text = string.Empty;
            TbB.Text = string.Empty;
            TbA.Text = string.Empty;
            TbY.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page18Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
