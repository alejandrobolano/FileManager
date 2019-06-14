using FileManager.Common.Models;
using FileManager.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Presentation.WinSite
{
    public partial class FormStudent : Form
    {
        public int StudentId;
        public String Name;
        public String Surname;
        public String DateOfBirth;

        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            IStudentDao iStudentDao = new StudentDao();
            Student student = new Student();
            student.StudentId = Convert.ToInt32(textStudentId.Text);
            student.Name = textName.Text;
            student.Surname = textSurname.Text;
            student.DateOfBirth = Convert.ToDateTime(textDateOfBirth.Text);

            iStudentDao.Add(student);

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

    }
}
