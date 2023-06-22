using ProAtividade.Api.DataBd;

namespace ProAtividade.Api.Repository.Interface
{
    public interface IAtividadeRepository
    {
        public List<Atividade> GetAtividades();
        public void CreateAtividade(Atividade atividade);
        public Atividade GetById(int id);
        public void UpdateAtividade(Atividade atividade);
        public void DeleteAtividade(int id);
        public Atividade? GetAtividadePorId(int id);
    }
}
