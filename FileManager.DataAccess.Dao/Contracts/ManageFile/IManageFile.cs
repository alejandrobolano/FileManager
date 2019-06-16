using FileManager.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao
{
    public interface IManageFile
    {
        Student Add(Student student);

        Student Get(int studentId);
    }
}
