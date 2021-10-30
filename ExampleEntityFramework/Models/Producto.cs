using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleEntityFramework.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public int Precio { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }



    }
}