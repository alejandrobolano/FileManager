using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao
{
    public interface IStudentDao
    {
        Student Add(Student student, EnumType fileType);
    }
}
