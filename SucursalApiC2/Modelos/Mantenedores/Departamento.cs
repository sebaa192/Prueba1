using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos.Mantenedores
{
    public class Departamento : IDataEntity
    {
        public int codigodepa { get; set; }
        public string nombredepa { get; set; }
        public Jefe jefe { get; set; }
        public data Data { get; set; }

        public Departamento()
        {
            Data = new data();
        }
    }
    
}
