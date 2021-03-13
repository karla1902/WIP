using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WIP_web.Models
{
    public class Pricing
    {
        [Key]
        public int Id { get; set; }
        public string RolCargo { get; set; }
        public decimal ValorEstandar { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
        public decimal UFMinimo { get; set; }
        public decimal UFMaximo { get; set; }
        public decimal UFPromedio { get; set; }
        public decimal PromedioCostoHora { get; set; }
        public decimal MGOP { get; set; }
        public decimal UFValor { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
