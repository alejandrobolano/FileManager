﻿using FileManager.Common.Models;
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
    public class AirportDao : IAirportDao
    {
        public Airport Add(Airport airport)
        {
            throw new NotImplementedException();
        }

        public List<Airport> Airports()
        {
            Airport airportOrigin;
            Airport airportDestination;
            List<Airport> list = new List<Airport>();
            List<Airport> listDestination = new List<Airport>();
            try
            {
                XDocument xDoc = XDocument.Load(Helper.AIRPORTPATH);
                var airportsXml = xDoc.Descendants("Airport");                
                foreach (var airportNode in airportsXml)
                {
                    airportOrigin = new Airport();
                    FillField(airportOrigin, airportNode);
                    airportDestination = new Airport();
                    foreach (var item in airportNode.Elements().Descendants("Destination"))
                    {
                        listDestination = new List<Airport>();
                        FillField(airportDestination, item);
                        listDestination.Add(airportDestination);

                    }
                    airportOrigin.ListAirport = listDestination;
                    list.Add(airportOrigin);
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

        private static void FillField(Airport airportOrigin, XElement airportNode)
        {
            airportOrigin.Id = airportNode.Attribute("Id").Value;
            airportOrigin.Name = airportNode.Element("Name").Value;
            airportOrigin.Country = airportNode.Element("Country").Value;
        }

        public Airport Get()
        {
            throw new NotImplementedException();
        }
                
    }
}
