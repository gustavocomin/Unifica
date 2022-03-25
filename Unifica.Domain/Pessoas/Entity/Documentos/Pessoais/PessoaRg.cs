using Unifica.Domain.Pessoas.Dto.Documentos.Filiacao;
using Unifica.Domain.Pessoas.Entity.Documentos.Filiacao;

namespace Unifica.Domain.Pessoas.Entity.Documentos.Pessoais
{
    public class PessoaRg
    {
        public Guid Id { get; set; }
        public string Rg { get; set; }
        public string CidadeNaturalidade { get; set; }
        public string EstadoNaturalidade { get; set; }
        public string DocOrigem { get; set; }
        public string OrgaoEmissor { get; set; }
        public Guid IdPessoa { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual List<PessoaFiliacao> Filiacao { get; set; }
    }
}