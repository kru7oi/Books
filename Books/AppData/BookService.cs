using Books.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Books.AppData
{
    public class BookService
    {
        public const string JSON_PATH = "https://mysafeinfo.com/api/data?list=bestnovels&format=json&case=default";

        public List<Book> Books { get; private set; }

        public async Task LoadBookAsync()
        {
            try
            {
                HttpClient client = new();
                var response = await client.GetAsync(JSON_PATH);
            }
            catch
            {

            }
        }
    }
}
