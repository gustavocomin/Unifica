﻿using Unifica.Domain.Pessoas.Entity;
using Unifica.Domain.Pessoas.Repository;
using Unifica.Repository.Base;
using Unifica.Repository.Configuration.Pessoas;
using Unifica.Repository.Repository;

namespace Unifica.Repository.Pessoas
{
    public class RepPessoa : Repository<Pessoa>, IRepPessoa
    {
    }
}