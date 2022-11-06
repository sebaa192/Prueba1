using Modelos;
using Modelos.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mantenedores
{
    public class JefeBL : ICrud<Jefe>
    {
        public ResponseExec Create(Jefe o)
        {
            ResponseExec res = new ResponseExec();
            res.mensaje = "";

            throw new NotImplementedException();
        }

        public ResponseExec Delete(Jefe o)
        {
            throw new NotImplementedException();
        }

        public List<Jefe> GeQuery(Jefe o)
        {
            throw new NotImplementedException();
        }

        public List<Jefe> Get(Jefe o)
        {
            throw new NotImplementedException();
        }

        public Jefe GetById(Jefe o)
        {
            throw new NotImplementedException();
        }

        public ResponseExec Update(Jefe o)
        {
            throw new NotImplementedException();
        }
    }
}
