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
            /*
             TODO
            */
            iStudentDao.Add(student);
        }
    }
}
