using APIdeAtividades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIdeAtividades.Data.Map
{
    public class AtividadeMap : IEntityTypeConfiguration<AtividadeModel>
    {
        public void Configure(EntityTypeBuilder<AtividadeModel> builder)
        {
            builder.HasKey(x => x.IdAtividade);
            builder.Property(x => x.NomeAtividade).IsRequired().HasMaxLength(150);
            builder.Property(x => x.DescricaoAtividade).HasMaxLength(1000);
            builder.Property(x => x.StatusAtividade).IsRequired();
        }
    }
}
