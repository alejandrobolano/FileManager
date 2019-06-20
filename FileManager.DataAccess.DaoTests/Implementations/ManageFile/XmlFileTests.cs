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
    public class XmlFileTests
    {
        IManageFile manageFile;

        public XmlFileTests()
        {
            manageFile = new XmlFile();
        }

        [TestMethod()]
        public void AddTest()
        {
            Student student = new Student()
            {
                StudentId = 46,
                Name = "Alber",
                Surname = "Alexandro",
                DateOfBirth = Convert.ToDateTime("20/02/2000")
            };

            Assert.AreEqual(manageFile.Add(student), student);
        }

        [TestMethod()]
        [DataRow(46,"Tania","Lopez", "20/02/2000")]
        public void UpdateTest(int id, string name, string surname, string dateofbirth)
        {
            Student student = new Student()
            {
                StudentId = 46,
                Name = name,
                Surname = surname,
                DateOfBirth = Convert.ToDateTime(dateofbirth)
            };
            Assert.AreEqual(manageFile.Update(student,student.StudentId), student);
        }
    }
}