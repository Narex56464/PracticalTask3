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
    /// Логика взаимодействия для Page27Task.xaml
    /// </summary>
    public partial class Page27Task : Page
    {
        public Page27Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, c, a;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);
            c = Convert.ToDouble(TbC.Text);
            a = Convert.ToDouble(TbA.Text);

            TbRes.Text = $"{(Math.Pow(a, 5) + Math.Acos(a + Math.Pow(x, 3)) - Math.Pow(Math.Sin(y - c), 4)) / (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y))}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
            TbC.Text = string.Empty;
            TbA.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page28Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
