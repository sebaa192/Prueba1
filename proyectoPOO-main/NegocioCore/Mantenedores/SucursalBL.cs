using ModelosCore;
using ModelosCore.Mantenedores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NegocioCore.Mantenedores
{
    public class SucursalBL : ICrud<Sucursal>
    {
        ResponseExec resp = new ResponseExec();
        public ResponseExec Create(Sucursal o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT INTO Sucursal (codigoSucursal,nombre,codigoRegion)VALUES('" + o.codigoSucursal + "','" + o.nombre + "','" + o.region.codigoRegion + "')");
                resp.mensaje = "Ok";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public ResponseExec Delete(Sucursal o)
        {
            try
            {
                resp.error = !o.Data.execData("Delete from Sucursal where codigoSucursal = '" + o.codigoSucursal + "'");
                resp.mensaje = "Ok";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Sucursal> Get(Sucursal o)
        {
            return convertToList(o.Data.queryData("SELECT Sucursal.codigoSucursal, Sucursal.nombre, Region.codigoRegion FROM  " +
                "          Region INNER JOIN Sucursal ON Region.codigoRegion = Sucursal.codigoRegion"));
        }


        
        public Sucursal GetById(Sucursal o)
        {
            return convertToList(o.Data.queryData("SELECT Sucursal.codigoSucursal, Sucursal.nombre, Region.codigoRegion FROM" +
                " Region INNER JOIN Sucursal ON Region.codigoRegion = Sucursal.codigoRegion where Sucursal.codigoSucursal = '" + o.codigoSucursal + "'")).FirstOrDefault();
        }

        public List<Sucursal> GetQuery(Sucursal o)
        {
            return convertToList(o.Data.queryData("SELECT Sucursal.codigoSucursal, Sucursal.nombre, Region.codigoRegion  FROM " +
                "Region INNER JOIN Sucursal ON Region.codigoRegion = Sucursal.codigoRegion where Sucursal.nombre = '" + o.nombre + "'"));
        }

        public ResponseExec Update(Sucursal o)
        {
            try
            {
                resp.error = !o.Data.execData("Update Sucursal SET nombre = '" + o.nombre + "',codigoRegion = '"+o.region.codigoRegion +"'  where codigoSucursal = '" + o.codigoSucursal + "'");
                resp.mensaje = "OK";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Sucursal> convertToList(DataTable dt)
        {
            List<Sucursal> listado = new List<Sucursal>();

            foreach (DataRow item in dt.Rows)
            {
                Sucursal o = new Sucursal();
                o.codigoSucursal = int.Parse(item.ItemArray[0].ToString());
                o.nombre = item.ItemArray[1].ToString();
                o.region.codigoRegion = int.Parse(item.ItemArray[2].ToString());
               // o.region.nombreRegion = item.ItemArray[3].ToString();
                listado.Add(o);
            }

            return listado;
        }
    }
}
