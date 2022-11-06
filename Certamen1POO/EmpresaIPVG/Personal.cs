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
        public Cargo cargo { get; set; }
        public Departamento departamento { get; set; }

        public Personal(int codEmpleado, string nombre, string apellido, Jefe jefe, Cargo cargo, Departamento departamento)
        {
            this.codEmpleado = codEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            this.jefe = jefe;
            this.cargo = cargo;
            this.departamento = departamento;

            
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
        public string mostrarJefe(Jefe jefe)
        {
            string nomJefe = jefe.nombre;

            return nomJefe ;
        }
        public string mostrarCargo(Cargo cargos)
        {
            return cargos.nombreCargo;
        }
        public string mostrarDepartamento(Departamento departamento)
        {
            return departamento.nombredepa;
        }
        void agregarCargo(Cargo cargos)
        {
            this.cargo=cargos;
        }
        
        
    }
}
