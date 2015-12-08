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
    public partial class Terminansicht : Form
    {
        // Die Variable wird gesetzt, wenn die Termindetails angezeigt / ausgeblendet
        // werden sollen
        private bool TermDetailsVisible = false;

        // Zweidimensionales Int-Array anlegen, um die Termin-IDs zu verwalten
        private int[,] termIDs = new int[19,7];
        
        // Hilfsfunktion, um den Wochenstart herauszufinden
        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }

            return dt.AddDays(-1 * diff).Date;
        }

        // Hilfsfunktion, um das Wochenende herauszufinden
        public static DateTime EndOfWeek(DateTime dt, DayOfWeek endOfWeek)
        {
            int diff = endOfWeek - dt.DayOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }

            return dt.AddDays(diff).Date;
        }

        // Zeichnet das Rechteck mit abgerundeten Ecken der Termindetails
        public void DrawRoundRect(Graphics g, Pen p, float x, float y, float width, float height, float radius)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddLine(x + radius, y, x + width - (radius * 2), y); // Line
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90); // Corner
            gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2)); // Line
            gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, radius * 2, 0, 90); // Corner
            gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height); // Line
            gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90); // Corner
            gp.AddLine(x, y + height - (radius * 2), x, y + radius); // Line
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90); // Corner
            gp.CloseFigure();

            g.DrawPath(p, gp);
            gp.Dispose();
        }

        public void TermineAbfragen()
        {
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
                befehl.CommandText = "select * from Termine";

                datenleser = befehl.ExecuteReader();

                // Liefert folgende Spalten zurück:
                // 0 - Termin_ID; 1 - Titel; 2 - Datum; 3 - Uhrzeit; 4 - Beschreibung
                // 5 - Kontakt
                while (datenleser.Read())
                {
                    // Feststellen, ob der Termin in der aktuellen Auswahl angezeigt
                    // werden muss
                    if (datenleser.GetDateTime(2) >= StartOfWeek(WeekPicker.Value, DayOfWeek.Monday) &&
                        datenleser.GetDateTime(2) <= EndOfWeek(WeekPicker.Value, DayOfWeek.Sunday))
                    {
                        // Reihe = Stundenzahl - 1 (weil Index bei 0 beginnt) - 5 (weil die ersten 5
                        //    Stunden des Tages nicht angezeiggt werden
                        int row = Int32.Parse(datenleser.GetDateTime(3).ToString("HH")) - 6;
                        int col = (int)datenleser.GetDateTime(2).DayOfWeek;
                        TerminGridView.Rows[row].Cells[col].Value = datenleser.GetString(1);

                        // Im Hintergrund wird ein zweidimensionales Int-Array mit aufgebaut,
                        //   um die IDs der Termine passend zur Zeile und Spalte der TerminGridView
                        //   zu verwalten
                        termIDs[row, col] = datenleser.GetInt32(0);
                    }
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

        private void InitialisiereTerminGridView()
        {
            // Zeilen initialisieren
            string[] row6 = { "06:00", "", "", "", "", "", "", "" };
            string[] row7 = { "07:00", "", "", "", "", "", "", "" };
            string[] row8 = { "08:00", "", "", "", "", "", "", "" };
            string[] row9 = { "09:00", "", "", "", "", "", "", "" };
            string[] row10 = { "10:00", "", "", "", "", "", "", "" };
            string[] row11 = { "11:00", "", "", "", "", "", "", "" };
            string[] row12 = { "12:00", "", "", "", "", "", "", "" };
            string[] row13 = { "13:00", "", "", "", "", "", "", "" };
            string[] row14 = { "14:00", "", "", "", "", "", "", "" };
            string[] row15 = { "15:00", "", "", "", "", "", "", "" };
            string[] row16 = { "16:00", "", "", "", "", "", "", "" };
            string[] row17 = { "17:00", "", "", "", "", "", "", "" };
            string[] row18 = { "18:00", "", "", "", "", "", "", "" };
            string[] row19 = { "19:00", "", "", "", "", "", "", "" };
            string[] row20 = { "20:00", "", "", "", "", "", "", "" };
            string[] row21 = { "21:00", "", "", "", "", "", "", "" };
            string[] row22 = { "22:00", "", "", "", "", "", "", "" };
            string[] row23 = { "23:00", "", "", "", "", "", "", "" };
            string[] row24 = { "00:00", "", "", "", "", "", "", "" };

            // Zeilen der GridView hinzufügen
            TerminGridView.Rows.Add(row6);
            TerminGridView.Rows.Add(row7);
            TerminGridView.Rows.Add(row8);
            TerminGridView.Rows.Add(row9);
            TerminGridView.Rows.Add(row10);
            TerminGridView.Rows.Add(row11);
            TerminGridView.Rows.Add(row12);
            TerminGridView.Rows.Add(row13);
            TerminGridView.Rows.Add(row14);
            TerminGridView.Rows.Add(row15);
            TerminGridView.Rows.Add(row16);
            TerminGridView.Rows.Add(row17);
            TerminGridView.Rows.Add(row18);
            TerminGridView.Rows.Add(row19);
            TerminGridView.Rows.Add(row20);
            TerminGridView.Rows.Add(row21);
            TerminGridView.Rows.Add(row22);
            TerminGridView.Rows.Add(row23);
            TerminGridView.Rows.Add(row24);
        }

        // Selektiert die Terminbeschreibung zu einer übergebenen
        // Termin-ID
        private string SelectTermBeschreibung(int termID)
        {
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
                befehl.CommandText = "select Beschreibung from Termine where Termin_ID = " + termID;

                datenleser = befehl.ExecuteReader();

                // Liefert folgende Spalten zurück:
                // 0 - Beschreibung
                while (datenleser.Read())
                {
                    return datenleser.GetString(0);
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
            return "";
        }

        public Terminansicht()
        {
            InitializeComponent();

            // Angezeigtes Format des DateTimePickers festlegen
            WeekPicker.Format = DateTimePickerFormat.Custom;
            WeekPicker.CustomFormat = "dd.MM.yyyy";

            // Leere Reihen und Spalten mit Uhrzeiten einfügen
            InitialisiereTerminGridView();

            // Datenbankabfrage ausführen und GridView mit Daten befüllen
            TermineAbfragen();

            // DateTimePicker auf aktuelle Woche initialisieren
            WocheDaten.Text = StartOfWeek(DateTime.Now, DayOfWeek.Monday).ToString("d")
                + " - " + EndOfWeek(DateTime.Now, DayOfWeek.Sunday).ToString("d");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gra = e.Graphics;
            System.Drawing.Pen myPen;
            
            // Zeichnen der Termindetails
            if (TermDetailsVisible == true)
            {
                myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                labelTermDetails.Visible = true;
                labelTitel.Visible = true;
                labelUhrzeit.Visible = true;
                labelDatum.Visible = true;
                labelKontakt.Visible = true;
                labelTextTitel.Visible = true;
                labelTextDatum.Visible = true;
                labelTextKontakt.Visible = true;
                labelTextUhrzeit.Visible = true;
                textBoxTermBeschr.Visible = true;
            }
            // Termindetails sollen wieder ausgeblendet werden
            else
            {
                myPen = new System.Drawing.Pen(Terminansicht.DefaultBackColor);
                labelTermDetails.Visible = false;
                labelTitel.Visible = false;
                labelUhrzeit.Visible = false;
                labelDatum.Visible = false;
                labelKontakt.Visible = false;
                labelTextTitel.Visible = false;
                labelTextDatum.Visible = false;
                labelTextKontakt.Visible = false;
                labelTextUhrzeit.Visible = false;
                textBoxTermBeschr.Visible = false;
            }
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            DrawRoundRect(gra, myPen, 775, 7, 220, 441, 20);
            myPen.Dispose();
            formGraphics.Dispose();
        }
        

        private void WeekPicker_ValueChanged(object sender, EventArgs e)
        {
            // Wochenstart und -ende herausfinden und anzeigen
            WocheDaten.Text = StartOfWeek(WeekPicker.Value, DayOfWeek.Monday).ToString("d")
                + " - " + EndOfWeek(WeekPicker.Value, DayOfWeek.Sunday).ToString("d");

            WeekPicker.Value = StartOfWeek(WeekPicker.Value, DayOfWeek.Monday);

            // GridView leeren
            TerminGridView.Rows.Clear();
            // Termine-ID-Arry leeren
            Array.Clear(termIDs, 0, termIDs.Length);

            // GridView wieder initialisieren
            InitialisiereTerminGridView();

            // Datenbankabfrage ausführen und GridView mit Daten befüllen
            TermineAbfragen();
        }

        private void TerminGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            
            // Anzeige der Termindetails nur für Spalten der Tabelle (nicht Kopfzeile) und
            // nicht für die Uhrzeiten
            if (row >= 0 && col >= 1)
            {
                // Wenn Zelle nicht leer ist, Termindetails anzeigen
                if (TerminGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    // Termindetails füllen
                    string datum = WeekPicker.Value.AddDays(e.ColumnIndex - 1).ToString().Substring(0,10);

                    labelTextUhrzeit.Text = TerminGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    labelTextDatum.Text = datum;
                    labelTextTitel.Text = TerminGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    textBoxTermBeschr.Text = SelectTermBeschreibung(termIDs[e.RowIndex, e.ColumnIndex]);
                    // Termindetails anzeigen
                    TermDetailsVisible = true;
                    this.Invalidate();
                }
            }
        }

        private void TerminGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Termindetails ausblenden
            TermDetailsVisible = false;
            this.Invalidate();
        }

        private void TerminGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Wenn Zelle nicht leer ist und wir uns nicht in der ersten Spalte (Uhrzeiten)
            // befinden, Terminbearbeitung ermöglichen
            if (TerminGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                if (e.ColumnIndex != 0)
                {
                    FormCollection fc = Application.OpenForms;

                    // Prüfen, ob bereits einmal geöffnet, dann nicht nochmal öffnen
                    bool alreadyOpen = false;

                    foreach (Form forms in fc)
                    {
                        if (forms.Text == "Terminbearbeitung")
                        {
                            alreadyOpen = true;
                        }
                    }

                    if (alreadyOpen == false)
                    {
                        // Da Zelle nicht leer Übergabe der Termin-ID zum Anzeigen der Daten in der Maske
                        Form frm = new Terminbearbeitung(termIDs[e.RowIndex, e.ColumnIndex]);
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Die Terminbearbeitung ist bereits geöffnet!");
                        // Form wieder fokussieren
                        foreach (Form forms in fc)
                        {
                            if (forms.Text == "Terminbearbeitung")
                            {
                                forms.Activate();
                            }
                        }
                    }
                }
            }
            else
            {
                FormCollection fc = Application.OpenForms;

                // Prüfen, ob bereits einmal geöffnet, dann nicht nochmal öffnen
                bool alreadyOpen = false;

                foreach (Form forms in fc)
                {
                    if (forms.Text == "Terminbearbeitung")
                    {
                        alreadyOpen = true;
                    }
                }

                if (alreadyOpen == false)
                {
                    // Neuen Termin anlegen
                    DateTime datum = DateTime.Parse(WocheDaten.Text.Substring(0, 10));
                    datum = datum.AddDays(e.ColumnIndex - 1);

                    Form frm = new Terminbearbeitung(datum, DateTime.ParseExact
                        (TerminGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), "HH:mm", System.Globalization.CultureInfo.InvariantCulture));
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Die Terminbearbeitung ist bereits geöffnet!");
                    foreach (Form forms in fc)
                    {
                        // Form wieder fokussieren
                        if (forms.Text == "Terminbearbeitung")
                        {
                            forms.Activate();
                        }
                    }
                }
            }
        }
    }
}
