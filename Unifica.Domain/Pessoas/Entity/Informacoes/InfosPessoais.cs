using System.ComponentModel;

namespace Unifica.Domain.Pessoas.Entity.Informacoes
{
    public class InfosPessoais
    {
        public Guid Id { get; set; }
        public Guid IdPessoa { get; set; }
        public string NomeSocial { get; set; }
        public Raca? Raca { get; set; }
        public OrientacaoSexual? OrientacaoSexual { get; set; }
        public Genero? Genero { get; set; }
        public Pronomes? Pronomes { get; set; }
    }

    public enum Pronomes
    {
        [Description("Ele/Dele")]
        EleDele = 0,
        [Description("Ela/Dela")]
        ElaDela = 1,
        [Description("Elu/Delu")]
        EluDelu = 2,
    }

    public enum OrientacaoSexual
    {
        [Description("Heterosexual")]
        Heterosexual = 0,
        [Description("Homosexual")]
        Homosexual = 1,
        [Description("Bisexual")]
        Bisexual = 2,
        [Description("Assexual")]
        Assexual = 3,
        [Description("Pansexual")]
        Pansexual = 4,
        [Description("Outro")]
        Outro = 5
    }
    public enum Genero
    {
        [Description("Cisgênero")]
        Cisgenero = 0,
        [Description("Transgênero")]
        Transgenero = 1,
        [Description("Não Binário")]
        NaoBinario = 2,
        [Description("Outro")]
        Outro = 5
    }

    public enum Raca
    {
        [Description("Amarelo")]
        Amarelo = 0,
        [Description("Branca")]
        Branca = 1,
        [Description("Indigena")]
        Indigena = 2,
        [Description("Pardo")]
        Pardo = 3,
        [Description("Preto")]
        Preto = 4,
        [Description("Outro")]
        Outro = 5
    }
}