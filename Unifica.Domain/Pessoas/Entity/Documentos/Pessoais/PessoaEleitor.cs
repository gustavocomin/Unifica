namespace Unifica.Domain.Pessoas.Entity.Documentos.Pessoais
{
    public class PessoaEleitorDto
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public string Zona { get; set; }
        public string Secao { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public Guid IdPessoa { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}