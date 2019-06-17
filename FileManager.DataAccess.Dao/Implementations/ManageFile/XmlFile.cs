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
            var doc = CreateXml();
            Add(doc, student);
            return Get(student.StudentId) ;
        }

                     
        public XmlDocument CreateXml()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlNode element1 = doc.CreateElement("Students");
            doc.AppendChild(element1);
            doc.Save(Helper.NameXml);
            return doc;
        }

        public void Add(XmlDocument doc, Student student)
        {
            XmlNode studentNode = AddNode(doc, student);
            XmlNode nodoRaiz = doc.DocumentElement;
            nodoRaiz.InsertAfter(studentNode, nodoRaiz.LastChild);
            doc.Save(Helper.NameXml);
        }

        private XmlNode AddNode(XmlDocument doc, Student student)
        {            
            XmlNode studentNode = doc.CreateElement("Student");
            XmlElement xStudentId = doc.CreateElement("StudentId");
            xStudentId.InnerText = Convert.ToString(student.StudentId);
            studentNode.AppendChild(xStudentId);
            XmlElement xName = doc.CreateElement("Name");
            xName.InnerText = student.Name;
            studentNode.AppendChild(xName);
            XmlElement xSurname = doc.CreateElement("Surname");
            xSurname.InnerText = student.Surname;
            studentNode.AppendChild(xSurname);
            XmlElement xDateofBirth = doc.CreateElement("DateOfBirth");
            xDateofBirth.InnerText = Convert.ToString(student.DateOfBirth);
            studentNode.AppendChild(xDateofBirth);

            return studentNode;
        }

        public Student Get(int studentId)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Helper.NameXml);
            XmlNodeList nodeList = doc.SelectNodes("Students/Student");
            XmlNode studentNode;
            var studentList = new List<Student>();
            var student = new Student();
            for (int i = 0; i < nodeList.Count; i++)
            {
                studentNode = nodeList.Item(i);
                student.StudentId = Convert.ToInt32(studentNode.SelectSingleNode("StudentId").InnerText);
                student.Name = studentNode.SelectSingleNode("Name").InnerText;
                student.Surname = studentNode.SelectSingleNode("Surname").InnerText;
                student.DateOfBirth = Convert.ToDateTime(studentNode.SelectSingleNode("DateOfBirth").InnerText);
                studentList.Add(student);

            }
            var result = from x in studentList
                        where x.StudentId == studentId
                        select x;
            return result.FirstOrDefault();
        }



    }
}
