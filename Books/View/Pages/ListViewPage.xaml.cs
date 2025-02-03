using Books.AppData;
using System.Windows.Controls;

namespace Books.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListViewPage.xaml
    /// </summary>
    public partial class ListViewPage : Page
    {
        private BookService _bookService;
        public ListViewPage()
        {
            InitializeComponent();

            _bookService = new BookService();
        }

        private async void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            BooksLv.ItemsSource = await _bookService.ReadJSON();
        }
    }
}
