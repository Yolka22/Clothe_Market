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

namespace Market
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataSource source = new DataSource();
        public MainWindow()
        {
            DataContext = source;
            InitializeComponent();
        }


        private void stufPicked(object sender, SelectionChangedEventArgs e)
        {
            basket.Items.Add(stufListBox.SelectedItem);
        }

        private void WhitestufPicked(object sender, SelectionChangedEventArgs e)
        {
            basket.Items.Add(WhitestufListBox.SelectedItem);
        }

        private void BluestufPicked(object sender, SelectionChangedEventArgs e)
        {
            basket.Items.Add(BluestufListBox.SelectedItem);
        }

        private void Decline_Click(object sender, RoutedEventArgs e)
        {

            if (basket.SelectedIndex!=-1)
            {
                basket.Items.RemoveAt(basket.SelectedIndex);
            }
            
        }
    }
}
