﻿using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Mantenedores
{
    public class Jefe : IDataEntity
    {
        public int codJefe { get; set; }
        public string nombre { get; set; }
        public data Data { get; set; }

        public Jefe()
        {
            Data = new data();
        }

    }
}
