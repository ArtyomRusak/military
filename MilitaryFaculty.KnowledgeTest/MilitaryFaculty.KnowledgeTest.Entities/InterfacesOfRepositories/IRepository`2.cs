using System;
using System.Linq;
using System.Linq.Expressions;

namespace MilitaryFaculty.KnowledgeTest.Entities.InterfacesOfRepositories
{
    public interface IRepository<TEntity, in TKey> : IRepository where TEntity : Entity
    {
        void Add(TEntity value);
        void Remove(TEntity value);
        void Update(TEntity value);
        TEntity GetEntityById(TKey id);
        TEntity Find(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> All();
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);
    }
}
