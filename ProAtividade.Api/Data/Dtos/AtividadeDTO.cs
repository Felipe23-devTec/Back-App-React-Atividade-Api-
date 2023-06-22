using System.ComponentModel.DataAnnotations;

namespace ProAtividade.Api.Data.Dtos
{
    public class AtividadeDTO
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Prioridade { get; set; }
        public string Descricao { get; set; }
    }
}
