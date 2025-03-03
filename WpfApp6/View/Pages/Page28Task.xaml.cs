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
    /// Логика взаимодействия для Page28Task.xaml
    /// </summary>
    public partial class Page28Task : Page
    {
        public Page28Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z, c;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);
            z = Convert.ToDouble(TbZ.Text);
            c = Convert.ToDouble(TbB.Text);

            TbRes.Text = $"{(Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(z + Math.Pow(x, 3) * y), 3 * x)) / (Math.Pow(Math.Cos(Math.Pow(x, 3) * Math.Pow(c, 2)), 2))}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;    
            TbZ.Text = string.Empty;
            TbB.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page29Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
