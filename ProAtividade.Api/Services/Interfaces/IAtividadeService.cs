using ProAtividade.Api.Data.Dtos;
using ProAtividade.Api.DataBd;

namespace ProAtividade.Api.Services.Interfaces
{
    public interface IAtividadeService
    {
        public List<AtividadeDTO> GetAtividades();
        public AtividadeDTO? CreateAtividade(AtividadeDTO atividadeDTO);
        public AtividadeDTO GetAtividadePorId(int id);
        public AtividadeDTO UpdateAtividade(AtividadeDTO atividadeDTO);
        public void DeleteAtividade(int id);
    }
}
