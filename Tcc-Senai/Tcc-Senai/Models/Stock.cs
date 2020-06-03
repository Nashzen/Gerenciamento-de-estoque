using TCC_Senai.Models.Base;

namespace TCC_Senai.Models
{
    public class Stock : EntityBase
    {
        public int TotalAmmount { get; set; }

        public int AvailableAmmount { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}