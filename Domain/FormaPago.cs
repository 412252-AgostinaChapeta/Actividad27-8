using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Domain
{
    public class FormaPago
    {
        private int Id {  get; set; }
        private string Nombre { get; set; }

        public FormaPago(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return "ID: " + Id.ToString() +
                    "\n Nombre : " + Nombre;
        }
    }
}
