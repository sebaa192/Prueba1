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
    public class RegionBL : ICrud<Region>
    {
        ResponseExec resp = new ResponseExec();
        public ResponseExec Create(Region o)
        {
            try
            {

                resp.error = !o.Data.execData("INSERT  INTO Region(codigoRegion, nombreRegion) VALUES('" + o.codigoRegion+ "','"+o.nombreRegion+"')");
                resp.mensaje = "OK";

            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public ResponseExec Delete(Region o)
        {
            try
            {
                resp.error = !o.Data.execData("Delete from Region where codigoRegion ='"+o.codigoRegion+"'");
                resp.mensaje = "OK";
            }
            catch (Exception e )
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Region> Get(Region o)
        {
            return convertToList(o.Data.queryData("select*from Region"));
        }

        public Region GetById(Region o)
        {
            return convertToList(o.Data.queryData("Select*from Region where codigoRegion = '" + o.codigoRegion + "'")).FirstOrDefault();
        }

        public List<Region> GetQuery(Region o)
        {
            return convertToList(o.Data.queryData("Select*from Region where nombreRegion = '" + o.nombreRegion + "'"));
        }

        public ResponseExec Update(Region o)
        {
            try
            {
                resp.error = !o.Data.execData("Update Region SET nombreRegion = '"+o.nombreRegion+"' where codigoRegion = '"+o.codigoRegion+"'");
                resp.mensaje = "OK";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje=e.Message;
            }
            return resp;
        }

        public List<Region> convertToList(DataTable dt)
        {
            List<Region> listado = new List<Region>();

            foreach (DataRow item in dt.Rows)
            {
                Region o = new Region();
                o.codigoRegion = int.Parse(item.ItemArray[0].ToString());
                o.nombreRegion = item.ItemArray[1].ToString();
                listado.Add(o);
            }

            return listado; 
        }
    }
}
