using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Saude;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Saude
{
    public class AlergiaConfig : IEntityTypeConfiguration<Alergia>
    {
        public void Configure(EntityTypeBuilder<Alergia> builder)
        {
            builder.ToTable("ALERGIA");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.IdPessoaSus);
            builder.Property(p => p.Nome);
        }
    }
}