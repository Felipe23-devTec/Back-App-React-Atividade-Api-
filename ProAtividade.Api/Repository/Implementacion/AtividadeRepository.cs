using AutoMapper;
using ProAtividade.Api.Data;
using ProAtividade.Api.DataBd;
using ProAtividade.Api.Repository.Interface;
using ProAtividade.Api.Services.Interfaces;

namespace ProAtividade.Api.Repository.Implementacion
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly AtividadeContext _context;
        public AtividadeRepository(AtividadeContext context)
        {

            _context = context;
        }

        public void CreateAtividade(Atividade atividade)
        {
            _context.Atividades.Add(atividade);
            _context.SaveChanges();
        }

        public void DeleteAtividade(int id)
        {
            var atividade = GetAtividadePorId(id);

            if(atividade != null)
            {
                   
                _context.Atividades.Remove(atividade);
                _context.SaveChanges();
            }
        }
        public Atividade? GetAtividadePorId(int id)
        {
            var filme = _context.Atividades.FirstOrDefault(x => x.Id == id);
            return filme;
        }
        public List<Atividade> GetAtividades()
        {
            return _context.Atividades.ToList();
        }

        public Atividade GetById(int id)
        {
            var filme = _context.Atividades.FirstOrDefault(a => a.Id == id);
            return filme;
        }

        public void UpdateAtividade(Atividade atividade)
        {
            var atividadeBd = _context.Atividades.FirstOrDefault(a => a.Id == atividade.Id);
            if (atividadeBd != null)
            {
                atividadeBd.Id = atividade.Id;
                atividadeBd.Titulo = atividade.Titulo;
                atividadeBd.Descricao = atividade.Descricao;
                atividadeBd.Prioridade = atividade.Prioridade;
                _context.SaveChanges();
            }
        }
    }
}
