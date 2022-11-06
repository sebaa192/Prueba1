using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaIPVG
{
    public class Sucursal
    {

        public int codigoSucursal { get; set; }
        public string nombre { get; set; }
        public Region regiones { get; set; }
        public List<Personal> empleados { get; set; }

        public Sucursal()
        {

        }

        public Sucursal(int codigoSucursal, string nombre,Region region)
        {

            this.codigoSucursal = codigoSucursal;
            this.nombre = nombre;   
            this.regiones = region;

        }
        
        public void agregaRegion(Region region)
        {
          this.regiones = region;
        }

        void agregarEmpelados(Personal empleados)
        {
            this.empleados.Add(empleados);
        }
    }


}
