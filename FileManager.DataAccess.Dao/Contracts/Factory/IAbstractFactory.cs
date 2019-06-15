using FileManager.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao
{
    interface IAbstractFactory
    {
        IManageFile CreateTxtFile();
        IManageFile CreateXmlFile();
        IManageFile CreateJsonFile();
    }
}
