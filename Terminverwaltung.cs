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
            bool alreadyOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form forms in fc)
            {
                if (forms.Text == "Kontaktdaten")
                {
                    alreadyOpen = true;
                }
            }

            if (alreadyOpen == false)
            {
                Form frm = new Kontaktdaten();
                frm.Show();
            }
            else
            {
               MessageBox.Show("Die Kontaktdatenverwaltung ist bereits geöffnet!");
            }
        }


        private void Terminansicht_Click(object sender, EventArgs e)
        {
            bool alreadyOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form forms in fc)
            {
                if (forms.Text == "Terminansicht")
                {
                    alreadyOpen = true;
                }
            }

            if (alreadyOpen == false)
            {
                Form frm = new Terminansicht();
                frm.Show();
            }
            else
            {
               MessageBox.Show("Die Terminbearbeitung ist bereits geöffnet!");
            }
        }
        private void Ende_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
