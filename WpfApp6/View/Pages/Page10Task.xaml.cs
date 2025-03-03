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
    /// Логика взаимодействия для Page10Task.xaml
    /// </summary>
    public partial class Page10Task : Page
    {
        public Page10Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);

            TbRes.Text = $"{(Math.Exp(Math.Pow(x, 3)) + Math.Pow(Math.Cos(x - 4), 2)) / (Math.Tan(x) + 5.2 * y)}";
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page11Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
