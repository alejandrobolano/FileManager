﻿using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using FileManager.DataAccess.Dao.Contracts.Dao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
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

        public IDictionary<Airport, List<Airport>> Airports()
        {
            /*
            Assembly a = Assembly.Load("FileManager.DataAccess.Dao");
            ResourceManager rm;
            if (SingletonAirports.LANG.Equals("en-US"))
                rm = new ResourceManager("FileManager.DataAccess.Dao.en-US", a);
            else rm = new ResourceManager("FileManager.DataAccess.Dao.es-ES", a);            
            Console.WriteLine(rm.GetString("testing"));
            */
            IDictionary<Airport, List<Airport>> keyValues = new Dictionary<Airport, List<Airport>>();
            try
            {
                XmlToDictionary(keyValues);
            }
            catch (FileLoadException e)
            {
                using (StreamWriter w = File.AppendText("xmlairport_log.txt"))
                {
                    Helper.Log(e.Message, w);
                }
                throw;
            }
           
            return keyValues;
        }
        private static void XmlToDictionary(IDictionary<Airport, List<Airport>> keyValues)
        {
            XDocument xDocA = XDocument.Load(Helper.AIRPORTPATH);
            XElement root = xDocA.Root;
            Airport origin;
            List<Airport> destinations;
            Airport destination;
            foreach (var item in root.Elements("Airport"))
            {
                AddDestinationToOrigin(keyValues, out origin, out destinations, out destination, item);
            }
        }

        private static void AddDestinationToOrigin(IDictionary<Airport, List<Airport>> keyValues, out Airport origin, out List<Airport> destinations, out Airport destination, XElement item)
        {
            origin = new Airport();
            ParseXmlToAirport(origin, item);
            destination = new Airport();
            destinations = new List<Airport>();
            foreach (var dest in item.Elements("Airports").Elements("Destination"))
            {
                ParseXmlToAirport(destination, dest);
                destinations.Add(destination);
            }
            keyValues.Add(origin, destinations);
        }

        private static void ParseXmlToAirport(Airport origin, XElement item)
        {
            origin.Id = item.Attribute("Id").Value;
            origin.Name = item.Element("Name").Value;
            origin.Country = item.Element("Country").Value;
        }

        public Airport Get()
        {
            throw new NotImplementedException();
        }
                
    }
}
