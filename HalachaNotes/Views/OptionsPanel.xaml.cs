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
using HalachaNotes;

namespace HalachaNotes.Views
{
    /// <summary>
    /// Interaction logic for OptionsPanel.xaml
    /// </summary>
    public partial class OptionsPanel : UserControl
    {
        public OptionsPanel()
        {
            InitializeComponent();
        }

        private void FontFamilyChanged(object sender, SelectionChangedEventArgs e)
        {
            //MainWindow.FontFamilyChangedEventHandler(sender, e);
        }

        private void FontSizeChanged(object sender, SelectionChangedEventArgs e)
        {
            //FontSizeChangedEventHandler(sender, e);
        }
    }
}
