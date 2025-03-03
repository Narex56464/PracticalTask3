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
    /// Логика взаимодействия для Page22Task.xaml
    /// </summary>
    public partial class Page22Task : Page
    {
        public Page22Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);

            TbRes.Text = $"{Math.Cos(Math.Pow(x, 2) + 2) + (3.5 * Math.Pow(x, 2) + 1) / (Math.Pow(Math.Cos(y), 2))}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page23Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
