using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaIPVG
{
    public  class Cargo
    {
        public int idcargo { get; set; }
        public string nombreCargo { get; set; }

        public Cargo(int idcargo, string nombreCargo)
        {

            this.idcargo = idcargo; 
            this.nombreCargo = nombreCargo;
        }
        public Cargo()
        {

        }
        

    }
}
