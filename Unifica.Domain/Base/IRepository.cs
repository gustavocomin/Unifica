namespace Unifica.Domain.Base
{
    public interface IRepository<TEntidade>
    {
        void Persist();
        void Recuperar();
        void RepuerarPorId();
        void Inserir();
        void Alterar();
    }
}