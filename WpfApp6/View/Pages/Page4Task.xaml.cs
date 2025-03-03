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
    /// Логика взаимодействия для Page4Task.xaml
    /// </summary>
    public partial class Page4Task : Page
    {
        public Page4Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y;

            x = Convert.ToDouble(TbX.Text); 
            y = Convert.ToDouble(TbY.Text);

            TbRes.Text = $"{(Math.Sqrt(Math.Pow(2 + y, 2) + Math.Pow(Math.Sqrt(Math.Sin(y + 5)), 7))) + (Math.Log(x + 1) - Math.Pow(y, 3))}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page5Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
