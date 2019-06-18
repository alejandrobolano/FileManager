using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Models.Util
{
    public class Helper
    {

        //public static string NameTxt = ConfigurationManager.AppSettings.Get("TxtPath");
        public static string NameTxt = Environment.GetEnvironmentVariable(ConfigurationManager.AppSettings.Get("TxtPath"), EnvironmentVariableTarget.Machine) + ".txt";
        //public static string NameXml = ConfigurationManager.AppSettings.Get("XmlPath");
        public static string NameXml = Environment.GetEnvironmentVariable(ConfigurationManager.AppSettings.Get("XmlPath"), EnvironmentVariableTarget.Machine) + ".xml";
        //public static string NameJson = ConfigurationManager.AppSettings.Get("JsonPath");
        public static string NameJson = Environment.GetEnvironmentVariable(ConfigurationManager.AppSettings.Get("JsonPath"), EnvironmentVariableTarget.Machine) + ".json";

        public static void WriteLineConsole(string message)
        {
            Console.WriteLine(message);
        }

        public static Student ConvertStringToStudent(string stream)
        {
            Student student = new Student();
            string[] streamList = stream.Split(',');
            student.StudentId = Convert.ToInt32(streamList[0]);
            student.Name = streamList[1];
            student.Surname = streamList[2];
            student.DateOfBirth = Convert.ToDateTime(streamList[3]);

            return student;
        }

        public static void Log(string logMessage, Student student, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("{0}", logMessage);
            w.WriteLine("{0}", student.StudentId);
            w.WriteLine("{0}", student.Name);
            w.WriteLine("{0}", student.Surname);
            w.WriteLine("{0}", student.DateOfBirth);
            w.WriteLine("-------------------------------");
        }
    }
}
