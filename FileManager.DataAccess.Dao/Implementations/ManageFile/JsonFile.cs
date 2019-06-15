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
            var students = GetAll();
            students.Add(student);
            if (File.Exists(Helper.NameJson))
            {
                File.Delete(Helper.NameJson);
            }            
            using (StreamWriter writer = File.AppendText(Helper.NameJson))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, students);
            }

        }

        public List<Student> GetAll()
        {
            if (!File.Exists(Helper.NameJson))
                return new List<Student>();
            else
            {
                string path = Helper.NameJson;
                using (StreamReader jsonStream = File.OpenText(path))
                {
                var json = jsonStream.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Student>>(json);
                
                }
            }
            
        }
    }
}
