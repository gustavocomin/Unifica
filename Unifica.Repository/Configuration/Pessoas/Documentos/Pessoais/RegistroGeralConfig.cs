using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Pessoais;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Pessoais
{
    public class RegistroGeralConfig : IEntityTypeConfiguration<RegistroGeral>
    {
        public void Configure(EntityTypeBuilder<RegistroGeral> builder)
        {
            builder.ToTable("PESSOA_RG");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.IdPessoa);
            builder.Property(p => p.EstadoNaturalidade);
            builder.Property(p => p.CidadeNaturalidade);
            builder.Property(p => p.DocOrigem);
            builder.Property(p => p.Rg);
            builder.Property(p => p.OrgaoEmissor);

            builder.HasMany(p => p.Filiacao)
                   .WithOne()
                   .HasForeignKey(p => p.IdRg);
        }
    }
}