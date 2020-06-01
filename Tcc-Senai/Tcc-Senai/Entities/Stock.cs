using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccSenai.Entities.Base;

namespace TccSenai.Entities
{
    public class Stock : EntityBase
    {
        public Stock(int totalAmmount, int availableAmmount)
        {
            TotalAmmount = totalAmmount;
            AvailableAmmount = availableAmmount;
        }

        public int TotalAmmount { get; set; }

        public int AvailableAmmount { get; set; }

        //public string ProductId { get; set; }

        //public Product Product { get; set; }

    }
}
