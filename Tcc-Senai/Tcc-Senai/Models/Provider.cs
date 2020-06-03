using TCC_Senai.Models.Base;

namespace TCC_Senai.Models
{
    public class Provider : EntityBase
    {
        public string Name { get; set; }

        public string Cnpj { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}