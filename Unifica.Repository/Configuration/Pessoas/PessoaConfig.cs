using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unifica.Domain.Pessoas.Entity;

namespace Unifica.Repository.Configuration.Pessoasion.Pessoas
{
    public class PessoaConfig : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("PESSOA");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Cpf);
            builder.Property(p => p.Email);
            builder.Property(p => p.DataNascimento);
            builder.Property(p => p.Senha);
            builder.Property(p => p.Login);
        }
    }
}