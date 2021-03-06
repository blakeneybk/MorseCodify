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
using MorseCodify.Model;
using MorseCodify.Service;

namespace MorseCodify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Handler for the encode button to convert the text in english textbox to morse code text in textbox morse
        private void Button_Click_Encode(object sender, RoutedEventArgs e)
        {
            MorseCoder mc = new MorseCoder();
            textbox_Morse.Text = mc.Encode(textbox_English.Text, Codex.Morse);
        }
    }
}
