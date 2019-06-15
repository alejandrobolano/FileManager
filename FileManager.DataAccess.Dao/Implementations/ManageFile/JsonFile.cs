using System;
using System.Collections.Generic;
using System.IO;
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
            string path = Helper.NameJson;
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                var students = JsonConvert.DeserializeObject<List<Student>>(json);
                return students.Where(s => s.StudentId == studentId).FirstOrDefault();
            }
        }

        public void Add(Student student)
        {
            string json = JsonConvert.SerializeObject(student);
            using (StreamWriter writer = File.AppendText(Helper.NameJson))
            {
                writer.WriteLine("{0}", json);
            }

        }
    }
}
