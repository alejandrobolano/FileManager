using FileManager.DataAccess.Dao.Contracts.Dao;
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
    public partial class FormAirports : Form
    {
        public FormAirports()
        {
            InitializeComponent();
        }

        private void FormAirports_Load(object sender, EventArgs e)
        {
            SingletonAirports singleton = SingletonAirports.Instance;
            IAirportDao airportDao = SingletonAirports.GetAirportDao();
            foreach (var item in airportDao.Airports())
            {
                comboOrigin.Items.Add(item.Name + " " + item.Country + " " + item.Id);
            }
        }

        private void ComboOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
