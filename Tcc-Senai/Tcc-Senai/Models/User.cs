using TCC_Senai.Models.Base;

namespace TCC_Senai.Models
{
    public class User : EntityBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public Employee Employee { get; set; }
    }
}