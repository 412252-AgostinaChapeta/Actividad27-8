using Practica01.Data;
using Practica01.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Services
{
    public class FacturaManager
    {
        private IRepoFactura _repoFactura;

        public FacturaManager()
        {
            _repoFactura = new RepoFactura();
        }

        public bool SaveFactura(Factura factura)
        {
            return _repoFactura.Save(factura);
        }
    }
}
