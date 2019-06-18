using FileManager.Common.Models;
using FileManager.DataAccess.Dao.Implementations.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao.Contracts.Dao
{
    public class SingletonAirports
    {
        private static SingletonAirports instance = null;
        private static readonly object padlock = new object();
        private static IAirportDao airportDao;

        private SingletonAirports()
        {
            airportDao = new AirportDao();
        }

        public static SingletonAirports Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonAirports();
                    }
                    return instance;
                }
            }
        }

        public static IAirportDao GetAirportDao()
        {
            return airportDao;
        }
    }
}
