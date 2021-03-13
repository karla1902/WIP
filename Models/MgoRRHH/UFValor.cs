using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WIP_web.Models
{
    public class UFValor
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal Valor { get; set; }
    }
}
