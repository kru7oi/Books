using Books.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace Books.AppData
{
    public class BookService
    {
        public const string JSON_PATH = "https://mysafeinfo.com/api/data?list=bestnovels&format=json&case=default";

        public List<Book> Books { get; private set; }

        public async Task<List<Book>> LoadBooksAsync()
        {
            try
            {
                HttpClient client = new();
                var response = await client.GetStringAsync(JSON_PATH);

                if (!string.IsNullOrEmpty(response))
                {
                    Books = JsonConvert.DeserializeObject<List<Book>>(response);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return Books;
        }
    }
}
