using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;

namespace FileManager.DataAccess.Dao
{
    class AbstractFactory : IAbstractFactory
    {
        public IManageFile CreateJsonFile()
        {
            return new JsonFile();
        }

        public IManageFile CreateTxtFile()
        {
            return new TxtFile();
        }

        public IManageFile CreateXmlFile()
        {
            return new XmlFile();
        }
    }
}
