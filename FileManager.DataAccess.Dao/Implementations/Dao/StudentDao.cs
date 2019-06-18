using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using FileManager.DataAccess.Dao;
using FileManager.DataAccess.Dao.Contracts.Factory;
using FileManager.DataAccess.Dao.Implementations.Factory;
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
            IStudentFactory abstractFactory;
            switch (fileType)
            {
                case EnumType.TXT:
                    {
                        abstractFactory = new TxtFactory();
                        return abstractFactory.Create();
                    }
                case EnumType.XML:
                    {
                        abstractFactory = new XmlFactory();
                        return abstractFactory.Create();
                    }
                default:
                    {
                        abstractFactory = new JsonFactory();
                        return abstractFactory.Create();
                    }

            }

        }

        
    }
}
