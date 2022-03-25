using System.ComponentModel;

namespace Unifica.Domain.Pessoas.Entity.Documentos.Saude
{
    public class PessoaSus
    {
        public Guid Id { get; set; }
        public Guid IdPessoa { get; set; }
        public int Cns { get; set; }
        public bool Doador { get; set; }
        public TipoSanguineo TipoSanguineo { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual List<Vacinas> Vacinas { get; set; }
        public virtual List<AlergiasDto> Alergias { get; set; }
    }

    public enum TipoSanguineo
    {
        [Description("A+")]
        APositivo = 1,
        [Description("A-")]
        ANegativo = 2,
        [Description("B+")]
        BPositivo = 3,
        [Description("B-+")]
        BNegativo = 4,
        [Description("AB+")]
        ABPositivo = 5,
        [Description("AB-")]
        ABNegativo = 6,
        [Description("O+")]
        OPositivo = 7,
        [Description("O-")]
        ONegativo = 8
    }
}