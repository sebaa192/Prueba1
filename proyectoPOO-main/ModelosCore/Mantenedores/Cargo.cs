using DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosCore.Mantenedores
{
    public class Cargo : IDataEntity
    {
        public int idcargo { get; set; }
        public string nombreCargo { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }
        public Cargo()
        {
            Data = new data();
            parametros = new List<Parametros>();
        }
    }
}
