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

        public virtual List<VacinasView> Vacinas { get; set; }
        public virtual List<AlergiasView> Alergias { get; set; }
    }
}