using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Filiacoes;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Filiacoes
{
    public class FiliacaoConfig : IEntityTypeConfiguration<Filiacao>
    {
        public void Configure(EntityTypeBuilder<Filiacao> builder)
        {
            builder.ToTable("FILIACAO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.IdRg);
            builder.Property(p => p.Nome);
            builder.Property(p => p.Cpf);
            builder.Property(p => p.DataNascimento);
        }
    }
}