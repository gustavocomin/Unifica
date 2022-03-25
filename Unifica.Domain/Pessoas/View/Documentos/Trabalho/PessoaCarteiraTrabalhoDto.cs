namespace Unifica.Domain.Pessoas.View.Documentos.Trabalho
{
    public class PessoaCarteiraTrabalhoView
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public DateTime DataEmissao { get; set; }

        public List<string> ContratosTrabalho { get; set; }
    }
}