using Books.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Books.AppData
{
    public class BooksService
    {
        private const string JSON_PATH = "https://mysafeinfo.com/api/data?list=bestnovels&format=json&case=default";

        public async Task<List<Book>> GetBooksAsync()
        {

            // 1. Создаем НТТP - клиент (делает запрос на сервер и получает ответ)
            HttpClient httpClient = new HttpClient();

            // 2. Создаем переменную для хранения ответа от сервера.
            // HTTP - клиент просит сервер получить строку из JSON - файла, который указан в скобках
            var response = await httpClient.GetStringAsync(JSON_PATH);

            // 3. Возвращаем список 
            return JsonConvert.DeserializeObject<List<Book>>(response);
        }
    }
}
