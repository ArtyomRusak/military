using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces
{
    public interface IStudentService
    {
        Student AddStudent(Student student);
        Student AddStudent(string name, string surname, int platoon);
        Student GetStudentById(int studentId);
        Student CheckStudentForExisting(string name, string surname, int platoon);
    }
}