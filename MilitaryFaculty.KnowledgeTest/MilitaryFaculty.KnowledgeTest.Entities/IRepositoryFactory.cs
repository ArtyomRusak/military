﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.InterfacesOfRepositories;

namespace MilitaryFaculty.KnowledgeTest.Entities
{
    public interface IRepositoryFactory
    {
        IRepository<Student, int> GetStudentRepository();
        IRepository<Variant, int> GetVariantRepository();
        IRepository<Question, int> GetQuestionRepository();
    }
}
