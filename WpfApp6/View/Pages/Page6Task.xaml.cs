﻿using System;
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
    /// Логика взаимодействия для Page6Task.xaml
    /// </summary>
    public partial class Page6Task : Page
    {
        public Page6Task()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, b, a, y;

            x = Convert.ToDouble(TbX.Text);
            b = Convert.ToDouble(TbB.Text);
            a = Convert.ToDouble(TbA.Text); 
            y = Convert.ToDouble(TbY.Text);

            TbRes.Text = $"{(Math.Sqrt(x + b - a) + Math.Log(y)) / (Math.Tan(b + a))}";

            TbA.Text = string.Empty;
            TbB.Text = string.Empty;
            TbX.Text = string.Empty;
            TbY.Text = string.Empty;
        }

        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Page7Task());
        }

        private void BtnOnMain_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new MainPage());
        }
    }
}
