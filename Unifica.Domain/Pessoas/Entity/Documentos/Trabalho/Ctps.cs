namespace Unifica.Domain.Pessoas.Entity.Documentos.Trabalho
{
    public class Ctps
    {
        public Guid Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public Guid IdPessoa { get; set; }

        public List<string> ContratosTrabalho { get; set; }
    }
}