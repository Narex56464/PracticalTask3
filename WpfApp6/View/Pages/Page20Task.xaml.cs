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
    /// Логика взаимодействия для Page20Task.xaml
    /// </summary>
    public partial class Page20Task : Page
    {
        public Page20Task()
        {
            InitializeComponent();
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page21Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, a, b, c;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);
            a = Convert.ToDouble(TbA.Text);
            b = Convert.ToDouble(TbB.Text);
            c = Convert.ToDouble(TbC.Text);

            TbRes.Text = $"{(Math.Pow(Math.Tan(y), 3) + Math.Pow(Math.Sin(x), 5) * Math.Sqrt(b - c)) / (Math.Sqrt(a - b + c))}";

            TbA.Text = string.Empty;
            TbB.Text = string.Empty;
            TbC.Text = string.Empty;
            TbY.Text = string.Empty;
            TbX.Text = string.Empty;
        }
    }
}
