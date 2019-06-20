using FileManager.Common.Models;
using FileManager.DataAccess.Dao.Contracts.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao.Implementations.Dao
{
    public class SingletonAirports
    {
        private static SingletonAirports instance = null;
        private static readonly object padlock = new object();
        private static IAirportDao airportDao;
        private static IDictionary<Airport, List<Airport>> dictionaryAirport;
        private static Guid guid;
        public static string LANG { get; set; }

        private SingletonAirports()
        {
            guid = new Guid();
            airportDao = new AirportDao();
            dictionaryAirport = airportDao.Airports();
            LANG = "en-US";
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

        public static IDictionary<Airport, List<Airport>> GetDictionaryAirport()
        {
            return dictionaryAirport;
        }

        public static Guid GetGuid()
        {
            return guid;
        }

    }
}
