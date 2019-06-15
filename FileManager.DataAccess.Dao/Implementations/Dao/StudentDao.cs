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
        public Student Add(Student student, string fileType)
        {
            var manageFile = GetManageFile(fileType);
            manageFile.Add(student);
            return student;
            //return manageFile.Get(student.StudentId);
        }

        private IManageFile GetManageFile(string fileType)
        {
            IAbstractFactory abstractFactory = new AbstractFactory();
            switch (fileType)
            {
                case "TXT":
                    {
                        return abstractFactory.CreateTxtFile();
                    }
                case "XML":
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
