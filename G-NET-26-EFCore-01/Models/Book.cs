using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_EFCore_01.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }
        public int YearPublished { get; set; }
        public bool IsInStock { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Author> Authors { get; set; } = new List<Author>();
    }
}
