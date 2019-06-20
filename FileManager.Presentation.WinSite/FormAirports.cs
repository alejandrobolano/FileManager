using FileManager.Common.Models;
using FileManager.DataAccess.Dao.Contracts.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Presentation.WinSite
{
    public partial class FormAirports : Form
    {
        IDictionary<Airport, List<Airport>> dictionaryAirport;
        private string language;
        private ComponentResourceManager resourceManager;
        public FormAirports()
        {
            language = Properties.Settings.Default.Lang;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);            
            resourceManager = new ComponentResourceManager(typeof(FormAirports));
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
            label1.Text = resourceManager.GetString("origin")+": " + airportOrigin.Id + " " + airportOrigin.Name + " " + airportOrigin.Country + " "
                + "\n"+resourceManager.GetString("destination")+": " + airportDestination.Id + " " + airportDestination.Name + " " + airportDestination.Country;
        }

        private void ComboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EspañolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Lang.Equals("es-ES"))
            {
                language = "es-ES";
                englishToolStripMenuItem.Checked = false;
                españolToolStripMenuItem.Checked = true;
                Properties.Settings.Default.Lang = language;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Lang.Equals("en-US"))
            {
                language = "en-US";
                englishToolStripMenuItem.Checked = true;
                españolToolStripMenuItem.Checked = false;
                Properties.Settings.Default.Lang = language;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }
    }
}
