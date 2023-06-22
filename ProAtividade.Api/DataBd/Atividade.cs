using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProAtividade.Api.DataBd
{
    [Table("tb_Atividades")]
    public class Atividade
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Prioridade { get; set; }
        public string Descricao { get; set; }
    }
}
