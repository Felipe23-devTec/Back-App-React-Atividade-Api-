using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ProAtividade.Api.DataBd;
using System.IO;

namespace ProAtividade.Api.Data
{
    public class AtividadeContext : DbContext
    {
        public AtividadeContext(DbContextOptions<AtividadeContext> opts) : base(opts)
        {

        }
        public DbSet<Atividade> Atividades { get; set; }
    }
}
