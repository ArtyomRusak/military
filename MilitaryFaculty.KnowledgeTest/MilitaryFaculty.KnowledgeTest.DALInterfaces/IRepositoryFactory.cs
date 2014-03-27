using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DALInterfaces
{
    public interface IRepositoryFactory
    {
        IRepository<Student, int> GetStudentRepository();
        IRepository<Variant, int> GetVariantRepository();
        IRepository<Question, int> GetQuestionRepository();
        IRepository<Result, int> GetResultRepository();
        IRepository<Security, int> GetSecurityRepository();
    }
}
