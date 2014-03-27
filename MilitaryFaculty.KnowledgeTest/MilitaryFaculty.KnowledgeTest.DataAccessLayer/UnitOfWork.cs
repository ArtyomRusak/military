using System;
using System.Data.Entity;
using MilitaryFaculty.KnowledgeTest.DALInterfaces;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.Repositories;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer
{
    public class UnitOfWork : IRepositoryFactory, IUnitOfWork
    {
        private readonly TestContext _context;
        private readonly DbContextTransaction _transaction;
        private IRepository<Student, int> _studentRepository;
        private IRepository<Variant, int> _variantRepository;
        private IRepository<Question, int> _questionRepository;
        private IRepository<Result, int> _resultRepository;
        private IRepository<Security, int> _securityRepository;
        private bool _disposed;
        private bool _isTransactionActive;

        public UnitOfWork(TestContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();
            _isTransactionActive = true;
        }

        public void Dispose()
        {
            if (_isTransactionActive)
            {
                try
                {
                    _context.SaveChanges();
                    _transaction.Commit();
                    _isTransactionActive = false;
                }
                catch (Exception e)
                {
                    _transaction.Rollback();
                    _isTransactionActive = false;

                    _context.Dispose();
                    _disposed = true;

                    throw new RepositoryException(e);
                }
            }
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }

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
                _isTransactionActive = false;
                throw new RepositoryException(e.Message);
            }
        }

        public void Rollback()
        {
            if (_isTransactionActive && !_disposed)
            {
                _transaction.Rollback();
                _isTransactionActive = false;
            }
        }

        public void PreSave()
        {
            _context.SaveChanges();
        }

        public IRepository<Student, int> GetStudentRepository()
        {
            return _studentRepository ?? (_studentRepository = new Repository<Student, int>(_context));
        }

        public IRepository<Variant, int> GetVariantRepository()
        {
            return _variantRepository ?? (_variantRepository = new Repository<Variant, int>(_context));
        }

        public IRepository<Question, int> GetQuestionRepository()
        {
            return _questionRepository ?? (_questionRepository = new Repository<Question, int>(_context));
        }

        public IRepository<Result, int> GetResultRepository()
        {
            return _resultRepository ?? (_resultRepository = new Repository<Result, int>(_context));
        }

        public IRepository<Security, int> GetSecurityRepository()
        {
            return _securityRepository ?? (_securityRepository = new Repository<Security, int>(_context));
        }
    }
}
