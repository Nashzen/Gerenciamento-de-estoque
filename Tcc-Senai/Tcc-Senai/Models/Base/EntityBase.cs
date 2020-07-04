using System;
using System.ComponentModel.DataAnnotations;

namespace TCC_Senai.Models.Base
{
    public abstract class EntityBase
    {
        //protected EntityBase()
        //{
        //    Id = Guid.NewGuid().ToString();
        //    CreationDate = DateTime.Now;
        //}
        protected EntityBase() 
        {
            CreationDate = DateTime.Now;
        }

        [Key]
        public int Id { get; private set; }

        public DateTime CreationDate { get; private set; }
    }
}