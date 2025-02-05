using Books.View.Pages;
using System.Windows;

namespace Books
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListViewBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListViewPage());
        }

        private void ListBoxBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGridBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
