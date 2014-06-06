using System.Collections.Generic;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces
{
    public interface IMembershipService
    {
        Student AddStudent(string name, string surname, int platoon);
        Student GetStudent(string name, string surname, int platoon);
        Student GetStudentById(int studentId);
        void UpdateStudent(Student student);
        void RemoveStudent(Student student);
        void SetResult(int studentId, double mark);
        List<Result> GetResultsOfStudent(int studentId);
        bool LoginAsTeacher(string password);
    }
}
