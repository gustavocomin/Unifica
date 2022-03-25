namespace Unifica.Domain.Pessoas.Entity.Documentos.Trabalho
{
    public class PessoaCarteiraTrabalho
    {
        public Guid Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public Guid IdPessoa { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public List<string> ContratosTrabalho { get; set; }
    }
}