using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelosCore.Mantenedores;
using NegocioCore.Mantenedores;

namespace apiPOO.Controllers
{

    [ApiController]
    public class JefeController : ControllerBase
    {
        Jefe jefe = new Jefe();
        JefeBL jefeBL = new JefeBL();
        ErrorResponse error;

        [HttpPost]
        [Route("api/v1/Jefe/nuevo")]

        public ActionResult Create(JefeDTO o)
        {
            try
            {
                jefe.codJefe = o.codJefe;
                jefe.nombre = o.nombre;

                return Ok(jefeBL.Create(jefe));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }

        }

        [HttpGet]
        [Route("api/v1/Jefe/Listar")]

        public ActionResult Listar()
        {
            try
            {
               return Ok(convertList(jefeBL.Get(jefe)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }

        }

        [HttpGet]
        [Route("api/v1/Jefe/BuscarJefe")]
        public ActionResult BuscarJefe(int codigo)
        {
            try
            {
                jefe.codJefe = codigo;
                return Ok(convert(jefeBL.GetById(jefe)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpGet]
        [Route("api/v1/Jefe/BuscarNombreJefe")]
        public ActionResult BuscarNombreJefe(string nombre)
        {
            try
            {
                jefe.nombre = nombre;
                return Ok(convertList(jefeBL.GetQuery(jefe)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpDelete]
        [Route("api/v1/Jefe/EliminarJefe")]

        public ActionResult Eliminar(JefeDTO o)
        {
            try
            {
                jefe.codJefe = o.codJefe;
                return Ok(jefeBL.Delete(jefe));
            }
            catch (Exception e)
            {


                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpPut]
        [Route("api/v1/Jefe/Actualizar")]

        public ActionResult Actualizar(JefeDTO o)
        {
            try
            {
                jefe.codJefe = o.codJefe;
                jefe.nombre = o.nombre;

                return Ok(jefeBL.Update(jefe));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error); ;
            }
        }

        private List<JefeDTO> convertList(List<Jefe> lista)
        {
            List<JefeDTO> list = new List<JefeDTO>();
            foreach (var item in lista)
            {
                JefeDTO jl = new JefeDTO(item.codJefe, item.nombre);

                list.Add(jl);
            }
            return list;
        }

        private JefeDTO convert(Jefe item)
        {
            JefeDTO obj = new JefeDTO(item.codJefe, item.nombre);
            return obj;

        }


    }
}
