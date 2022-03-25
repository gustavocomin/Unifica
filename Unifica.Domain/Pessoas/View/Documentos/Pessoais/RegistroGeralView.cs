using Unifica.Domain.Pessoas.View.Documentos.Filiacoes;

namespace Unifica.Domain.Pessoas.View.Documentos.Pessoais
{
    public class PessoaRgView
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public string Rg { get; set; }
        public string CidadeNaturalidade { get; set; }
        public string EstadoNaturalidade { get; set; }
        public string DocOrigem { get; set; }
        public string OrgaoEmissor { get; set; }

        public virtual List<PessoaFiliacaoView> Filiacao { get; set; }
    }
}