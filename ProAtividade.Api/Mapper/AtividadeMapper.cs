using AutoMapper;
using ProAtividade.Api.Data.Dtos;
using ProAtividade.Api.DataBd;

namespace ProAtividade.Api.Mapper
{
    public class AtividadeMapper : Profile
    {
        public AtividadeMapper()
        {
            CreateMap<AtividadeDTO, Atividade>()
            .ReverseMap();
        }
    }
}
