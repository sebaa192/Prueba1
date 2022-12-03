using DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosCore.Mantenedores
{
    public class Region:IDataEntity
    {
        public int codigoRegion { get; set; }
        public string nombreRegion { get; set; }
        public data  Data { get; set; }
        public List<Parametros> parametros { get; set; }

        public Region()
        {
            Data = new data();
            parametros = new List<Parametros>();    

        }

    }
}
