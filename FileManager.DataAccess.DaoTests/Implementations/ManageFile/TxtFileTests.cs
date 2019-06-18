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

            Assert.AreEqual(manageFile.Add(student), student);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            TxtFile txtFile = new TxtFile();
            Student student = new Student()
            {
                StudentId = 37,
                Name = "Alberto",
                Surname = "Garcia",
                DateOfBirth = Convert.ToDateTime("22/02/2000")
            };
            Assert.AreEqual(txtFile.Update(student, student.StudentId), student);
        }
    }
}