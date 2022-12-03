using DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosCore.Mantenedores
{
    public class Sucursal: IDataEntity
    {
        public int codigoSucursal { get; set; }
        public string nombre { get; set; }      
        public Region region { get; set; }  
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }
      

        public Sucursal()
        {
            region = new Region();
            Data = new data();
            parametros = new List<Parametros>();
        }
    }
}
