﻿using Books.AppData;
using System.Windows;
using System.Windows.Controls;

namespace Books.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListViewPage.xaml
    /// </summary>
    public partial class ListViewPage : Page
    {
        BooksManager _booksManager;
        public ListViewPage()
        {
            InitializeComponent();

            _booksManager = new BooksManager();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BooksLv.ItemsSource = await _booksManager.ReadJSON();
        }
    }
}
