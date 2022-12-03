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
    public class EmpleadoBL : ICrud<Empleado>
    {
        ResponseExec resp = new ResponseExec();
       
        public ResponseExec Create(Empleado o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT  INTO Empleado(codEmpleado, Nombre, Apellido, codJefe,idcargo) VALUES('" + o.codEmpleado+"','"+o.Nombre+ "','" + o.Apellido + "','" + o.jefe.codJefe + "','"+o.cargo.idcargo+"')");
                resp.mensaje = "OK";
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
                
            }
            return resp;

        }

        public ResponseExec Delete(Empleado o)
        {
            try
            {
                resp.error = !o.Data.execData("DELETE FROM Empleado WHERE codEmpleado='" + o.codEmpleado + "'");
                resp.mensaje = "ok";
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;

            }
            return resp;
        }

        public List<Empleado> Get(Empleado o)
        {
            return convertToList(o.Data.queryData("SELECT Empleado.codEmpleado, Empleado.Nombre, Empleado.Apellido, Jefe.codJefe, Cargo.idcargo FROM            Cargo INNER JOIN Empleado ON Cargo.idcargo = Empleado.idcargo INNER JOIN Jefe ON Empleado.codJefe = Jefe.codJefe"));

        }

        public Empleado GetById(Empleado o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Empleado WHERE codEmpleado='"+o.codEmpleado+"'")).FirstOrDefault();
           
        }

        public List<Empleado> GetQuery(Empleado o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Empleado WHERE Nombre='" + o.Nombre+"'"));
        }

        public ResponseExec Update(Empleado o)
        {
            try
            {
                resp.error = !o.Data.execData("UPDATE Empleado SET Nombre='" + o.Nombre + "', Apellido='" + o.Apellido + "', codJefe='" + o.jefe.codJefe + "', idcargo = '"+o.cargo.idcargo+"' WHERE codEmpleado ='" + o.codEmpleado + "'");
                resp.mensaje = "ok";
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;

            }
            return resp;
        }

        public List<Empleado> convertToList(DataTable dt)
        {
            List<Empleado> listado = new List<Empleado>();

            foreach (DataRow item in dt.Rows)
            {
                Empleado o = new Empleado();
                o.codEmpleado = int.Parse(item.ItemArray[0].ToString());
                o.Nombre = item.ItemArray[1].ToString();
                o.Apellido = item.ItemArray[2].ToString();
                o.jefe.codJefe = int.Parse(item.ItemArray[3].ToString());
                o.cargo.idcargo = int.Parse(item.ItemArray[4].ToString());

                listado.Add(o);
            }

            return listado;
        }

      
    }
}
