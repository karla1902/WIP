using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WIP_web.Models.Backlog
{
    public class Backlog
    {
        [Key]
        public int Id { get; set; }
        public int UnidadNegocio { get; set; }
        public int Nombre { get; set; }
        public int ValorUFHH { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
