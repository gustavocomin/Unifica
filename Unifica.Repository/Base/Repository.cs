using Unifica.Domain.Base;

namespace Unifica.Repository.Base
{
    public class Repository<TEntidade> : IRepository<TEntidade>
    {
        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public void Inserir()
        {
            throw new NotImplementedException();
        }

        public void Persist()
        {
            //new CourseDbContext().SaveChanges();
        }

        public void Recuperar()
        {
            throw new NotImplementedException();
        }

        public void RepuerarPorId()
        {
            throw new NotImplementedException();
        }
    }
}