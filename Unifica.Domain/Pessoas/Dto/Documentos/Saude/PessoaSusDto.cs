using Unifica.Domain.Pessoas.Entity.Documentos.Saude;

namespace Unifica.Domain.Pessoas.Dto.Documentos.Saude
{
    public class PessoaSusDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public int Cns { get; set; }
        public bool Doador { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }

        public virtual List<VacinasDto> Vacinas { get; set; }
        public virtual List<AlergiasDto> Alergias { get; set; }
    }
}