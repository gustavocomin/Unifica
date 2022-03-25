using Unifica.Domain.Pessoas.Entity.Documentos.Saude;

namespace Unifica.Domain.Pessoas.Dto.Documentos.Saude
{
    public class SusDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public int Cns { get; set; }
        public bool Doador { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }

        public virtual List<VacinaDto> Vacina { get; set; }
        public virtual List<AlergiaDto> Alergia { get; set; }
    }
}