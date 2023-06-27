using Microsoft.AspNetCore.Mvc;
using ProAtividade.Api.Data.Dtos;
using ProAtividade.Api.Services.Interfaces;

namespace ProAtividade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        private readonly IAtividadeService _atividadeService;
        public AtividadeController(IAtividadeService atividadeService)
        {
            _atividadeService = atividadeService;
        }
        [HttpGet]
        public List<AtividadeDTO> GetAtividades()
        {
            return _atividadeService.GetAtividades();
        }
        [HttpPost]
        public AtividadeDTO? CreateAtividade([FromBody]AtividadeDTO atividadeDTO)
        {
            var at = _atividadeService.CreateAtividade(atividadeDTO);
            return at;
        }
        [HttpGet("{id}")]
        public IActionResult GetAtividadePorID(int id)
        {
            var atividade = _atividadeService.GetAtividadePorId(id);
            if(atividade == null) return NotFound();
            return Ok(atividade);
        }

        

        [HttpPut("{id}")]
        public AtividadeDTO? UpdateAtividade(int id, [FromBody] AtividadeDTO atividadeDTO)
        {
            atividadeDTO.Id = id;
            var atividade =_atividadeService.UpdateAtividade(atividadeDTO); 
            return atividade;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _atividadeService.DeleteAtividade(id);
            return NoContent();

        }

    }
}
