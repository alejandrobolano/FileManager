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
            try
            {
                AddNode(student);
            }
            catch (FileLoadException e)
            {
                Log(student, e);
                throw;
            }
            catch (FileNotFoundException e)
            {
                Log(student, e);
                throw;
            }
            catch (AccessViolationException a)
            {
                Log(student, a);
                throw;
            }

            return Get(student.StudentId);
        }

        private static void Log(Student student, Exception exception)
        {
            using (StreamWriter w = File.AppendText("jsonfile_log.txt"))
            {
                Helper.Log(exception.Message, student, w);
            }
        }

        private static void AddNode(Student student)
        {
            var json = File.ReadAllText(Helper.NAMEJSON);
            var studentList = JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();
            studentList.Add(student);
            json = ToListJson(studentList);
        }

        private static string ToListJson(List<Student> studentList)
        {
            string json = JsonConvert.SerializeObject(studentList, new JsonSerializerSettings());
            File.WriteAllText(Helper.NAMEJSON, json);
            return json;
        }

        public Student Update(Student student, int studentId)
        {
            var json = File.ReadAllText(Helper.NAMEJSON);
            var studentList = JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();
            int pos = studentList.FindIndex(s => s.StudentId == studentId);
            studentList.RemoveAt(pos);
            studentList.Insert(pos, student);
            json = ToListJson(studentList);

            return Get(studentId);
        }
    }
}
