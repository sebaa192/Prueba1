using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Mantenedores
{
    public class Empleados : IDataEntity
    {
        public int codEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Jefe jefe { get; set; }
        public Cargos cargos { get; set; }
        public Departamento Departamento { get; set; }

        public data Data { get; set; }

        public Empleados()
        {
            Data = new data();
        }
    }
    
   
}
