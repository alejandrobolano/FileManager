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
        void Add(Student student);

        Student Get(int studentId);
    }
}
