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
    /// Логика взаимодействия для Page21Task.xaml
    /// </summary>
    public partial class Page21Task : Page
    {
        public Page21Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double z, x, a;

            z = Convert.ToDouble(TbZ.Text);
            x = Convert.ToDouble(TbX.Text);
            a = Convert.ToDouble(TbA.Text);

            TbRes.Text = $"{(Math.Pow(Math.Sqrt(z + Math.Sqrt(z * x)), 5)) / (Math.Exp(x) + Math.Pow(a, 5) * Math.Tan(x))}";

            TbZ.Text = string.Empty;
            TbX.Text = string.Empty;
            TbA.Text = string.Empty;    
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page22Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
