using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces
{
    public interface IStudentService
    {
        Student AddStudent(Student student);
        Student AddStudent(string name, string surname, int platoon);
        Student GetStudentById(int studentId);
        Student GetStudent(Student student);
        Student GetStudent(string name, string surname, int platoon);
    }
}