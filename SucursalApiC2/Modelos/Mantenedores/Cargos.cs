using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos.Mantenedores
{
    public class Cargos: IDataEntity
    {
        public int idcargo { get; set; }
        public string nombreCargo { get; set; }
        public data Data { get; set; }

        public Cargos()
        {

            Data = new data();
        }
    
          
    }
}
