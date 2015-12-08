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
    public partial class Terminbearbeitung : Form
    {
        private int terminID = 0;

        // Aufruf mit übergebener Termin-ID --> Vorhandenen Termin bearbeiten
        public Terminbearbeitung(int termID)
        {
            InitializeComponent();

            if(termID == 0)
            {
                MessageBox.Show("Fehlerhafte Termin-ID wurde übergeben!");
            }
            else
            {
                terminID = termID;
                string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Temp\Terminverwaltung.accdb";

                System.Data.OleDb.OleDbConnection dBVerbindung = null;
                System.Data.OleDb.OleDbCommand befehl = null;
                System.Data.OleDb.OleDbDataReader datenleser = null;
                bool offen = false;

                try
                {
                    dBVerbindung = new System.Data.OleDb.OleDbConnection(verbindungsstring);
                    dBVerbindung.Open();
                    offen = true;

                    befehl = dBVerbindung.CreateCommand();
                    befehl.CommandText = "select * from Termine where Termin_ID = " + terminID;

                    datenleser = befehl.ExecuteReader();

                    // Liefert folgende Spalten zurück:
                    // 0 - Termin_ID; 1 - Titel; 2 - Datum; 3 - Uhrzeit; 4 - Beschreibung
                    // 5 - Kontakt
                    while (datenleser.Read())
                    {
                        textBoxTitel.Text = datenleser.GetString(1);
                        textBoxDatum.Text = datenleser.GetDateTime(2).ToString("dd.MM.yyyy");
                        textBoxUhrzeit.Text = datenleser.GetDateTime(3).ToString("HH:mm");
                        textBoxBeschreibung.Text = datenleser.GetString(4);
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

        // Aufruf mit Datum und Uhrzeit --> neuen Termin an diesem Datum anlegen
        public Terminbearbeitung(DateTime datum, DateTime uhrzeit)
        {
            InitializeComponent();

            if (datum == null || uhrzeit == null)
            {
                MessageBox.Show("Fehlerhaftes Datum oder fehlerhafte Uhrzeit wurden übergeben!");
            }
            else
            {
                textBoxDatum.Text = datum.ToString("dd.MM.yyyy");
                textBoxUhrzeit.Text = uhrzeit.ToString("HH:mm");
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            // Über die Termin-ID kann geprüft werden, ob ein bestehender Datensatz
            // bearbeitet werden soll oder ein neuer eingefügt werden soll
            if (terminID == 0)
            {
                if (textBoxTitel.Text != null && textBoxDatum != null && textBoxUhrzeit != null)
                {
                    // Neuen Termin anlegen
                    string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Temp\Terminverwaltung.accdb";

                    System.Data.OleDb.OleDbConnection dBVerbindung = null;
                    System.Data.OleDb.OleDbCommand befehl = null;
                    bool offen = false;

                    try
                    {
                        dBVerbindung = new System.Data.OleDb.OleDbConnection(verbindungsstring);
                        dBVerbindung.Open();
                        offen = true;

                        befehl = dBVerbindung.CreateCommand();
                        befehl.CommandText = "insert into Termine (Titel, Datum, Uhrzeit, Beschreibung) values ('"
                            + textBoxTitel.Text + "', '"
                            + textBoxDatum.Text + "', '"
                            + textBoxUhrzeit.Text + "', '"
                            + textBoxBeschreibung.Text + "')";

                        int anzahl = befehl.ExecuteNonQuery();
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
                {
                    MessageBox.Show("Bitte geben Sie mindestens einen Titel, das Datum und die Uhrzeit an!");
                }
            }
            else
            {
                // Bestehenden Termin updaten
                if (textBoxTitel.Text != null && textBoxDatum != null && textBoxUhrzeit != null)
                {
                    // Neuen Termin anlegen
                    string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Temp\Terminverwaltung.accdb";

                    System.Data.OleDb.OleDbConnection dBVerbindung = null;
                    System.Data.OleDb.OleDbCommand befehl = null;
                    bool offen = false;

                    try
                    {
                        dBVerbindung = new System.Data.OleDb.OleDbConnection(verbindungsstring);
                        dBVerbindung.Open();
                        offen = true;

                        befehl = dBVerbindung.CreateCommand();
                        befehl.CommandText = "update Termine \n"
                            + "set Titel = '" + textBoxTitel.Text + "', \n"
                            + "Datum = '" + textBoxDatum.Text + "', \n"
                            + "Uhrzeit = '" + textBoxUhrzeit.Text + "', \n"
                            + "Beschreibung = '" + textBoxBeschreibung.Text + "' \n"
                            + "where Termin_ID = " + terminID;

                        int anzahl = befehl.ExecuteNonQuery();
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
                {
                    MessageBox.Show("Bitte geben Sie mindestens einen Titel, das Datum und die Uhrzeit an!");
                }
            }
        }
    }
}
