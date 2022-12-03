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
    public class JefeBL : ICrud<Jefe>
    {
        ResponseExec resp = new ResponseExec();
        public ResponseExec Create(Jefe o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT INTO Jefe (codJefe,nombre)VALUES('"+o.codJefe+"','"+o.nombre+"')");
                resp.mensaje = "Ok";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public ResponseExec Delete(Jefe o)
        {
            try
            {
                resp.error = !o.Data.execData("Delete from Jefe where codJefe = '" + o.codJefe + "')");
                resp.mensaje = "Ok";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Jefe> Get(Jefe o)
        {
            return convertToList(o.Data.queryData("Select*from Jefe"));
        }

        public Jefe GetById(Jefe o)
        {
            return convertToList(o.Data.queryData("Select*from Jefe where codJefe = '"+o.codJefe+"'")).FirstOrDefault();
        }

        public List<Jefe> GetQuery(Jefe o)
        {
            return convertToList(o.Data.queryData("Select*from Jefe where nombre = '" + o.nombre + "'"));
        }

        public ResponseExec Update(Jefe o)
        {
            try
            {
                resp.error = !o.Data.execData("Update Jefe SET nombre = '" + o.nombre + "' where codJefe = '" + o.codJefe + "'");
                resp.mensaje = "OK";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Jefe> convertToList(DataTable dt)
        {
            List<Jefe> listado = new List<Jefe>();

            foreach (DataRow item in dt.Rows)
            {
                Jefe o = new Jefe();
                o.codJefe = int.Parse(item.ItemArray[0].ToString());
                o.nombre = item.ItemArray[1].ToString();
                listado.Add(o);
            }

            return listado;
        }
    }
}
