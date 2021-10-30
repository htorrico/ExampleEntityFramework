using ExampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleEntityFramework
{
    public class Contexto : DbContext
    {
        public Contexto() : base("MyContextDB") { }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Cliente>  Clientes { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public virtual DbSet<Producto> Productos  { get; set; }

    }
}