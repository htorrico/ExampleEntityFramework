using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleEntityFramework.Models
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public DateTime Fecha { get; set; }
        public string Numero { get; set; }

        //Llave foranea
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }


        public List<DetalleFactura> Detalles { get; set; }



    }
}