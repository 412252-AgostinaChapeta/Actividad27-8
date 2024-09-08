using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica01.Domain
{
    public class Factura
    {
        private int NroFactura { get; set; }
        private DateTime Fecha { get; set; }
        private string Cliente { get; set; }
        private FormaPago FormaPago { get; set; }
        private List<DetalleFactura> DetalleFacturas { get; set; }

        public Factura(int nro, string cliente, FormaPago fp, List<DetalleFactura> lstDF)
        {
            NroFactura = nro;
            Fecha = DateTime.Now;
            Cliente = cliente;
            FormaPago = fp;
            DetalleFacturas = lstDF;
        }

        public override string ToString()
        {
            string detalles = string.Empty;

            foreach(DetalleFactura df in DetalleFacturas)
            {
                detalles += df.ToString();
            }

            return "Nro Factura: " + NroFactura.ToString() +
                    "\n Fecha : " + Fecha +
                    "\n Forma Pago  : " + FormaPago.ToString() +
                    "\n Detalles : " + detalles +
                    "\n Cliente: " + Cliente;
        }
    }
}
