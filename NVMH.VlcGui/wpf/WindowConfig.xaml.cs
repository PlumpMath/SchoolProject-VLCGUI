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


using NVMH.VlcGui.Interfaces;


namespace NVMH.VlcGui
{
    /// <summary>
    /// Interaktionslogik für WindowConfig.xaml
    /// </summary>
    public partial class WindowConfig : Window, IPlayerList
    {
        public WindowConfig()
        {
            InitializeComponent();
        }
    }
}
