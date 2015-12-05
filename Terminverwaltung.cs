using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminverwaltung
{
    public partial class Terminverwaltung : Form
    {
        public Terminverwaltung()
        {
            InitializeComponent();
        }

        private void Kontaktdaten_Click(object sender, EventArgs e)
        {
            Form frm = new Kontaktdaten();
            frm.Show();
            Kontaktdaten.Enabled = false;
        }


        private void Terminansicht_Click(object sender, EventArgs e)
        {

        }

        private void Ende_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
