using ModelosCore;
using ModelosCore.Mantenedores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioCore.Mantenedores
{
    public class CargoBL : ICrud<Cargo>
    {

        ResponseExec resp = new ResponseExec();
        public ResponseExec Create(Cargo o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT INTO Cargo (idcargo,nombreCargo)VALUES('" + o.idcargo + "','" + o.nombreCargo + "')");
                resp.mensaje = "Ok";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public ResponseExec Delete(Cargo o)
        {
            try
            {
                resp.error = !o.Data.execData("Delete from Cargo where idcargo = '" + o.idcargo + "')");
                resp.mensaje = "Ok";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Cargo> Get(Cargo o)
        {
            return convertToList(o.Data.queryData("Select*from Cargo"));
        }

        public Cargo GetById(Cargo o)
        {
            return convertToList(o.Data.queryData("Select*from Cargo where idcargo = '" + o.idcargo + "'")).FirstOrDefault();
        }

        public List<Cargo> GetQuery(Cargo o)
        {
            return convertToList(o.Data.queryData("Select*from Cargo where nombreCargo = '" + o.nombreCargo + "'"));
        }

        public ResponseExec Update(Cargo o)
        {
            try
            {
                resp.error = !o.Data.execData("Update Cargo SET nombreCargo = '" + o.nombreCargo + "' where idcargo = '" + o.idcargo + "'");
                resp.mensaje = "OK";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Cargo> convertToList(DataTable dt)
        {
            List<Cargo> listado = new List<Cargo>();

            foreach (DataRow item in dt.Rows)
            {
                Cargo o = new Cargo();
                o.idcargo = int.Parse(item.ItemArray[0].ToString());
                o.nombreCargo = item.ItemArray[1].ToString();
                listado.Add(o);
            }

            return listado;
        }
    }
}
