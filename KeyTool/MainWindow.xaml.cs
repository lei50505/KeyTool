﻿using KeyTool.source.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyTool
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuImportFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuExportFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuChgPsw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxContent.IsVisible)
            {
                TextBoxContent.Visibility = Visibility.Hidden;
                ButtonHide.Content = "显示";
            }
            else
            {
                TextBoxContent.Visibility = Visibility.Visible;
                ButtonHide.Content = "隐藏";
            }
            TextBoxKey.Focus();
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            string[] strs = UPinyin.strToFull("今地天天气真好啊！");
            foreach (string str in strs)
            {
                ListBoxTitle.Items.Add(str);

            }
        }

    }
}
