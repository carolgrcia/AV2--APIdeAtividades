using APIdeAtividades.Models;
using Microsoft.EntityFrameworkCore;

namespace APIdeAtividades.Data
{
    public class APIdeAtividadesDBContext : DbContext
    {
        public APIdeAtividadesDBContext(DbContextOptions<APIdeAtividadesDBContext> options)
            :base(options)
        {
        }
        public DbSet<ProfessorModel> Professores { get; set; }
        public DbSet<AtividadeModel> Atividades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new AtividadeMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
