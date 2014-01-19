using System;
using MilitaryFaculty.KnowledgeTest.Entities;
using System.Linq.Expressions;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.Repositories.Helpers
{
    internal static class RepositoryHelper<TEntity> where TEntity : Entity
    {
        #region [Constants]

        private const string WrongPredicateMessage = "Wrong predicate";

        #endregion


        #region [Public members]

        public static void CheckPredicate(Expression<Func<TEntity, bool>> predicate, string parameterName)
        {
            if (predicate == null)
            {
                throw new ArgumentException(WrongPredicateMessage, parameterName);
            }
        }

        #endregion
    }
}
