using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_relationship.Entity
{
    internal class Capital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountrId { get; set; }

        public Country contry { get; set; }
    }
}
