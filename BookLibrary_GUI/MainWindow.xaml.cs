﻿using BookLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookLibrary_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Library LibraryKNM { get; set; } = Library.Instance;
        public MainWindow()
        {
            InitializeComponent();

            Refresh();
        }
        private void Refresh()
        {
            ListView_AllBooks.Items.Clear();
            foreach (var book in LibraryKNM.Books.Where(x => !x.IsBorrowed).ToList())
            {
                ListView_AllBooks.Items.Add(book.ToString());
            }
            ListView_AllUsers.Items.Clear();
            foreach (var user in LibraryKNM.Users)
            {
                ListView_AllUsers.Items.Add(user.ToString());
            }

        }
        private void Window_AddNewBook(object sender, RoutedEventArgs e)
        {
            var window = new Window_AddBook();
            window.ShowDialog();
            Refresh();
        }
        private void Window_AddNewUser(object sender, RoutedEventArgs e)
        {
            var window = new Window_AddUser();
            window.ShowDialog();
            Refresh();
        }

        private void ListView_AllBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_BorrowedBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_AllUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window_BorrowBook();
            window.ShowDialog();
            Refresh();
        }
    }
}
