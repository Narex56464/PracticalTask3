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
    /// Логика взаимодействия для Page11Task.xaml
    /// </summary>
    public partial class Page11Task : Page
    {
        public Page11Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);

            TbRes.Text = $"{(2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(y), 2)))) / (Math.Exp(y) + Math.Pow(Math.Sin(x), 2))}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page12Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
