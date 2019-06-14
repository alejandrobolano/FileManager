using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Models.Util
{
    public class Helper
    {
        public static string NameTxt = "Student.txt";
        public static string NameXml = "Student.xml";
        public static string NameJson = "Student.json";
        public static void WriteLineConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
