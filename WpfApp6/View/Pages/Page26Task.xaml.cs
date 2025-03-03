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
    /// Логика взаимодействия для Page26Task.xaml
    /// </summary>
    public partial class Page26Task : Page
    {
        public Page26Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, k;

            x = Convert.ToDouble(TbX.Text);
            y = Convert.ToDouble(TbY.Text);
            k = Convert.ToDouble(TbK.Text);

            TbRes.Text = $"{(Math.Log(Math.Pow(x, 3) + y) - Math.Pow(y, 4)) / (Math.Exp(y) + 5.4 * Math.Pow(k, 3))}";

            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
            TbK.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page27Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
