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
        public string nombreRegion { get; set; }

        

        public Region()
        {
           
        }

        public Region(int codRegion, string nombreRegion)
        {
            this.codigoRegion = codigoRegion;
            this.nombreRegion = nombreRegion;
        }

        public string mostrarRegion(Region region)
        {
            return region.nombreRegion;
        }
    }
  
}
