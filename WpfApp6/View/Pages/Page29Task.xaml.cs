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
    /// Логика взаимодействия для Page29Task.xaml
    /// </summary>
    public partial class Page29Task : Page
    {
        public Page29Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, d;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);
            d = Convert.ToDouble(TbD.Text);

            TbRes.Text = $"{(Math.Pow(Math.Cos(y), 2) + 2.4 * d) / (Math.Exp(y) + Math.Log(Math.Pow(Math.Sin(x), 2) + 6))}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
            TbD.Text = string.Empty;
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page30Task());
        }
    }
}
