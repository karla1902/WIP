using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WIP_web.Models.Backlog
{
    public class ValorUFHH
    {
        [Key]
        public int Id { get; set; }
        public decimal ValorUf { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
