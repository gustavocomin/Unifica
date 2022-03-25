namespace Unifica.Domain.Pessoas.Entity.Documentos.Saude
{
    public class AlergiasDto
    {
        public Guid Id { get; set; }
        public Guid IdPessoaSus { get; set; }
        public string Nome { get; set; }
    }
}