using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using Newtonsoft.Json;

namespace FileManager.DataAccess.Dao
{
    public class JsonFile : IManageFile
    {
        public Student Get(int studentId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Student student)
        {

            /*var studen = new Student
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Surname = student.Surname,
                DateOfBirth = Convert.ToDateTime(student.DateOfBirth)
            };
            */

            string json = JsonConvert.SerializeObject(student);
            System.IO.File.WriteAllText(Helper.NameJson, json);
        }
    }
}
