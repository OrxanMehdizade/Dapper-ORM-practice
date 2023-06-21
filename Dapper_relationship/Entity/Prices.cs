using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_relationship.Entity
{


    internal class Prices
    {
        public int Id { get; set; }
        public List<Author> AuthorId { get; set; }
        public List<Book> BookId { get; set; }
        public decimal Price { get; set; }
        public override string ToString() => $"{Price}";
    }
}
