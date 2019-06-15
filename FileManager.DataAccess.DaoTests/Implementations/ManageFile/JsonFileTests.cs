using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;

namespace FileManager.DataAccess.Dao.Tests
{
    [TestClass()]
    public class JsonFileTests
    {
        private IManageFile manage;

        public JsonFileTests()
        {
            manage = new JsonFile();
        }
        [TestMethod()]
        public void AddTest()
        {
            Student student = new Student()
            {
                StudentId = 84,
                Name = "Alexander",
                Surname = "Ale",
                DateOfBirth = Convert.ToDateTime("20/02/2000")
            };

            manage.Add(student);
            Assert.IsTrue(manage.Get(student.StudentId).StudentId == student.StudentId);


        }
    }
}