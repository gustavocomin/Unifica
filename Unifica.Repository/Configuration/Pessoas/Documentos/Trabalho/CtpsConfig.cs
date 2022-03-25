using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Trabalho;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Trabalho
{
    public class CtpsConfig : IEntityTypeConfiguration<Ctps>
    {
        public void Configure(EntityTypeBuilder<Ctps> builder)
        {
            builder.ToTable("PESSOA_CTPS");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.IdPessoa);
            builder.Property(p => p.ContratosTrabalho);
            builder.Property(p => p.DataEmissao);
        }
    }
}