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
        public List<Author> Author { get; set; }=new List<Author>();
        public List<Book> Book { get; set; }= new List<Book>();
        public decimal Price { get; set; }
        public override string ToString() => $"{Price}";
    }
}
