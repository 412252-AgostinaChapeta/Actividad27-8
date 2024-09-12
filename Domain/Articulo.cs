using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Domain
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public int PrecioUnitario {  get; set; }

        public Articulo(int id, string nombre, int pre)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnitario = pre;
        }

        public override string ToString()
        {
            return "ID: " + Id.ToString() +
                    "\n Nombre : " + Nombre +
                    "\n Pre Uni: " + PrecioUnitario;
        }
    }
}
