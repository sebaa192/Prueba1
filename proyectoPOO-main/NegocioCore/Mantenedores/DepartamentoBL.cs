using DataCore;
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
    
    public class DepartamentoBL : ICrud<Departamento>
    {
        ResponseExec resp = new ResponseExec();
        public ResponseExec Create(Departamento o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT INTO Departamento (codigodepa,nombredepa,codJefe,codigoSucursal)VALUES('" + o.codigodepa + "','" + o.nombredepa + "','"+o.jefe.codJefe+"','"+o.sucursal.codigoSucursal+"'");
                resp.mensaje = "Ok";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public ResponseExec Delete(Departamento o)
        {
            try
            {
                resp.error = !o.Data.execData("Delete from Departamento where codigodepa = '" + o.codigodepa + "'");
                resp.mensaje = "Ok";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Departamento> Get(Departamento o)
        {
            return convertToList(o.Data.queryData("SELECT Departamento.codigodepa, Departamento.nombredepa, Jefe.codJefe, Sucursal.codigoSucursal FROM Departamento INNER JOIN Jefe ON Departamento.codJefe = Jefe.codJefe INNER JOIN Sucursal ON Departamento.codigoSucursal=sucursal.codigoSucursal"));
        }

        //"SELECT Departamento.codigodepa, Departamento.nombredepa, Jefe.codJefe, Jefe.nombre FROM" +
        //        "            Departamento INNER JOIN Jefe ON Departamento.codJefe = Jefe.codJefe"


        
        public Departamento GetById(Departamento o)
        {
            return convertToList(o.Data.queryData("Select*from Departamento where codigodepa = '" + o.codigodepa + "'")).FirstOrDefault();

        }

        public List<Departamento> GetQuery(Departamento o)
        {
            return convertToList(o.Data.queryData("Select*from Departamento where nombredepa = '" + o.nombredepa + "'"));

        }

        public ResponseExec Update(Departamento o)
        {
            try
            {
                resp.error = !o.Data.execData("Update Departamento SET nombredepa = '" + o.nombredepa + "', codJefe ='" + o.jefe.codJefe + "', codigoSucursal ='" + o.sucursal.codigoSucursal + "' where codigodepa = '" + o.codigodepa + "'");
                resp.mensaje = "OK";
            }
            catch (Exception e)
            {

                resp.error = true;
                resp.mensaje = e.Message;
            }
            return resp;
        }

        public List<Departamento> convertToList(DataTable dt)
        {
            List<Departamento> listado = new List<Departamento>();

            foreach (DataRow item in dt.Rows)
            {
                Departamento o = new Departamento();
                o.codigodepa = int.Parse(item.ItemArray[0].ToString());
                o.nombredepa = item.ItemArray[1].ToString();
                o.jefe.codJefe = int.Parse(item.ItemArray[2].ToString());
               // o.jefe.nombre = item.ItemArray[3].ToString();
                o.sucursal.codigoSucursal = int.Parse(item.ItemArray[3].ToString());
                //o.sucursal.nombre = item.ItemArray[5].ToString();
                listado.Add(o);
            }

            return listado;
        }
    }
}
