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

namespace DNwpf2
{
    /// <summary>
    /// Логика взаимодействия для WindowAvtMain.xaml
    /// </summary>
    public partial class WindowAvtMain : Window
    {
        public WindowAvtMain()
        {
            InitializeComponent();
            header.Background = new SolidColorBrush (Color.FromRgb(225, 228, 255));
            footer.Background = new SolidColorBrush(Color.FromRgb(225, 228, 255));

            MainAvt.Navigate(new PageAvtMain());
        }

        

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
