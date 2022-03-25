namespace Unifica.Domain.Pessoas.Dto.Documentos.Pessoais
{
    public class TituloDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public int Numero { get; set; }
        public string Zona { get; set; }
        public string Secao { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
    }
}