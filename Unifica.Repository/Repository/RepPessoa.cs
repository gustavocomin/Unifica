﻿using Unifica.Domain.Pessoas.Entity;
using Unifica.Domain.Pessoas.Repository;
using Unifica.Repository.Base;

namespace Unifica.Repository.Repository
{
    public class RepPessoa : Repository<Pessoa>, IRepPessoa
    {
    }
}