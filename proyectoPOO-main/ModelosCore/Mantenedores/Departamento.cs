using DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosCore.Mantenedores
{
    public class Departamento : IDataEntity
    {
        public int codigodepa { get; set; }
        public string nombredepa { get; set; }
        public Jefe jefe { get; set; }
        public Sucursal sucursal { get; set; }

        public data Data { get; set; }

        public List<Parametros> parametros { get; set; }
       
       

        public Departamento()
        {
            sucursal= new Sucursal();   
            jefe = new Jefe();
            Data = new data();
            parametros = new List<Parametros>();
        }
    
    }
}
