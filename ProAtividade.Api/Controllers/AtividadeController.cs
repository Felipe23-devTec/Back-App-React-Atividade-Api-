using Microsoft.AspNetCore.Mvc;

namespace ProAtividade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        [HttpGet]
        public string get()
        {
            return "texte";
        }
        [HttpGet("{id}")]
        public string get(int id)
        {
            return $"texte {id}";
        }

        [HttpPost]
        public string Post()
        {
            return "texte post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "texte put";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "texte delete";
        }



    }
}
