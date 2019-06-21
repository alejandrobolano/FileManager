using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using FileManager.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "App.config", Watch = true)]

namespace FileManager.Presentation.WinSite
{
    public partial class FormStudent : Form
    {
        private string language;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public FormStudent()
        {
            language = Properties.Settings.Default.Lang;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            log.Info("This is an info log");
            log.Error("This is my error");
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!CheckEmptyFields())
            {
                IStudentDao iStudentDao = new StudentDao();
                Student student = new Student();
                student.StudentId = Convert.ToInt32(textStudentId.Text);
                student.Name = textName.Text;
                student.Surname = textSurname.Text;
                student.DateOfBirth = Convert.ToDateTime(textDateOfBirth.Text);

                if (radioButtonJson.Checked)
                {
                    iStudentDao.Add(student, EnumType.JSON);
                }
                if (radioButtonXML.Checked)
                {
                    iStudentDao.Add(student, EnumType.XML);
                }
                if (radioButtonTxt.Checked)
                {
                    iStudentDao.Add(student, EnumType.TXT);
                }
                log.Info("This is an info log");
            }
            

        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }

        private bool CheckEmptyFields()
        {
            bool b = false;
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    if(((TextBox)control).Text.Equals(""))
                    {
                        return true;
                    }
                }
            }
            return b;
        }

        private void TextStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextDateOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
           
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Lang.Equals("en-US"))
            {
                language = "en-US";
                ChangeLang(true, false);
            }
        }

        private void SpanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Lang.Equals("es-ES"))
            {
                language = "es-ES";
                ChangeLang(false, true);
            }
        }

        private void ChangeLang(bool en, bool es)
        {
            englishToolStripMenuItem.Checked = en;
            spanishToolStripMenuItem.Checked = es;
            Properties.Settings.Default.Lang = language;
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
