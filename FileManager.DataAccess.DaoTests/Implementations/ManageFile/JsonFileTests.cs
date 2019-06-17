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
        private IManageFile manageFile;

        public JsonFileTests()
        {
            manageFile = new JsonFile();
        }
        [TestMethod()]
        public void AddTest()
        {
            Student student = new Student()
            {
                StudentId = 99,
                Name = "Alexander",
                Surname = "Manu",
                DateOfBirth = Convert.ToDateTime("20/02/2000")
            };

             Assert.AreEqual(manageFile.Add(student), student);
        }
    }
}