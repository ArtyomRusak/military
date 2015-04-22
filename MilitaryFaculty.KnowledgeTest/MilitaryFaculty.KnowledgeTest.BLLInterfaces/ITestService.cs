using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces
{
    public interface ITestService : IService
    {
        Test GetTestSingleton();
    }
}
