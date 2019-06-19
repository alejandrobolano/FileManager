using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager.DataAccess.Dao.Implementations.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;

namespace FileManager.DataAccess.Dao.Implementations.Dao.Tests
{
    [TestClass()]
    public class AirportDaoTests
    {
        [TestMethod()]
        public void AirportsTest()
        {
            AirportDao airportDao = new AirportDao();
            airportDao.Airports();
            Assert.Fail();
        }
    }
}