using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FileManager.DataAccess.Dao
{
    public class XmlFile : IManageFile
    {
        public Student Get(int studentId)
        {
            using (StreamReader reader = new StreamReader(Helper.NameXml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                var students = (List<Student>)serializer.Deserialize(reader);
                return students.Where(s => s.StudentId == studentId).FirstOrDefault();
            }
        }

        public Student Add(Student student)
        {            
            using (XmlTextWriter writer = new XmlTextWriter(Helper.NameXml, Encoding.UTF8))
            { 
                 writer.Formatting = Formatting.Indented;
                 writer.WriteStartElement("Student");
                 writer.WriteElementString("StudentID", Convert.ToString(student.StudentId));
                 writer.WriteElementString("Name", student.Name);
                 writer.WriteElementString("Surname", student.Surname);
                 writer.WriteElementString("DateofBirth", Convert.ToString(student.DateOfBirth));
                 writer.WriteEndElement();
                 writer.Flush();
                 Helper.WriteLineConsole("Add student "+ student.Name + " to " + Helper.NameXml + " succesfull");
            }

            //TODO return correct value
            return student;
        }

    }
}
