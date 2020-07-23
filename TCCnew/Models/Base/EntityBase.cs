using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCCnew.Models.Base
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            CreationDate = DateTime.Now;
        }

        [Key]

        public int Id { get; private set; }

        [Display(Name = "Data de criação")]
        public DateTime CreationDate { get; private set; }
    }
}