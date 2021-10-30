using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleEntityFramework.Models
{
    public class DetalleFactura
    {
        public int DetalleFacturaID { get; set; }
        public int Cantidad { get; set; }
        public int SubTotal { get; set; }

        //Llaves foraneas
        public int FacturaID { get; set; }
        public Factura Factura { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

    }
}