﻿// Name: C# lab04b
// Author: James Smelser
// Date: July 9, 2019
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SwitchStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void copyClick(object sender, RoutedEventArgs e)
        {
            target.Text = "";
            string from = source.Text;
            for (int i = 0; i != from.Length; i++)
            {
                char current = from[i];
                copyOne(current);
            }
        }

        private void copyOne(char current)
        {
            switch (current)
            {
                case '<':
                    target.Text += "&lt;";
                    break;
                case '>':
                    target.Text += "&gt;";
                    break;
                case '&':
                    target.Text += "&amp;";
                    break;
                case '\"':
                    target.Text += "&#34;";
                    break;
                case '\'':
                    target.Text += "&#39;";
                    break;
                default:
                    target.Text += current;
                    break;
            }
        }
    }
}
