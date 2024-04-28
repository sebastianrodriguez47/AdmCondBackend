using AdmCondominioBack.Data.Models;
using AdmCondominioBack.Repositories.Implementations.AdmCondominioBack.Data.Models;
using AdmCondominioBack.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdmCondominioBack.Controllers
{
    [ApiController]
    [Route("api/jefeHogar")]
    public class JefeHogarController : ControllerBase
    {
        private IJefeHogarRepository _jefeHogarRepository;
        public JefeHogarController(IJefeHogarRepository jefeHogarRepository)
        {
            _jefeHogarRepository = jefeHogarRepository;
        }
        [HttpGet]
        [Route("listar")]
        public IActionResult listarJefesHogar()
        {
            var a = _jefeHogarRepository.GetAllJefeHogar();

            if (a == null)
            {
                return NotFound();
            }
            return Ok(a);
        }
        [HttpGet]
        [Route("listar/{id}")]
        public IActionResult listarJefesHogarByNumeroCasa(int id)
        {
            IList<JefeHogarDTO> jefesHogar = _jefeHogarRepository.GetJefeHogarByIdCasa(id);
            if (jefesHogar == null)
            {
                return NotFound();
            }
            return Ok(jefesHogar);
        }


    }
}
