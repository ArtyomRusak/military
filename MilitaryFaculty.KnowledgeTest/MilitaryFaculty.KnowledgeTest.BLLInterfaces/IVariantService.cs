using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces
{
    public interface IVariantService
    {
        Variant AddVariantToQuestion(string description, bool isRight, int questionId);
        void UpdateVariant(Variant variant);
        Variant GetVariantById(int variantId);
        void RemoveVariant(Variant variant);
        List<Variant> GetVariantsByQuestionId(int questionId);
    }
}
