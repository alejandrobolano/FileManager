using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using FileManager.DataAccess.Dao.Contracts.Dao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileManager.DataAccess.Dao.Implementations.Dao
{
    class AirportDao : IAirportDao
    {
        public Airport Add(Airport airport)
        {
            throw new NotImplementedException();
        }

        public List<Airport> Airports()
        {
            Airport airportTemp;
            List<Airport> list = new List<Airport>();
            try
            {
                XDocument xDoc = XDocument.Load(Helper.AIRPORTPATH);
                var airportsXml = xDoc.Descendants("Airport");                
                foreach (var studentNode in airportsXml)
                {
                    airportTemp = new Airport();
                    airportTemp.Id = studentNode.Attribute("Id").Value;
                    airportTemp.Name = studentNode.Element("Name").Value;
                    airportTemp.Country = studentNode.Element("Country").Value;
                    list.Add(airportTemp);
                }
            }
            catch (FileLoadException e)
            {
                using (StreamWriter w = File.AppendText("xmlairport_log.txt"))
                {
                    Helper.Log(e.Message, w);
                }
                throw;
            }
           

            return list;
        }

        public Airport Get()
        {
            throw new NotImplementedException();
        }
                
    }
}
