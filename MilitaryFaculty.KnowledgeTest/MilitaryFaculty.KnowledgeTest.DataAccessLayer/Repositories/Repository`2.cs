using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using MilitaryFaculty.KnowledgeTest.DALInterfaces;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;
using MilitaryFaculty.KnowledgeTest.Infrastructure.Guard.Validation;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.Repositories
{
    public class Repository<TEntity, TKey> : Repository, IRepository<TEntity, TKey> where TEntity : Entity
    {
        private readonly DbSet<TEntity> _entities;

        public Repository(TestContext context)
            : base(context)
        {
            _entities = Context.Set<TEntity>();
        }

        public void Add(TEntity value)
        {
            Guard.AgainstNullReference(value, "value");

            _entities.Add(value);
        }

        public void Remove(TEntity value)
        {
            Guard.AgainstNullReference(value, "value");

            _entities.Remove(value);
        }

        public void Update(TEntity value)
        {
            Guard.AgainstNullReference(value, "value");

            _entities.Attach(value);
            Context.Entry(value).State = EntityState.Modified;
        }

        public TEntity GetEntityById(TKey id)
        {
            Guard.AgainstNullReference(id, "id");

            try
            {
                return _entities.Find(id);
            }
            catch (Exception e)
            {
                throw new RepositoryException(e);
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            Guard.AgainstNullReference(predicate, "predicate");

            try
            {
                return _entities.SingleOrDefault(predicate);
            }
            catch (Exception e)
            {
                throw new RepositoryException(e);
            }
        }

        public IQueryable<TEntity> All()
        {
            return _entities;
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            Guard.AgainstNullReference(predicate, "predicate");

            return _entities.Where(predicate);
        }
    }
}
