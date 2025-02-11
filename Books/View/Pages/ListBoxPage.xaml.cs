using Books.AppData;
using System.Windows;
using System.Windows.Controls;

namespace Books.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListBoxPage.xaml
    /// </summary>
    public partial class ListBoxPage : Page
    {
        BookService _bookService;
        public ListBoxPage()
        {
            InitializeComponent();

            _bookService = new BookService();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BooksLb.ItemsSource = await _bookService.LoadBooksAsync();
        }
    }
}
