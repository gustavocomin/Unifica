using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity.Documentos.Motorista;

namespace Unifica.Repository.Configuration.Pessoas.Documentos.Motorista
{
    public class OrgaoEmissorConfig : IEntityTypeConfiguration<OrgaoEmissor>
    {
        public void Configure(EntityTypeBuilder<OrgaoEmissor> builder)
        {
            builder.ToTable("ORGAOEMISSOR");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Uf);
            builder.Property(p => p.Nome);
        }
    }
}