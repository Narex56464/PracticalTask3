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
    /// Логика взаимодействия для Page30Task.xaml
    /// </summary>
    public partial class Page30Task : Page
    {
        public Page30Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x;

            x = Convert.ToDouble(TbX.Text);

            TbRes.Text = $"{(Math.Sqrt(Math.Pow(3 + x, 6) - Math.Log(x))) / (Math.Exp(0) + Math.Asin(6 * Math.Pow(x, 2)))}";

            TbX.Text = string.Empty;
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
