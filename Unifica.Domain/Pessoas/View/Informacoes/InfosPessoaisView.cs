using Unifica.Domain.Pessoas.Entity.Informacoes;

namespace Unifica.Domain.Pessoas.View.Informacoes
{
    public class InfosPessoaisView
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public string NomeSocial { get; set; }
        public Raca? Raca { get; set; }
        public OrientacaoSexual? OrientacaoSexual { get; set; }
        public Genero? Genero { get; set; }
        public Pronomes? Pronomes { get; set; }
    }
}