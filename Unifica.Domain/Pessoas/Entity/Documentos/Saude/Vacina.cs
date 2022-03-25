namespace Unifica.Domain.Pessoas.Entity.Documentos.Saude
{
    public class Vacina
    {
        public Guid Id { get; set; }
        public Guid IdPessoaSus { get; set; }
        public string Nome { get; set; }
        public DateTime DataAplicacao { get; set; }
        public string Fabricante { get; set; }
        public string Lote { get; set; }
        public string Estabelecimento { get; set; }
        public string Aplicador { get; set; }
    }
}