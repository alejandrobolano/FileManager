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
            string path = Helper.NAMEJSON;
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                var students = JsonConvert.DeserializeObject<List<Student>>(json);
                return students.Where(s => s.StudentId == studentId).FirstOrDefault();
            }
        }

        public Student Add(Student student)
        {
            var students = GetAll();
            students.Add(student);
            try
            {
                if (File.Exists(Helper.NAMEJSON))
                {
                    File.Delete(Helper.NAMEJSON);
                }            
                using (StreamWriter writer = File.AppendText(Helper.NAMEJSON))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, students);
                    Helper.WriteLineConsole("Add student " + student.Name + " to " + Helper.NAMEJSON + " succesfull");
                }
            }
            catch (Exception e)
            {
                using (StreamWriter w = File.AppendText("jsonfile_log.txt"))
                {
                    Helper.Log(e.Message, student, w);
                }
                throw;
            }           

            return Get(student.StudentId);
        }

        public List<Student> GetAll()
        {
            if (!File.Exists(Helper.NAMEJSON))
                return new List<Student>();
            else
            {
                string path = Helper.NAMEJSON;
                using (StreamReader jsonStream = File.OpenText(path))
                {
                    var json = jsonStream.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Student>>(json);                
                }
            }            
        }

        public Student Update(Student student, int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
