using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelosCore.Mantenedores;
using NegocioCore.Mantenedores;
using System.Runtime.InteropServices;

namespace apiPOO.Controllers
{

    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        Departamento departamento = new Departamento();
        DepartamentoBL departamentoBL = new DepartamentoBL();
        ErrorResponse error;

        [HttpPost]
        [Route("api/v1/Departamento/nuevo")]

        public ActionResult Create(DepartamentoDTO o)
        {
            try
            {
                departamento.codigodepa = o.codigodepa;
                departamento.nombredepa = o.nombredepa;
                departamento.jefe.codJefe = o.codJefe;
                departamento.sucursal.codigoSucursal = o.codigoSucursal;
                
                return Ok(departamentoBL.Create(departamento));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }

        }

        [HttpGet]
        [Route("api/v1/Departamento/Listar")]

        public ActionResult Listar()
        {
            try
            {
                return Ok(convertList(departamentoBL.Get(departamento)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }

        }


        [HttpGet]
        [Route("api/v1/Departamento/BuscarDepartamento")]
        public ActionResult BuscarJefe(int codigo)
        {
            try
            {
                departamento.codigodepa = codigo;
                return Ok(convert(departamentoBL.GetById(departamento)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }


        [HttpGet]
        [Route("api/v1/Departamento/BuscarNombreDepartamento")]
        public ActionResult BuscarNombreJefe(string nombre)
        {
            try
            {
                departamento.nombredepa = nombre;
                return Ok(convertList(departamentoBL.GetQuery(departamento)));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }


        [HttpDelete]
        [Route("api/v1/Departamento/EliminarDepartamento")]

        public ActionResult Eliminar(DepartamentoDTO o)
        {
            try
            {
                departamento.codigodepa = o.codigodepa;
                return Ok(departamentoBL.Delete(departamento));
            }
            catch (Exception e)
            {


                error = new ErrorResponse(e);
                return StatusCode(500, error);
            }
        }

        [HttpPut]
        [Route("api/v1/Departamento/Actualizar")]

        public ActionResult Actualizar(DepartamentoDTO o)
        {
            try
            {
                departamento.codigodepa = o.codigodepa;
                departamento.nombredepa = o.nombredepa;
                departamento.jefe.codJefe = o.codJefe;
                departamento.sucursal.codigoSucursal = o.codigoSucursal;

                return Ok(departamentoBL.Update(departamento));
            }
            catch (Exception e)
            {

                error = new ErrorResponse(e);
                return StatusCode(500, error); ;
            }
        }

        private List<DepartamentoDTO> convertList(List<Departamento> lista)
        {
            List<DepartamentoDTO> list = new List<DepartamentoDTO>();
            foreach (var item in lista)
            {
              //  JefeDTO j = new JefeDTO(item.jefe.codJefe, item.jefe.nombre);
                DepartamentoDTO dl = new DepartamentoDTO(item.codigodepa, item.nombredepa,item.jefe.codJefe,item.sucursal.codigoSucursal);

                list.Add(dl);
            }
            return list;
        }

        private DepartamentoDTO convert(Departamento item)
        {
           // JefeDTO j = new JefeDTO(item.jefe.codJefe, item.jefe.nombre);
            DepartamentoDTO obj = new DepartamentoDTO(item.codigodepa, item.nombredepa, item.jefe.codJefe,item.sucursal.codigoSucursal);
            return obj;

        }
       
    }  
}
