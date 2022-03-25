using Unifica.Domain.Pessoas.Entity;

namespace Unifica.Domain.Configurations
{
    public interface IAuthenticationService
    {
        string GenerateToken(Pessoa token);
    }
}