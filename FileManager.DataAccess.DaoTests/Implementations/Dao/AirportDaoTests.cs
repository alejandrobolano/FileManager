using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager.DataAccess.Dao.Implementations.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.DataAccess.Dao.Contracts.Dao;

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
            //SingletonAirports single1 = SingletonAirports.Instance; 
            //SingletonAirports single2 = SingletonAirports.Instance; 
            //Assert.AreEqual(single1.GetGuid().ToString,single2.GetGuid().ToString);
            Assert.Fail();
        }
    }
}