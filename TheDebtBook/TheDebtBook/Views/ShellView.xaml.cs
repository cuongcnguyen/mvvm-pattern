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
using System.Windows.Shapes;
using Caliburn.Micro;

namespace TheDebtBook.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
            DataContext = this;
        }
        /*
        private void OpenChildWindow_Click(object sender, RoutedEventArgs e)
        {

        }
        */

        private void OpenChildPage_OnClick(object sender, RoutedEventArgs e)
        {
            ChildView2 addDebtorWindow = new ChildView2();
            addDebtorWindow.Show();
        }
    }
}
