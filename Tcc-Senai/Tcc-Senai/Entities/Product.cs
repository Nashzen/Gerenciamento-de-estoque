using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccSenai.Entities.Base;

namespace TccSenai.Entities
{
    public class Product : EntityBase
    {
        public Product(string name, string genre, DateTime releaseYear, double price)
        {
            Name = name;
            Genre = genre;
            ReleaseYear = releaseYear;
            Price = price;
        }

        public string Name { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseYear { get; set; }

        public double Price { get; set; }
    }
}
