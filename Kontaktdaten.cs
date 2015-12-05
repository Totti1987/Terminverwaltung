using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.IO;

namespace Terminverwaltung
{
    public partial class Kontaktdaten : Form
    {

        string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Temp\\Terminverwaltung.accdb";
        //string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\tloebenstein\\Documents\\Visual Studio 2013\\Projects\\CTerminverwaltung\\CTerminverwaltung\\Terminverwaltung.accdb";
        System.Data.OleDb.OleDbConnection dBVerbindung = null;
        System.Data.OleDb.OleDbCommand befehl = null;
        System.Data.OleDb.OleDbDataReader datenleser = null;
        bool offen = false;
        string kontakt_id;
        int anzahl = 0;

        public Kontaktdaten()
        {
            InitializeComponent();
        }



        private void Kontaktdaten_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "terminverwaltungDataSet.Kontakte". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.kontakteTableAdapter.Fill(this.terminverwaltungDataSet.Kontakte);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                offen = true;
                befehl = dBVerbindung.CreateCommand();

                string kid = dataGridViewKontakte.Rows[e.RowIndex].Cells[0].Value.ToString();

                befehl.CommandText = "select * from Kontakte where kontakt_id = " + kid + " ;";
                datenleser = befehl.ExecuteReader();

                while (datenleser.Read())
                {
                    this.Name.Text = datenleser.GetString(1);
                    this.Vorname.Text = datenleser.GetString(2);
                    this.Adresse.Text = datenleser.GetString(3);
                    this.Telefon.Text = datenleser.GetString(4);
                    this.Email.Text = datenleser.GetString(5);
                    //Die Daten sind bereits vorhanden daher wird für ein 
                    //eventuelles Update die Kontakt_id gespeichert
                    kontakt_id = datenleser.GetInt32(0).ToString();
                }

            }
            catch (Exception ausnahme)
            {
                MessageBox.Show("Datenbankfehler: " + ausnahme.Message);
            }
            finally
            {
                if (offen == true) dBVerbindung.Close();
            }

        }

        private void Speichern_Click(object sender, EventArgs e)
        {
            //Insert
            if (kontakt_id == null)
            {
                try
                {
                    dBVerbindung = new OleDbConnection(verbindungsstring);
                    dBVerbindung.Open();
                    offen = true;
                    befehl = dBVerbindung.CreateCommand();
                    befehl.CommandText = "insert into Kontakte (name, vorname, adresse, telefon, email, bild)  values('" + this.Name.Text + "', '" + this.Vorname.Text + "', '" + this.Adresse.Text + "', '" + this.Telefon.Text + "','" + this.Email.Text + "','" + this.Bild.Image + ");";
                    anzahl = befehl.ExecuteNonQuery();
                    //Übersicht neu anzeigen 
                    //this.kontakteTableAdapter.Fill(this.terminverwaltungDataSet.Kontakte);
                    befehl.CommandText = "select * from Kontakte;";
                    datenleser = befehl.ExecuteReader();
                    int row = 0;
                    while (datenleser.Read())
                    {
                        dataGridViewKontakte.Rows[row].Cells[this.kontaktidDataGridViewTextBoxColumn.Index].Value = datenleser.GetInt32(0).ToString();
                        dataGridViewKontakte.Rows[row].Cells[this.nameDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(1);
                        dataGridViewKontakte.Rows[row].Cells[this.vornameDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(2);
                        dataGridViewKontakte.Rows[row].Cells[this.adresseDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(3);
                        dataGridViewKontakte.Rows[row].Cells[this.telefonDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(4);
                        dataGridViewKontakte.Rows[row].Cells[this.emailDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(5);
                        row = row + 1;
                    }

                }
                catch (Exception ausnahme)
                {
                    MessageBox.Show("Datenbankfehler: " + ausnahme.Message);
                }
                finally
                {
                    if (offen == true) dBVerbindung.Close();
                }
            }
            else
            //Update
            {
                try
                {
                    dBVerbindung = new OleDbConnection(verbindungsstring);
                    dBVerbindung.Open();
                    offen = true;
                    befehl = dBVerbindung.CreateCommand();
                    befehl.CommandText = "Update Kontakte set name = '" + this.Name.Text + "',vorname = '" + this.Vorname.Text + "', adresse = '" + this.Adresse.Text + "' , telefon = '" + this.Telefon.Text + "', email = '" + this.Email.Text + "', bild= '" + this.Bild.Image + "' where kontakt_id = " + kontakt_id + " ;";
                    anzahl = befehl.ExecuteNonQuery();
                    //Übersicht neu anzeigen 
                    //this.kontakteTableAdapter.Fill(this.terminverwaltungDataSet.Kontakte);
                    befehl.CommandText = "select * from Kontakte;";
                    datenleser = befehl.ExecuteReader();
                    int row = 0;
                    while (datenleser.Read())
                    {
                        dataGridViewKontakte.Rows[row].Cells[this.kontaktidDataGridViewTextBoxColumn.Index].Value = datenleser.GetInt32(0).ToString();
                        dataGridViewKontakte.Rows[row].Cells[this.nameDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(1);
                        dataGridViewKontakte.Rows[row].Cells[this.vornameDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(2);
                        dataGridViewKontakte.Rows[row].Cells[this.adresseDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(3);
                        dataGridViewKontakte.Rows[row].Cells[this.telefonDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(4);
                        dataGridViewKontakte.Rows[row].Cells[this.emailDataGridViewTextBoxColumn.Index].Value = datenleser.GetString(5);
                        row = row + 1;
                    }

                }
                catch (Exception ausnahme)
                {
                    MessageBox.Show("Datenbankfehler: " + ausnahme.Message);
                }
                finally
                {
                    if (offen == true) dBVerbindung.Close();
                }
            }

        }

        private void Bild_Click(object sender, EventArgs e)
        {
            OpenFileDialog openBild = new OpenFileDialog();

            openBild.InitialDirectory = "c:\\";
            openBild.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
            openBild.FilterIndex = 2;
            openBild.RestoreDirectory = true;
            openBild.FileName = "";

            if (openBild.ShowDialog() == DialogResult.OK)
            {
                string fileName = openBild.FileName;
                try
                {
                    // Altes Bild vorher freigeben 
                    if (this.Bild.Image != null)
                    {
                        this.Bild.Image.Dispose();
                        this.Bild.Image = null;
                    }

                    this.Bild.Image = Image.FromFile(fileName);

                    // Neues Vorgabeverzeichnis fürs Öffnen
                    openBild.InitialDirectory = System.IO.Path.GetDirectoryName(fileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bild konnte nicht geöffnet werden! " + ex.Message);
                }
            }

        }

    }

}