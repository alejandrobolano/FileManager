﻿using FileManager.Common.Models;
using FileManager.Common.Models.Util;
using FileManager.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FileManager.Presentation.WinSite
{
    public partial class FormStudent : Form
    {
        
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
           
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
            }
            

        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
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
    }
}
