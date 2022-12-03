using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelosCore.Mantenedores;
using NegocioCore.Mantenedores;

namespace apiPOO.Controllers
{

    [ApiController]
    public class SucursalController : ControllerBase
    {

        Sucursal sucursal = new Sucursal();
        SucursalBL sucursalBL = new SucursalBL();
        ErrorResponse error;

        [HttpPost]
        [Route("api/v1/Sucursal/nuevo")]

        public ActionResult Create(SucursalDTO o)
        {
            try
            {
                sucursal.codigoSucursal = o.codigoSucursal;
                sucursal.nombre = o.nombre;
                sucursal.region.codigoRegion = o.codigoRegion;

                return Ok(sucursalBL.Create(sucursal));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }

        }


        [HttpGet]
        [Route("api/v1/Sucursal/Listar")]

        public ActionResult Listar()
        {
            try
            {
                return Ok(convertList(sucursalBL.Get(sucursal)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }

        }


        [HttpGet]
        [Route("api/v1/Sucursal/BuscarSucursal")]
        public ActionResult BuscarJefe(int codigo)
        {
            try
            {
                sucursal.codigoSucursal = codigo;
                return Ok(convert(sucursalBL.GetById(sucursal)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }


        [HttpGet]
        [Route("api/v1/Sucursal/BuscarNombreSucursal")]
        public ActionResult BuscarNombreSucursal(string nombre)
        {
            try
            {
                sucursal.nombre = nombre;
                return Ok(convertList(sucursalBL.GetQuery(sucursal)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }


        [HttpDelete]
        [Route("api/v1/Sucursal/EliminarSucursal")]

        public ActionResult Eliminar(SucursalDTO o)
        {
            try
            {
                sucursal.codigoSucursal = o.codigoSucursal;
                return Ok(sucursalBL.Delete(sucursal));
            }
            catch (Exception e)
            {


                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }


        [HttpPut]
        [Route("api/v1/Sucursal/Actualizar")]

        public ActionResult Actualizar(SucursalDTO o)
        {
            try
            {
                sucursal.codigoSucursal = o.codigoSucursal;
                sucursal.nombre = o.nombre;
                sucursal.region.codigoRegion = o.codigoRegion;
                

                return Ok(sucursalBL.Update(sucursal));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error); ;
            }
        }

        private List<SucursalDTO> convertList(List<Sucursal> lista)
        {
            List<SucursalDTO> list = new List<SucursalDTO>();
            foreach (var item in lista)
            {
                //  JefeDTO j = new JefeDTO(item.jefe.codJefe, item.jefe.nombre);
                SucursalDTO sl = new SucursalDTO(item.codigoSucursal, item.nombre, item.region.codigoRegion);

                list.Add(sl);
            }
            return list;
        }

        private SucursalDTO convert(Sucursal item)
        {
            // JefeDTO j = new JefeDTO(item.jefe.codJefe, item.jefe.nombre);
            SucursalDTO obj = new SucursalDTO(item.codigoSucursal, item.nombre, item.region.codigoRegion);
            return obj;

        }
    }
}