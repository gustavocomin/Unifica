namespace Unifica.Domain.Pessoas.View.Documentos.Saude
{
    public class AlergiaView
    {
        public Guid? Id { get; set; }
        public Guid IdPessoaSus { get; set; }
        public string Nome { get; set; }
    }
}