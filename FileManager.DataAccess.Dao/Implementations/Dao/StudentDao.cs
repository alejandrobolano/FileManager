using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using FileManager.DataAccess.Dao;
using static FileManager.Common.Models.Util.Helper;

namespace FileManager.DataAccess.Dao
{
    public class StudentDao : IStudentDao
    {
        public Student Add(Student student, EnumType fileType)
        {
            var manageFile = GetManageFile(fileType);
            return manageFile.Add(student);
        }

        private IManageFile GetManageFile(EnumType fileType)
        {
            IAbstractFactory abstractFactory = new AbstractFactory();
            switch (fileType)
            {
                case EnumType.TXT:
                    {
                        return abstractFactory.CreateTxtFile();
                    }
                case EnumType.XML:
                    {
                        return abstractFactory.CreateXmlFile();
                    }
                default:
                    {
                        return abstractFactory.CreateJsonFile();
                    }

            }

        }

        
    }
}
