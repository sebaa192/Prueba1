using Modelos;
using Modelos.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Negocio.Mantenedores
{
    public class CargoBL : ICrud<Cargos>
    {
        public ResponseExec Create(Cargos o)
        {
            ResponseExec res = new ResponseExec();
            res.mensaje = "";
            try
            {
                o.Data.execData("Insert into Cargos(idcargo,nombreCargo) values(" + o.idcargo + "," + o.nombreCargo + ")");
                res.mensaje = "INGRESO CORRECTO DEL CARGO";
                return res;
            }
            catch (Exception ex)
            {

                res.error = true;
                res.mensaje = ex.Message;
                return res;

            }
            
        }

        public ResponseExec Delete(Cargos o)
        {
            throw new NotImplementedException();
        }

        public List<Cargos> GeQuery(Cargos o)
        {
            throw new NotImplementedException();
        }

        public List<Cargos> Get(Cargos o)
        {
            throw new NotImplementedException();
        }

        public Cargos GetById(Cargos o)
        {
            throw new NotImplementedException();
        }

        public ResponseExec Update(Cargos o)
        {
            throw new NotImplementedException();
        }
    }
}
