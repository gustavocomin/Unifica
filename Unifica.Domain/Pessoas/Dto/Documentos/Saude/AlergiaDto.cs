namespace Unifica.Domain.Pessoas.Dto.Documentos.Saude
{
    public class AlergiaDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoaSus { get; set; }
        public string Nome { get; set; }
    }
}