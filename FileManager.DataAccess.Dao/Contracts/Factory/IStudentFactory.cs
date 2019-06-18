using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao.Contracts.Factory
{
    public interface IStudentFactory
    {
        IManageFile Create();
    }
}
