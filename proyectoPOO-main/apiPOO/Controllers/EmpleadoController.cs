using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelosCore.Mantenedores;
using NegocioCore.Mantenedores;

namespace apiPOO.Controllers
{
  
    [ApiController]
    public class empleadoController : ControllerBase
    {
        Empleado empleado = new Empleado();
        EmpleadoBL empleadoBL = new EmpleadoBL();
        ErrorResponse error;
        [HttpPost]
        [Route("api/v1/Empleado/nuevo")]
        public ActionResult Create(EmpleadoDTO o)
        {
            try
            {
                empleado.codEmpleado = o.codEmpleado;
                empleado.Nombre = o.Nombre;
                empleado.Apellido = o.Apellido;
                empleado.jefe.codJefe = o.codJefe;
                empleado.cargo.idcargo = o.idcargo;
                return Ok(empleadoBL.Create(empleado));
            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);
                return StatusCode(500, error);
            }

        }

        [HttpGet]
        [Route("api/v1/Empleado/listar")]
        public ActionResult Listar()
        {
            try
            {               
                return Ok(convertList(empleadoBL.Get(empleado)));
            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);
                return StatusCode(500, error);
            }

        }
        [HttpGet]
        [Route("api/v1/Empleado/BuscarCodigoEmpleado")]
        public ActionResult BuscarCodigoEmpleado(int codigo)
        {
            try
            {   empleado.codEmpleado = codigo;
                return Ok(convert(empleadoBL.GetById(empleado)));
            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);
                return StatusCode(500, error);
            }

        }
        [HttpGet]
        [Route("api/v1/Empleado/buscarnombre")]
        public ActionResult BuscarNombre(string nombre)
        {
            try
            {
                empleado.Nombre = nombre;
                return Ok(convertList(empleadoBL.GetQuery(empleado)));
            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);
                return StatusCode(500, error);
            }

        }

        [HttpDelete]
        [Route("api/v1/Empleado/eliminar")]
        public ActionResult Eliminar(EmpleadoDTO o)
        {
            try
            {
                empleado.codEmpleado = o.codEmpleado;
                return Ok(empleadoBL.Delete(empleado));
            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);
                return StatusCode(500, error);
            }

        }

        [HttpPut]
        [Route("api/v1/Empleado/actualizar")]
        public ActionResult Actualizar(EmpleadoDTO o)
        {
            try
            {
                empleado.codEmpleado = o.codEmpleado;
                empleado.Nombre = o.Nombre;
                empleado.Apellido = o.Apellido;
                empleado.jefe.codJefe = o.codJefe;
                empleado.cargo.idcargo = o.idcargo;
                return Ok(empleadoBL.Update(empleado));
            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);
                return StatusCode(500, error);
            }

        }

        private List<EmpleadoDTO> convertList(List<Empleado> lista)
        {
            List<EmpleadoDTO> list = new List<EmpleadoDTO>();
            foreach (var item in lista)
            {
                EmpleadoDTO el = new EmpleadoDTO(item.codEmpleado, item.Nombre, item.Apellido,item.jefe.codJefe,item.cargo.idcargo);
                list.Add(el);

            }
            return list;

        }
        private EmpleadoDTO convert(Empleado item)
        {
            EmpleadoDTO obj = new EmpleadoDTO(item.codEmpleado, item.Nombre, item.Apellido, item.jefe.codJefe, item.cargo.idcargo);
            return obj;

        }
    }
}
