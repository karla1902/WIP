using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WIP_web.Models
{
    public class RolCargo
    {
        [Key]
        public int Key { get; set; }
        public int Id { get; set; }
        public int Area { get; set; }
        public int Servicio { get; set; }
        public int Perfil { get; set; }
        public int Senority { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }

    }
}
