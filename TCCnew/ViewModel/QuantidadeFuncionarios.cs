using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCCnew.ViewModel
{
    public class QuantidadeFuncionarios
    {
        [Display(Name = "Data de criação")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        public int FuncionariosCount { get; set; }
    }
}