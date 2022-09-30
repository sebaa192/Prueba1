using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaIPVG
{
    public class Departamento
    {
        public int codigodepa { get; set; }
        public string nombredepa { get; set; }
        public Jefe jefe { get; set; }

        public Departamento(int codigodepa, string nombredepa)
        {
            this.codigodepa = codigodepa;
            this.nombredepa = nombredepa;
            
        }

        public Departamento()
        {

        }

        public void agregarJefe(int codigJefe, string nombreJefe)
        {
            Jefe je = new Jefe();
            je.codJefe = codigJefe;
            je.nombre = nombreJefe;
            this.jefe = je;
        }
    }
}
