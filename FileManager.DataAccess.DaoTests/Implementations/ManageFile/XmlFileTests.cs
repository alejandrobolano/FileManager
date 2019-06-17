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
                StudentId = 32,
                Name = "Manuel",
                Surname = "Ale",
                DateOfBirth = Convert.ToDateTime("20/02/2000")
            };

            Assert.AreEqual(manageFile.Add(student), student);
        }
    }
}