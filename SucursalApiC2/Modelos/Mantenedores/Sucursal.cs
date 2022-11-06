using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Modelos.Mantenedores
{
    public class Sucursal : IDataEntity
    {
        public int codigoSucursal { get; set; }
        public string nombre { get; set; }
        public Region regiones { get; set; }
        public List<Empleados> empleados{ get; set; }

        public data Data { get; set; }

        public Sucursal()
        {   
            Data = new data();
            
        }
    }
}
