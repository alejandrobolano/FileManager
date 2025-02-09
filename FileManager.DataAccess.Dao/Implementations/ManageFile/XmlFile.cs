﻿using FileManager.Common.Models;
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
        private static readonly log4net.ILog LOG = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Student Add(Student student)
        {
            try
            {
                if (!File.Exists(Helper.NAMEXML))
                {
                    XmlSettings();
                }
                AddNode(student);
                LOG.Info(student.Name);
            }
            catch (Exception e)
            {
                //using (StreamWriter w = File.AppendText("xmlfile_log.txt"))
                //{
                //    Helper.Log(e.Message, student, w);
                //}
                LOG.Error(e + student.Name);
                throw;
            }            
            return Get(student.StudentId) ;
        }

        private static void AddNode(Student student)
        {
            XDocument xml = XDocument.Load(Helper.NAMEXML);
            XElement students = xml.Element("Students");
            students.Add(
                new XElement("Student",
                new XAttribute("Id", student.StudentId),
                    new XElement("Name", student.Name),
                    new XElement("Surname", student.Surname),
                    new XElement("DateOfBirth", Convert.ToString(student.DateOfBirth))
                ));
            xml.Save(Helper.NAMEXML);
        }

        private static void XmlSettings()
        {
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.CheckCharacters = true;
            xmlSettings.NewLineOnAttributes = true;
            using (XmlWriter writer = XmlWriter.Create(Helper.NAMEXML, xmlSettings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Students");
                writer.Flush();
            }
        }

        public Student Get(int studentId)
        {
            XDocument xDoc = XDocument.Load(Helper.NAMEXML);
            XElement root = xDoc.Root;
            Student studentResult = new Student();
            var studentList = from element in root.Elements("Student")
                          where element.Attribute("Id").Value.Equals(studentId.ToString())
                          select element;
            ConvertXElementToStudent(studentResult, studentList);

            return studentResult;
        }

        private static void ConvertXElementToStudent(Student studentResult, IEnumerable<XElement> student)
        {
            XElement temp = student.First();
            studentResult.StudentId = Convert.ToInt32(temp.Attribute("Id").Value);
            studentResult.Name = temp.Element("Name").Value;
            studentResult.Surname = temp.Element("Surname").Value;
            studentResult.DateOfBirth = Convert.ToDateTime(temp.Element("DateOfBirth").Value);
        }

        public Student Update(Student student, int studentId)
        {
            XDocument xDoc = XDocument.Load(Helper.NAMEXML);
            var studentXml = xDoc.Descendants("Student");
            IEnumerable<XElement> element = FindElement(studentId, studentXml);
            UpdateElement(student, xDoc, element);

            return Get(student.StudentId);
        }

        private static IEnumerable<XElement> FindElement(int studentId, IEnumerable<XElement> studentXml)
        {
            return from x in studentXml
                   where Convert.ToInt32(x.Attribute("Id").Value) == studentId
                   select x;
        }

        private static void UpdateElement(Student student, XDocument xDoc, IEnumerable<XElement> element)
        {
            XElement updateStudent = element.First();
            updateStudent.Attribute("Id").Value = student.StudentId.ToString();
            updateStudent.Element("Name").Value = student.Name;
            updateStudent.Element("Surname").Value = student.Surname;
            updateStudent.Element("DateOfBirth").Value = student.DateOfBirth.ToString();
            xDoc.Save(Helper.NAMEXML);
        }
    }
}
