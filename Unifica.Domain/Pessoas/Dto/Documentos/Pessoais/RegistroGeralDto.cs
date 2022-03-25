using Unifica.Domain.Pessoas.Dto.Documentos.Filiacoes;

namespace Unifica.Domain.Pessoas.Dto.Documentos.Pessoais
{
    public class RegistroGeralDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public string Rg { get; set; }
        public string CidadeNaturalidade { get; set; }
        public string EstadoNaturalidade { get; set; }
        public string DocOrigem { get; set; }
        public string OrgaoEmissor { get; set; }

        public virtual List<FiliacaoDto> Filiacao { get; set; }
    }
}