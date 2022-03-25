namespace Unifica.Domain.Pessoas.Entity.Documentos.Filiacoes
{
    public class Filiacao
    {
        public Guid Id { get; set; }
        public Guid IdRg{ get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}