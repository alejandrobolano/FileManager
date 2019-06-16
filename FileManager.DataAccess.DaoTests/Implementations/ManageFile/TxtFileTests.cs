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
    public class TxtFileTests
    {
        IManageFile manageFile;
        public TxtFileTests()
        {
            manageFile = new TxtFile();
        }
        [TestMethod()]
        public void AddTest()
        {
            Student student = new Student()
            {
                StudentId = 35,
                Name = "Manuel",
                Surname = "Ale",
                DateOfBirth = Convert.ToDateTime("20/02/2000")
            };

            manageFile.Add(student);
            Assert.IsTrue(manageFile.Get(student.StudentId).StudentId == student.StudentId);
        }
    }
}