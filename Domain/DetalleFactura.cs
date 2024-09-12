using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica01.Domain
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public Articulo Articulo {  get; set; }
        public int Cantidad { get; set; }


        public DetalleFactura(int id, Articulo articulo, int cant)
        {
            this.Id = id;
            this.Articulo = articulo;
            this.Cantidad = cant;
        }

        public override string ToString()
        {
            return "ID: " + Id.ToString() +
                    "\n Articulo  : " + Articulo.ToString() +
                    "\n Cantidad: " + Cantidad.ToString();
        }
    }
}
