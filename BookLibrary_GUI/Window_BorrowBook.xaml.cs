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

namespace BookLibrary_GUI
{
    /// <summary>
    /// Interaction logic for Window_BorrowBook.xaml
    /// </summary>
    public partial class Window_BorrowBook : Window
    {
        public Window_BorrowBook()
        {
            InitializeComponent();
        }

        private void ListView_SelectBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
