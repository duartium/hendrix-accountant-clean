using System.Collections.Generic;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
    }
}
