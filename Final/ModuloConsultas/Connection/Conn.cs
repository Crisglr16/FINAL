using Microsoft.EntityFrameworkCore;
using ModuloConsultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Connection
{
    public class Conn:DbContext
    {
        public Conn(DbContextOptions<Conn> options) : base(options) { }

        public DbSet<ProductoModel> Productos { get; set; }

        public DbSet<ProveedorModel> Proveedores { get; set; }

        public DbSet<BodegaModel> Bodega { get; set; }
    }
}
