using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Saude;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Saude
{
    public class SusConfig : IEntityTypeConfiguration<Sus>
    {
        public void Configure(EntityTypeBuilder<Sus> builder)
        {
            builder.ToTable("PESSOA_SUS");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Cns);
            builder.Property(p => p.Doador);
            builder.Property(p => p.TipoSanguineo);
            builder.Property(p => p.IdPessoa);

            builder.HasMany(p => p.Alergia)
                   .WithOne()
                   .HasForeignKey(p => p.IdPessoaSus);

            builder.HasMany(p => p.Vacina)
                   .WithOne()
                   .HasForeignKey(p => p.IdPessoaSus);
        }
    }
}