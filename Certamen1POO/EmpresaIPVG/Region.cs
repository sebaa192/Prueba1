using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaIPVG
{
    public class Region
    {
        public int codigoRegion { get; set; }
        public string NombreRegion { get; set; }

        

        public Region()
        {
            codigoRegion = 08;
            NombreRegion = "Bio Bio";
        }

        public Region(int codRegion, string nomRegion)
        {
            this.codigoRegion = codigoRegion;
            NombreRegion = nomRegion;
        }
    }
  
}
