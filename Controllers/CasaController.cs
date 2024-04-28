using AdmCondominioBack.Data.Models;
using AdmCondominioBack.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdmCondominioBack.Controllers
{
    [ApiController]
    [Route("api/casa")]
    public class CasaController : ControllerBase
    {
        private ICasaRepository _casaRepository;
        public CasaController(ICasaRepository casaRepository)
        {
            _casaRepository = casaRepository;
        }
        [HttpGet]
        [Route("listar")]
        public IActionResult listarCasas()
        {
            var a =  _casaRepository.GetAllCasas();
            
            if(a == null)
            {
                return NotFound();
            }
            return Ok(a);
        }
        [HttpGet]
        [Route("listar/{id}")]
        public IActionResult listarCasaById(int id)
        {
            CasaDTO c = _casaRepository.GetCasaById(id);
            if(c == null)
            {
                return NotFound();
            }
            return Ok(c);
        }


    }
}
