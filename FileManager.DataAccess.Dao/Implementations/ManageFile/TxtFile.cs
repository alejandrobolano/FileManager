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
        public Student Add(Student student)
        {
            StringBuilder studentString = new StringBuilder();
            try
            {
                studentString.Append(Convert.ToString(student.StudentId)).Append(",")
                     .Append(student.Name).Append(",")
                     .Append(student.Surname).Append(",")
                     .Append(Convert.ToString(student.DateOfBirth));

                using (StreamWriter writer = File.AppendText(Helper.NameTxt))
                {
                    Write("", studentString.ToString(), writer);
                }
                Helper.WriteLineConsole("Add student " + student.Name + " to " + Helper.NameTxt + " succesfull");
            }
            catch (Exception e)
            {
                using (StreamWriter w = File.AppendText("txtfile_log.txt"))
                {
                    Helper.Log(e.Message, student, w);
                }
            }

            return Get(student.StudentId);
        }
        public Student Get(int studentId)
        {
            List<string> lines = File.ReadLines(Helper.NameTxt).ToList();
            string stream = lines.Where(s => s.StartsWith(Convert.ToString(studentId))).FirstOrDefault();
            return Helper.ConvertStringToStudent(stream);          
        }

        void Write(string logMessage, string message, TextWriter w)
        {
            if (!logMessage.Equals(""))
            {
                w.WriteLine("{0}", logMessage);
            }            
            w.WriteLine("{0}", message);
        }

    }
}
