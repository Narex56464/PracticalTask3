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
    /// Логика взаимодействия для Page7Task.xaml
    /// </summary>
    public partial class Page7Task : Page
    {
        public Page7Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, a, y;

            x = Convert.ToDouble(TbX.Text);
            a = Convert.ToDouble(TbA.Text);
            y = Convert.ToDouble(TbY.Text);

            TbRes.Text = $"{(Math.Cos(Math.Pow(x, 3) + 6) - Math.Sin(y - a)) / (Math.Log(Math.Pow(x, 4)) - 2 * Math.Pow(Math.Sin(x), 5))}";

            TbA.Text = string.Empty;
            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page9Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
