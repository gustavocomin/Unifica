﻿namespace Unifica.Domain.Pessoas.Dto.Documentos.Trabalho
{
    public class CtpsDto
    {
        public Guid? Id { get; set; }
        public Guid IdPessoa { get; set; }
        public DateTime DataEmissao { get; set; }

        public List<string> ContratosTrabalho { get; set; }
    }
}