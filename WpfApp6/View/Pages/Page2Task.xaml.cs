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
    /// Логика взаимодействия для Page2Task.xaml
    /// </summary>
    public partial class Page2Task : Page
    {
        public Page2Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double c, x, t;

            c = Convert.ToDouble(TbC.Text);
            x = Convert.ToDouble(TbX.Text);
            t = Convert.ToDouble(TbT.Text);

            TbRes.Text = $"{c * Math.Pow(Math.Tan(c), 2) + (2 * Math.Pow(x, 2) + 5) / (Math.Sqrt(c + t))}";

            TbC.Text = string.Empty;
            TbT.Text = string.Empty;
            TbX.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page3Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
