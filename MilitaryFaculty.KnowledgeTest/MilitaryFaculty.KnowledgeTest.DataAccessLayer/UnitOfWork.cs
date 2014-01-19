using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.Repositories;
using MilitaryFaculty.KnowledgeTest.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;
using MilitaryFaculty.KnowledgeTest.Entities.InterfacesOfRepositories;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork, IRepositoryFactory
    {
        private readonly TestContext _context;
        private IRepository<Student, Guid> _studentRepository;
        private IRepository<Question, Guid> _questionRepository;
        private IRepository<Variant, Guid> _variantRepository;
        private DbContextTransaction _transaction;
        private bool _disposed;
        private bool _isTransactionActive;


        public UnitOfWork(TestContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();
            _isTransactionActive = true;
        }

        #region Implementation of IRepositoryFactory

        public IRepository<Student, Guid> GetStudentRepository()
        {
            return _studentRepository ?? (_studentRepository = new Repository<Student, Guid>(_context));
        }

        public IRepository<Variant, Guid> GetVariantRepository()
        {
            return _variantRepository ?? (_variantRepository = new Repository<Variant, Guid>(_context));
        }

        public IRepository<Question, Guid> GetQuestionRepository()
        {
            return _questionRepository ?? (_questionRepository = new Repository<Question, Guid>(_context));
        }

        #endregion

        #region Implementation of IUnitOfWork

        public void Commit()
        {
            try
            {
                if (_isTransactionActive && !_disposed)
                {
                    _context.SaveChanges();
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                throw new RepositoryException(e.Message);
            }
        }

        public void Rollback()
        {
            if (_isTransactionActive && !_disposed)
            {
                _transaction.Rollback();
            }
        }

        #endregion

        #region Implementation of IDisposable

        public void Dispose()
        {
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }

        #endregion

        #region [UnitOfWork's members]

        public bool SetNewTransaction()
        {
            if (!_isTransactionActive && !_disposed)
            {
                _transaction = _context.Database.BeginTransaction();
                _isTransactionActive = true;
                return true;
            }
            return false;
        }

        #endregion
    }
}
