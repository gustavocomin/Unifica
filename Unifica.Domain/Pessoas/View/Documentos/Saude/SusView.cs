using Unifica.Domain.Pessoas.Entity.Documentos.Saude;

namespace Unifica.Domain.Pessoas.View.Documentos.Saude
{
    public class PessoaSusView
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public int Cns { get; set; }
        public bool Doador { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }

        public virtual List<VacinaView> Vacina { get; set; }
        public virtual List<AlergiaView> Alergia { get; set; }
    }
}