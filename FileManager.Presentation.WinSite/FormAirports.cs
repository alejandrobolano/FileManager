using FileManager.Common.Models;
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
        IDictionary<Airport, List<Airport>> dictionaryAirport;
        public FormAirports()
        {
            InitializeComponent();
        }

        private void FormAirports_Load(object sender, EventArgs e)
        {
            SingletonAirports singleton = SingletonAirports.Instance;
            dictionaryAirport = SingletonAirports.GetDictionaryAirport();
            comboOrigin.DataSource = dictionaryAirport.Keys.ToList();
            comboOrigin.DisplayMember = "Name";
        }

        private void ComboOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var airportOrigin = comboOrigin.SelectedItem as Airport;
            comboDestination.DataSource = dictionaryAirport[airportOrigin];
            comboDestination.DisplayMember = "Name";
            var airportDestination = comboDestination.SelectedItem as Airport;
            label1.Text = "Origin: " + airportOrigin.Id + " " + airportOrigin.Name + " " + airportOrigin.Country + " "
                + "\nDestination: " + airportDestination.Id + " " + airportDestination.Name + " " + airportDestination.Country;
        }

        private void ComboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
