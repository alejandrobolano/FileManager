using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;

namespace FileManager.DataAccess.Dao
{
    public class StudentDao : IStudentDao
    {
        public Student Add(Student student)
        {
            ITxtFile iTxtFile = new TxtFile();
            return iTxtFile.WriteTxt(student);
        }
    }
}
