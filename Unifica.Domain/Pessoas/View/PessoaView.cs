namespace Unifica.Domain.Pessoas.View
{
    public class PessoaView
    {
        public Guid? Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}