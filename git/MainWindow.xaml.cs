﻿using System.CodeDom;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace git
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("lol");
        }

        private void devide_Click(object sender, RoutedEventArgs e)
        {
            final.Text = (Int32.Parse(a.Text) / Int32.Parse(b.Text)).ToString();

        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            final.Text = (Int32.Parse(a.Text) * Int32.Parse(b.Text)).ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            final.Text = ((Int32.Parse(a.Text) - Int32.Parse(b.Text))).ToString();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            final.Text = (Int32.Parse(a.Text) + Int32.Parse(b.Text)).ToString();
        }
    }
}