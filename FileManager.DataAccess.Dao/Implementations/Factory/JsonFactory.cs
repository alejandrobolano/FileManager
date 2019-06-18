using FileManager.DataAccess.Dao.Contracts.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao.Implementations.Factory
{
    class JsonFactory : IStudentFactory
    {
        public IManageFile Create()
        {
            return new JsonFile();
        }
    }
}
