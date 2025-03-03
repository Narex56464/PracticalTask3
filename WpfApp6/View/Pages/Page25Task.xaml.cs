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
    /// Логика взаимодействия для Page25Task.xaml
    /// </summary>
    public partial class Page25Task : Page
    {
        public Page25Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double a, x, y, c;

            a = Convert.ToDouble(TbA.Text);
            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);
            c = Convert.ToDouble(TbC.Text);

            TbRes.Text = $"{(c * Math.Pow(Math.Tan(Math.Pow(a, 3)), 3) + Math.Pow(Math.Atan(a), 2)) / (Math.Sqrt(Math.Pow(y, Math.Tan(x))))}";

            TbA.Text = string.Empty;
            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
            TbC.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page26Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
