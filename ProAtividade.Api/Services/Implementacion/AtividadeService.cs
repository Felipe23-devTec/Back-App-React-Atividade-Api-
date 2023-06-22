using AutoMapper;
using ProAtividade.Api.Data.Dtos;
using ProAtividade.Api.DataBd;
using ProAtividade.Api.Repository.Interface;
using ProAtividade.Api.Services.Interfaces;

namespace ProAtividade.Api.Services.Implementacion
{
    public class AtividadeService : IAtividadeService
    {
        private readonly IAtividadeRepository _atividadeRepository;
        private readonly IMapper _mapper;
        public AtividadeService(IAtividadeRepository atividadeRepository, IMapper mapper)
        {
            _atividadeRepository = atividadeRepository;
            _mapper = mapper;
        }

        public void CreateAtividade(AtividadeDTO atividadeDTO)
        {
            Atividade atividade = _mapper.Map<Atividade>(atividadeDTO);
            _atividadeRepository.CreateAtividade(atividade);
        }

        public void DeleteAtividade(int id)
        {
            _atividadeRepository.DeleteAtividade(id);
        }

        public AtividadeDTO GetAtividadePorId(int id)
        {
            var atividadeBd = _atividadeRepository.GetById(id);
            AtividadeDTO atividadeDTO = _mapper.Map<AtividadeDTO>(atividadeBd);
            return atividadeDTO;
        }

        public List<AtividadeDTO> GetAtividades()
        {
            var atividadesBd = _atividadeRepository.GetAtividades();
            List<AtividadeDTO> atividadeDTO = _mapper.Map<List<AtividadeDTO>>(atividadesBd);
            return atividadeDTO;
        }

        public void UpdateAtividade(AtividadeDTO atividadeDTO)
        {
            Atividade atividade = _mapper.Map<Atividade>(atividadeDTO);
            _atividadeRepository.UpdateAtividade(atividade);
        }

    }
}
