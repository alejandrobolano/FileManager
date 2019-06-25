using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Models;
using FileManager.Common.Models.Util;

namespace FileManager.DataAccess.Dao
{
    public class TxtFile : IManageFile
    {
        private static readonly log4net.ILog LOG = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Student Add(Student student)
        {
            try
            {
                StringBuilder studentString = ConcatStringStudent(student);
                using (StreamWriter writer = File.AppendText(Helper.NAMETXT))
                {
                    Write(studentString.ToString(), writer);
                }
                LOG.Info(student.Name);
            }
            catch (Exception e)
            {
                //using (StreamWriter w = File.AppendText("txtfile_log.txt"))
                //{
                //    Helper.Log(e.Message, student, w);
                //}
                LOG.Error(e + student.Name);
            }

            return Get(student.StudentId);
        }

        private static StringBuilder ConcatStringStudent(Student student)
        {
            StringBuilder studentString = new StringBuilder();
            studentString.Append(Convert.ToString(student.StudentId)).Append(",")
                 .Append(student.Name).Append(",")
                 .Append(student.Surname).Append(",")
                 .Append(Convert.ToString(student.DateOfBirth));
            return studentString;
        }

        public Student Get(int studentId)
        {
            List<string> lines = File.ReadLines(Helper.NAMETXT).ToList();
            string stream = lines.Where(s => s.StartsWith(Convert.ToString(studentId))).FirstOrDefault();
            return Helper.ConvertStringToStudent(stream);          
        }

        public Student Update(Student student, int studentId)
        {
            List<string> linesOfFile = File.ReadLines(Helper.NAMETXT).ToList();
            string stream = linesOfFile.Where(s => s.StartsWith(Convert.ToString(studentId))).FirstOrDefault();
            int position = linesOfFile.FindIndex(s => s.StartsWith(Convert.ToString(studentId)));
            linesOfFile.RemoveAt(position);
            string concatStudent = ConcatStringStudent(student).ToString();
            linesOfFile.Insert(position, concatStudent);
            File.WriteAllLines(Helper.NAMETXT, linesOfFile);
            return Get(Helper.ConvertStringToStudent(concatStudent).StudentId);
        }

        void Write(string message, TextWriter w)
        {                       
            w.WriteLine("{0}", message);
        }

    }
}
