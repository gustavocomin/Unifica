using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Informacoes;

namespace Unifica.Repository.Configuration.Pessoas.Informacoes
{
    public class InfosPessoaisConfig : IEntityTypeConfiguration<InfosPessoais>
    {
        public void Configure(EntityTypeBuilder<InfosPessoais> builder)
        {
            builder.ToTable("PESSOA_INFOSPESSOAIS");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Pronomes);
            builder.Property(p => p.Genero);
            builder.Property(p => p.OrientacaoSexual);
            builder.Property(p => p.Raca);
            builder.Property(p => p.NomeSocial);
            builder.Property(p => p.IdPessoa);
        }
    }
}