using APIdeAtividades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIdeAtividades.Data.Map
{
    public class AtividadeMap : IEntityTypeConfiguration<ProfessorModel>
    {
        public void Configure(EntityTypeBuilder<ProfessorModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Materia).IsRequired().HasMaxLength(50);
        }
    }
}
