using DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ModelosCore.Mantenedores
{
    public class Jefe:IDataEntity
    {
        public int codJefe { get; set; }
        public string nombre { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }

        public Jefe()
        {
            Data = new data(); 
            
           parametros = new List<Parametros>(); 
        }


    }
}
