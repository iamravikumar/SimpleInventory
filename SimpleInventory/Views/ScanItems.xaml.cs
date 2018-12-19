﻿using SimpleInventory.ViewModels;
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

namespace SimpleInventory.Views
{
    /// <summary>
    /// Interaction logic for ScanItems.xaml
    /// </summary>
    public partial class ScanItems : UserControl
    {
        public ScanItems()
        {
            InitializeComponent();
        }

        private void BarcodeScanTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                (DataContext as ScanItemsViewModel)?.MarkItemPurchased.Execute(null);
            }
        }
    }
}
