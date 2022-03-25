using Unifica.Domain.Pessoas.Entity.Documentos.Cnh;

namespace Unifica.Domain.Pessoas.Dto.Documentos.Cnh
{
    public class PessoaCnhDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public Guid IdOrgaoEmissor { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime PrimeiraHabilitacao { get; set; }
        public int NumeroRegistro { get; set; }
        public TipoCategoria Categoria { get; set; }
        public string CodigoSeguranca { get; set; }
    }
}