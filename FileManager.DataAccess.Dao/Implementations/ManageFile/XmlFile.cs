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

namespace FileManager.DataAccess.Dao
{
    public class XmlFile : IManageFile
    {
        XmlDocument documento;

        public Student Get(int studentId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Student student)
        {
            using (XmlTextWriter writer = new XmlTextWriter(Helper.NameXml, Encoding.UTF8))
            {
                 writer.Formatting = Formatting.Indented;
                 ///writer.WriteStartDocument();
                 writer.WriteStartElement("Student");
                 writer.WriteElementString("StudentID", Convert.ToString(student.StudentId));
                 writer.WriteElementString("Name", student.Name);
                 writer.WriteElementString("Surname", student.Surname);
                 writer.WriteElementString("DateofBirth", Convert.ToString(student.DateOfBirth));
                 writer.WriteEndElement();
                 //writer.WriteEndDocument();
                 writer.Flush();
                 //writer.Close();
            }
        }

    }
}
