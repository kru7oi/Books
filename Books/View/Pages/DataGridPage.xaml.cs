using Books.AppData;
using System.Windows;
using System.Windows.Controls;

namespace Books.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataGridPage.xaml
    /// </summary>
    public partial class DataGridPage : Page
    {
        BookService _bookService;
        public DataGridPage()
        {
            InitializeComponent();

            _bookService = new BookService();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BooksDg.ItemsSource = await _bookService.LoadBooksAsync();
        }
    }
}
