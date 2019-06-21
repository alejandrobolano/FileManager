using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using System.Configuration;

namespace FileManager.DataAccess.Dao.Tests
{
    [TestClass()]
    public class StudentDaoTests
    {
        Student student;
        IStudentDao studentDao;
        public StudentDaoTests()
        {
            student = new Student()
            {
                StudentId = 12,
                Name = "Lolo",
                Surname = "Manolo",
                DateOfBirth = Convert.ToDateTime("10/02/2010")
            };
            studentDao = new StudentDao();
        }
        [TestMethod()]
        [DataRow(EnumType.TXT)]
        [DataRow(EnumType.XML)]
        [DataRow(EnumType.JSON)]
        public void AddTest(EnumType type)
        {
            Assert.AreEqual(studentDao.Add(student,type), student);
            //Assert.IsTrue(studentDao.Add(student, type).StudentId == student.StudentId);
        }

    }
}