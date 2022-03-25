using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Pessoais;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Pessoais
{
    public class TituloConfig : IEntityTypeConfiguration<Titulo>
    {
        public void Configure(EntityTypeBuilder<Titulo> builder)
        {
            builder.ToTable("PESSOA_TITULO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Numero);
            builder.Property(p => p.Secao);
            builder.Property(p => p.Municipio);
            builder.Property(p => p.IdPessoa);
            builder.Property(p => p.Zona);
            builder.Property(p => p.Uf);
        }
    }
}