using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaIPVG
{
    public class Jefe
    {
        public int  codJefe { get; set; }
        public string nombre { get; set; }

        public Jefe()
        {
            
        }

        public Jefe(int codJefe, string nombre)
        {
            this.codJefe = codJefe;
            this.nombre = nombre;
        }
       

    }



}
