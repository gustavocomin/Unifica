using Unifica.Domain.Pessoas.Entity.Documentos.Filiacoes;

namespace Unifica.Domain.Pessoas.Entity.Documentos.Pessoais
{
    public class RegistroGeral
    {
        public Guid Id { get; set; }
        public string Rg { get; set; }
        public string CidadeNaturalidade { get; set; }
        public string EstadoNaturalidade { get; set; }
        public string DocOrigem { get; set; }
        public string OrgaoEmissor { get; set; }
        public Guid IdPessoa { get; set; }

        public virtual List<Filiacao> Filiacao { get; set; }
    }
}