﻿using Practica01.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Data
{
    public interface IRepoFactura
    {
        bool Save(Factura oFactura);
    }
}
