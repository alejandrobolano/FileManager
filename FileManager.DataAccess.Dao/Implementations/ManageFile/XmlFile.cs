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
       public Student Add(Student student)
        {
            try
            {
                if (!File.Exists(Helper.NameXml))
                {
                    XmlWriterSettings xmlSettings = new XmlWriterSettings();
                    xmlSettings.Indent = true;
                    xmlSettings.CheckCharacters = true;
                    xmlSettings.NewLineOnAttributes = true;
                    using (XmlWriter writer = XmlWriter.Create(Helper.NameXml, xmlSettings))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Students");
                        writer.Flush();
                        writer.Close();
                    }
                }
                
                XDocument xml = XDocument.Load(Helper.NameXml);
                XElement students = xml.Element("Students");
                students.Add(
                    new XElement("Student",
                    new XAttribute("Id", student.StudentId),
                        new XElement("Name", student.Name),
                        new XElement("Surname", student.Surname),
                        new XElement("DateOfBirth", Convert.ToString(student.DateOfBirth))
                    ));
                xml.Save(Helper.NameXml);

            }
            catch (Exception e)
            {
                using (StreamWriter w = File.AppendText("xmlfile_log.txt"))
                {
                    Helper.Log(e.Message, student, w);
                }
            }
            
            return Get(student.StudentId) ;
        }

        public Student Get(int studentId)
        {
            XDocument xDoc = XDocument.Load(Helper.NameXml);
            var studentXml = xDoc.Descendants("Student");
            
            Student studentTemp = new Student();
            List<Student> list = new List<Student>();
            foreach (var studentNode in studentXml)
            {
                studentTemp.StudentId = Int32.Parse(studentNode.Attribute("Id").Value);
                studentTemp.Name = studentNode.Element("Name").Value;
                studentTemp.Surname = studentNode.Element("Surname").Value;
                studentTemp.DateOfBirth = DateTime.Parse(studentNode.Element("DateOfBirth").Value);
                list.Add(studentTemp);
            }
            
            return list.Where(s => s.StudentId == studentId).FirstOrDefault();
        }

        public Student Update(Student student, int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
