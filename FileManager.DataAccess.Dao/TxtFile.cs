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
    class TxtFile : ITxtFile
    {
        public Student WriteTxt(Student student)
        {
            StringBuilder studentString = new StringBuilder();
            try
            {
                studentString.Append(Convert.ToString(student.StudentId)).Append(",")
                     .Append(student.Name).Append(",")
                     .Append(student.Surname).Append(",")
                     .Append(Convert.ToString(student.DateOfBirth));

                using (StreamWriter w = File.AppendText(Helper.NameTxt))
                {
                    Write("", studentString.ToString(), w);
                }
                Helper.WriteLineConsole("File text created succesfull");
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }

            return ConvertStringToStudent(ReadTxt());
        }

        public string ReadTxt()
        {
            using (StreamReader r = File.OpenText(Helper.NameTxt))
            {
               return Read(r);
            }
        }
        void Write(string logMessage, string message, TextWriter w)
        {
            if (!logMessage.Equals(""))
            {
                w.WriteLine("{0}", logMessage);
            }            
            w.WriteLine("{0}", message);
        }

        string Read(StreamReader r)
        {
            string line;
            string final = "";
            while ((line = r.ReadLine()) != null)
            {
                final = line;
            }
            return final;
        }

        Student ConvertStringToStudent(string stream)
        {
            Student student = new Student();
            string[] streamList = stream.Split(',');
            student.StudentId = Convert.ToInt32(streamList[0]);
            student.Name = streamList[1];
            student.Surname = streamList[2];
            student.DateOfBirth = Convert.ToDateTime(streamList[3]);

            return student;
        }

    }
}
