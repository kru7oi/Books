using Books.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Books.AppData
{
    public class BooksManager
    {
        private const string JSON_PATH = "https://mysafeinfo.com/api/data?list=bestnovels&format=json&case=default";
        private readonly HttpClient _httpClient;

        public BooksManager()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Book>> GetJSON()
        {
            var response = await _httpClient.GetStringAsync(JSON_PATH);

            return JsonConvert.DeserializeObject<List<Book>>(response);
        }
    }
}
