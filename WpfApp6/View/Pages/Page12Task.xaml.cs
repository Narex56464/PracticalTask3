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
    /// Логика взаимодействия для Page12Task.xaml
    /// </summary>
    public partial class Page12Task : Page
    {
        public Page12Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, a;

            x = Convert.ToDouble(TbX.Text); 
            y = Convert.ToDouble(TbY.Text);
            a = Convert.ToDouble(TbA.Text);

            TbRes.Text = $"{(Math.Pow(Math.Cos(Math.Abs(y + x)), 3) - (x + y)) / (Math.Pow(Math.Tan(x + a), 4) * Math.Pow(x, 5))}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
            TbA.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page13Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
