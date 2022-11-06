using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos.Mantenedores
{
    public class Region : IDataEntity
    {
        public int codigoRegion { get; set; }
        public string nombreRegion { get; set; }

        public data Data { get; set; }

        public Region()
        {
            Data = new data();  
        }
    }
}
