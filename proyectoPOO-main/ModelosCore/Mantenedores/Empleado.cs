using DataCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosCore.Mantenedores
{
    public class Empleado : IDataEntity
    {
        public int codEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Jefe jefe { get; set; }
        public Cargo cargo { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }

        public Empleado()
        {

            jefe = new Jefe();
            cargo = new Cargo();
            Data = new data();
             parametros = new List<Parametros>();   
        }
    }
}
