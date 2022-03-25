namespace Unifica.Domain.Pessoas.Dto.Documentos.Filiacao
{
    public class PessoaFiliacaoDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}