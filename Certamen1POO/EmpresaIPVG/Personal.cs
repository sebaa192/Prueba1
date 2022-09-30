using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaIPVG
{
    public class Personal
    {
        public int codEmpleado { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Jefe jefe { get; set; }
        public List<Cargo> cargo { get; set; }

        public Personal(int codEmpleado, string nombre, string apellido)
        {
            this.codEmpleado = codEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            
        }

        public Personal()
        {

        }
        public void JefeEmpleado(int codigJefe, string nombreJefe)
        {
            Jefe je = new Jefe();
            je.codJefe = codigJefe;
            je.nombre= nombreJefe;
            this.jefe = je;
        }

        void agregarCargo(Cargo cargos)
        {
            cargo.Add(cargos);
        }
    }
}
