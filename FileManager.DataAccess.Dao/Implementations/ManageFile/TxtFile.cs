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
        
        public void Add(Student student)
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
                Helper.WriteLineConsole("File text created succesfull");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        public Student Get(int studentId)
        {
            throw new NotImplementedException();
        }
        void Write(string logMessage, string message, TextWriter w)
        {
            if (!logMessage.Equals(""))
            {
                w.WriteLine("{0}", logMessage);
            }            
            w.WriteLine("{0}", message);
        }
        public string Read()
        {
            using (StreamReader r = File.OpenText(Helper.NameTxt))
            {
                return Read(r);
            }
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

    }
}
