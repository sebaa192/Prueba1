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

        public Departamento(int codigodepa, string nombredepa, Jefe jefe)
        {
            this.codigodepa = codigodepa;
            this.nombredepa = nombredepa;
            this.jefe = jefe;   
            
        }

        public Departamento()
        {

        }

        public void agregarJefe(Jefe jefe)
        {

            this.jefe = jefe;
        }
    }
}
