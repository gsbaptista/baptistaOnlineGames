using System.Linq;

namespace NHibernateData.Context.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T entity);
    }
}