using System.Collections.Generic;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces
{
    public interface IResultService
    {
        Result AddResult(Result result);
        Result AddResult(int countOfRightAnswers, int countOfWrongAnswers, bool success, double mark, int studentId,
            ResultConfig resultConfig);
        IList<Result> GetResults();
        IList<Result> GetResultsByStudentId(int studentId);
    }
}