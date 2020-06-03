using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC_Senai.Models.Base;

namespace TCC_Senai.Models
{
    public class Product : EntityBase
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseYear { get; set; }

        public double Price { get; set; }
    }
}