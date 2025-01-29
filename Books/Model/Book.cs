using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Model
{
    public class Book
    {
        public int Rank { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Published { get; set; }
        public string Country { get; set; }
        public string OriginalLanguage { get; set; }
        public string PageRange { get; set; }
        public string WordCount { get; set; }
        public int ID { get; set; }
    }
}
