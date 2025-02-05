using Books.AppData;
using System.Windows;
using System.Windows.Controls;

namespace Books.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListViewPage.xaml
    /// </summary>
    public partial class ListViewPage : Page
    {
        BooksService _bookService;
        public ListViewPage()
        {
            InitializeComponent();

            _bookService = new BooksService();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BooksLv.ItemsSource = await _bookService.GetBooksAsync();
        }
    }
}
