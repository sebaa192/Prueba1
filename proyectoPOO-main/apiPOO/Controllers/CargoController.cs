using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelosCore.Mantenedores;
using NegocioCore.Mantenedores;

namespace apiPOO.Controllers
{
    
    [ApiController]
    public class CargoController : ControllerBase
    {
        Cargo cargo = new Cargo();
        CargoBL cargoBL = new CargoBL();
        ErrorResponse error;

        [HttpPost]
        [Route("api/v1/Cargo/nuevo")]

        public ActionResult Create(CargoDTO o)
        {
            try
            {
                cargo.idcargo = o.idcargo;
                cargo.nombreCargo = o.nombrecargo;

                return Ok(cargoBL.Create(cargo));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }

        }

        [HttpGet]
        [Route("api/v1/Cargo/Listar")]

        public ActionResult Listar()
        {
            try
            {
                return Ok(convertList(cargoBL.Get(cargo)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }

        }

        [HttpGet]
        [Route("api/v1/Cargo/BuscarCargo")]
        public ActionResult BuscarCargo(int codigo)
        {
            try
            {
                cargo.idcargo = codigo;
                return Ok(convert(cargoBL.GetById(cargo)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpGet]
        [Route("api/v1/Cargo/BuscarNombreCargo")]
        public ActionResult BuscarNombreJefe(string nombre)
        {
            try
            {
                cargo.nombreCargo = nombre;
                return Ok(convertList(cargoBL.GetQuery(cargo)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpDelete]
        [Route("api/v1/Cargo/EliminarCargo")]

        public ActionResult Eliminar(CargoDTO o)
        {
            try
            {
                cargo.idcargo = o.idcargo;
                return Ok(cargoBL.Delete(cargo));
            }
            catch (Exception e)
            {


                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpPut]
        [Route("api/v1/Cargo/Actualizar")]

        public ActionResult Actualizar(CargoDTO o)
        {
            try
            {
                cargo.idcargo = o.idcargo;
                cargo.nombreCargo = o.nombrecargo;

                return Ok(cargoBL.Update(cargo));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error); ;
            }
        }

        private List<CargoDTO> convertList(List<Cargo> lista)
        {
            List<CargoDTO> list = new List<CargoDTO>();
            foreach (var item in lista)
            {
                CargoDTO jl = new CargoDTO(item.idcargo, item.nombreCargo);

                list.Add(jl);
            }
            return list;
        }

        private CargoDTO convert(Cargo item)
        {
            CargoDTO obj = new CargoDTO(item.idcargo, item.nombreCargo);
            return obj;

        }
    }
}
