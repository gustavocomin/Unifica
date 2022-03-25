using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Motorista;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Motorista
{
    public class CnhConfig : IEntityTypeConfiguration<Cnh>
    {
        public void Configure(EntityTypeBuilder<Cnh> builder)
        {
            builder.ToTable("PESSOA_CNH");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.IdPessoa);
            builder.Property(p => p.NumeroRegistro);
            builder.Property(p => p.DataPrimeiraHabilitacao);
            builder.Property(p => p.Categoria);
            builder.Property(p => p.CodigoSeguranca);
            builder.Property(p => p.Emissao);
            builder.Property(p => p.IdOrgaoEmissor);

            builder.HasOne(p => p.OrgaoEmissor)
                   .WithMany()
                   .HasForeignKey(p => p.IdOrgaoEmissor);
        }
    }
}