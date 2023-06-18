using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_relationship.Entity
{
    internal class Category
    {
        public Category()
        {
            Products= new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } 
        public override string ToString() =>Name;
    }
}
