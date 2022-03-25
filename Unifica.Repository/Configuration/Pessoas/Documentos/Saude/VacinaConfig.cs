using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Saude;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Saude
{
    public class VacinaConfig : IEntityTypeConfiguration<Vacina>
    {
        public void Configure(EntityTypeBuilder<Vacina> builder)
        {
            builder.ToTable("VACINA");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Fabricante);
            builder.Property(p => p.Estabelecimento);
            builder.Property(p => p.Lote);
            builder.Property(p => p.Aplicador);
            builder.Property(p => p.DataAplicacao);
            builder.Property(p => p.Nome);
            builder.Property(p => p.IdPessoaSus);
        }
    }
}