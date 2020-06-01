using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TccSenai.Entities.Base
{
    public abstract class EntityBase 
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid().ToString();
            CreationDate = DateTime.Now;
        }

        public string Id { get; private set; }

        public DateTime CreationDate { get; private set; }

    }
}
