using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Initializers;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using TestContext = MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.TestContext;

namespace MilitaryFaculty.KnowledgeTest.Tests
{
    [TestClass]
    public class ContextTests
    {
        [TestMethod]
        public void ShouldCreateDatabase()
        {
            Database.SetInitializer(new RecreateAlways());
            var context = new TestContext("unittest");
            var student = new Student { Name = "Artsiom", Surname = "Rusak", Platoon = 111115 };
            context.Students.Add(student);
            context.SaveChanges();

            var result = new Result { Mark = 10, Date = DateTime.Now, StudentId = student.Id };
            context.Results.Add(result);
            context.SaveChanges();


            context.Dispose();
        }
    }
}
