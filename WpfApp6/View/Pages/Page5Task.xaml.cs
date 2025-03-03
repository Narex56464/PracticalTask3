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
    /// Логика взаимодействия для Page5Task.xaml
    /// </summary>
    public partial class Page5Task : Page
    {
        public Page5Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, z, c, y;

            x = Convert.ToDouble(TbX.Text);
            z = Convert.ToDouble(TbZ.Text);
            c = Convert.ToDouble(TbC.Text);
            y = Convert.ToDouble(TbY.Text);

            TbRes.Text = $"{(Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(z + x * y), 3)) / (Math.Pow(Math.Cos(Math.Pow(x, 3) * Math.Pow(c, 2)), 4))}";

            TbX.Text = string.Empty;
            TbC.Text = string.Empty;
            TbY.Text = string.Empty;
            TbZ.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page6Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
