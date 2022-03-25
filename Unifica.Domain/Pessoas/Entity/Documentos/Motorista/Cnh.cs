namespace Unifica.Domain.Pessoas.Entity.Documentos.Motorista
{
    public class Cnh
    {
        public Guid Id { get; set; }
        public Guid IdPessoa { get; set; }
        public Guid IdOrgaoEmissor { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime DataPrimeiraHabilitacao { get; set; }
        public int NumeroRegistro { get; set; }
        public TipoCategoria Categoria { get; set; }
        public string CodigoSeguranca { get; set; }

        public virtual OrgaoEmissor OrgaoEmissor { get; set; }
    }

    public enum TipoCategoria
    {
        A = 0,
        A1 = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        AB = 6,
        AC = 7,
        AD = 8,
        AE = 9
    }
}