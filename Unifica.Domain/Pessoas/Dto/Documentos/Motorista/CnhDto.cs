﻿using Unifica.Domain.Pessoas.Entity.Documentos.Motorista;

namespace Unifica.Domain.Pessoas.Dto.Documentos.Motorista
{
    public class CnhDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public Guid IdOrgaoEmissor { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime DataPrimeiraHabilitacao { get; set; }
        public int NumeroRegistro { get; set; }
        public TipoCategoria Categoria { get; set; }
        public string CodigoSeguranca { get; set; }
    }
}