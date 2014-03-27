using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces
{
    public interface IQuestionService
    {
        Question AddQuestion(string description);
        Question GetQuestionById(int questionId);
        void UpdateQuestion(Question question);
        List<Question> GetAllQuestions();
    }
}
