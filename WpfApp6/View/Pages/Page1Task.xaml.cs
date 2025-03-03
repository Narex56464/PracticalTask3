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
    /// Логика взаимодействия для Page1Task.xaml
    /// </summary>
    public partial class Page1Task : Page
    {
        public Page1Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, a, c;

            x = Convert.ToDouble(TbX.Text);
            a = Convert.ToDouble(TbA.Text);
            c = Convert.ToDouble(TbC.Text);

            TbRes.Text = $"{(Math.Exp(x) - Math.Pow(Math.Cos(Math.Pow(x, 2) * Math.Pow(a, 5)), 4) + Math.Pow(Math.Tan(a - Math.Pow(x, 5)), 4)) / (Math.Exp(Math.Sqrt(Math.Abs(a + x * Math.Pow(c, 4)))))}";

            TbA.Text = string.Empty;
            TbC.Text = string.Empty;
            TbX.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page2Task());
        }
         
        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
