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
using LiveCharts;                               // biblioteka za cartove
using LiveCharts.Wpf;                           // uz dodatak na WPF
using System.Collections.ObjectModel;           // za kolekciju lekova

namespace HealthClinic.Views
{
    /// <summary>
    /// Interaction logic for LekoviView.xaml
    /// </summary>
    public partial class LekoviView : UserControl
    {

      
        public LekoviView()
        {
            InitializeComponent();
        }
    }
}
