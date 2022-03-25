namespace Unifica.Domain.Pessoas.View.Documentos.Pessoais
{
    public class PessoaEleitorView
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public int Numero { get; set; }
        public string Zona { get; set; }
        public string Secao { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
    }
}