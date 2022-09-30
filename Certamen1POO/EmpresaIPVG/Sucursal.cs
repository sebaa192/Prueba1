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
        public List<Region> regiones { get; set; }
        public List<Departamento> departamentos { get; set; }


        public Sucursal()
        {
            
            regiones = new List<Region>();
            this.codigoSucursal = 005;
            this.nombre = "IPVG Los Angeles";
            departamentos = new List<Departamento>();

        }
        
        public void agregaRegion(Region region)
        {
            this.regiones.Add(region);
        }

        void agregarDepa(Departamento departamento)
        {
            this.departamentos.Add(departamento);
        }
    }


}
