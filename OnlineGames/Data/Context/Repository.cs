using NHibernate;
using NHibernate.Linq;
using NHibernateData.Context;
using NHibernateData.Context.Interfaces;
using System.Linq;

namespace NHibernateData.Context
{
    public class Repository<T> : IRepository<T>
    {
        private UnitOfWork _unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        protected ISession Session { get { return _unitOfWork.Session; } }

        public void Create(T entity)
        {
            Session.Save(entity);
        }
    }
}