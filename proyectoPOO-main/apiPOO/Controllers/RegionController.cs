using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelosCore.Mantenedores;
using NegocioCore.Mantenedores;
using System.Diagnostics.CodeAnalysis;

namespace apiPOO.Controllers
{
    
    [ApiController]
    public class RegionController : ControllerBase
    {
        Region region = new Region();
        RegionBL regionBL = new RegionBL();
        ErrorResponse error;
        [HttpPost]
        [Route("api/v1/Region/nuevo")]

        public ActionResult Create(RegionDTO o)
        {
           
            try
            {
                region.codigoRegion = o.codigoRegion;
                region.nombreRegion = o.nombreRegion;

                return Ok(regionBL.Create(region));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpGet]
        [Route("api/v1/Region/Listar")]

        public ActionResult Listar() 
        {
            try
            {
                return Ok(convertList(regionBL.Get(region))); 
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpGet]
        [Route("api/v1/Region/BuscarRegion")]
        public ActionResult BuscarRegion(int codigo)
        {
            try
            {
                region.codigoRegion = codigo;
                return Ok(convert(regionBL.GetById(region)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }


        [HttpGet]
        [Route("api/v1/Region/BuscarNombreRegion")]
        public ActionResult BuscarNombreRegion(string nombre)
        {
            try
            {
                region.nombreRegion = nombre;
                return Ok(convertList(regionBL.GetQuery(region)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpDelete]
        [Route("api/v1/Region/EliminarRegion")]

        public  ActionResult Eliminar(RegionDTO o)
        {
            try
            {
                region.codigoRegion = o.codigoRegion;
                return Ok(regionBL.Delete(region));
            }
            catch (Exception e)
            {


                error = new ErrorResponse(e);
                return StatusCode(500, error); 
            }
        }

        [HttpPut]
        [Route("api/v1/Region/Actualizar")]

        public ActionResult Actualizar(RegionDTO o)
        {
            try
            {
                region.codigoRegion = o.codigoRegion;
                region.nombreRegion = o.nombreRegion;

                return Ok(regionBL.Update(region));
            }
            catch (Exception e )
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error); ;
            }
        }

        private List<RegionDTO> convertList (List<Region> lista)
        {
            List<RegionDTO> list = new List<RegionDTO>();
            foreach (var item in lista)
            {
                RegionDTO rl = new RegionDTO(item.codigoRegion, item.nombreRegion);

                list.Add(rl);
            }
            return list;
        }

        private RegionDTO convert(Region item)
        {
            RegionDTO obj = new RegionDTO(item.codigoRegion, item.nombreRegion);
            return obj;

        }
    }
}
