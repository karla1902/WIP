using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WIP_web.Models;

namespace WIP_web.Models.Data
{
    public class wipdata : DbContext
    {
        public wipdata(DbContextOptions<wipdata> options)
            : base(options)
        {
        }

        public DbSet<Backlog.Backlog> Backlog { get; set; }
        public DbSet<Backlog.Nombre> Nombre { get; set; }
        public DbSet<Backlog.UnidadNegocio> UnidadNegocio { get; set; }
        public DbSet<Backlog.ValorUFHH> ValorUFHH { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<RolCargo> RolCargo { get; set; }
        public DbSet<Senority> Senority { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<UFValor> UFValor { get; set; }
    }
}
