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
        BooksManager _booksManager;
        public DataGridPage()
        {
            InitializeComponent();

            _booksManager = new BooksManager();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BooksDg.ItemsSource = await _booksManager.ReadJSON();
        }
    }
}
