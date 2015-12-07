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
        System.Data.OleDb.OleDbConnection dBVerbindung = null;
        System.Data.OleDb.OleDbCommand befehl = null;
        System.Data.OleDb.OleDbDataReader datenleser = null;
        bool offen = false;
        string kontakt_id;
        int count = 0;
        string picturePath = "";

        public Kontaktdaten()
        {
            InitializeComponent();
            try
            {
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                offen = true;
                befehl = dBVerbindung.CreateCommand();
                //Übersicht neu anzeigen 
                befehl.CommandText = "select * from Kontakte;";
                datenleser = befehl.ExecuteReader();
                int row = 0;
                while (datenleser.Read())
                {
                    string[] row_init = { "", "", "", "", "" };
                    dataGridViewKontakte.Rows.Add(row_init);
                    dataGridViewKontakte.Rows[row].Cells[0].Value = datenleser.GetInt32(0).ToString();
                    dataGridViewKontakte.Rows[row].Cells[1].Value = datenleser.GetString(1);
                    dataGridViewKontakte.Rows[row].Cells[2].Value = datenleser.GetString(2);
                    dataGridViewKontakte.Rows[row].Cells[3].Value = datenleser.GetString(3);
                    dataGridViewKontakte.Rows[row].Cells[4].Value = datenleser.GetString(4);
                    dataGridViewKontakte.Rows[row].Cells[5].Value = datenleser.GetString(5);
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
                    //Insert in die Datenbank
                    befehl.CommandText = "insert into Kontakte (name, vorname, adresse, telefon, email)  values('" + this.Name.Text + "', '" + this.Vorname.Text + "', '" + this.Adresse.Text + "', '" + this.Telefon.Text + "','" + this.Email.Text + "' );";
                    count = befehl.ExecuteNonQuery();
                    //Übersicht neu anzeigen 
                    befehl.CommandText = "select * from Kontakte;";
                    datenleser = befehl.ExecuteReader();
                    int row = 0;
                    while (datenleser.Read())
                    {
                        string[] row_init = { "", "", "", "", "" };
                        dataGridViewKontakte.Rows.Add(row_init);
                        dataGridViewKontakte.Rows[row].Cells[0].Value = datenleser.GetInt32(0).ToString();
                        dataGridViewKontakte.Rows[row].Cells[1].Value = datenleser.GetString(1);
                        dataGridViewKontakte.Rows[row].Cells[2].Value = datenleser.GetString(2);
                        dataGridViewKontakte.Rows[row].Cells[3].Value = datenleser.GetString(3);
                        dataGridViewKontakte.Rows[row].Cells[4].Value = datenleser.GetString(4);
                        dataGridViewKontakte.Rows[row].Cells[5].Value = datenleser.GetString(5);
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
                    //Update des Datenbankeintrags
                    befehl.CommandText = "Update Kontakte set name = '" + this.Name.Text + "',vorname = '" + this.Vorname.Text + "', adresse = '" + this.Adresse.Text + "' , telefon = '" + this.Telefon.Text + "', email = '" + this.Email.Text + "', bild= '" + this.Bild.Image + "' where kontakt_id = " + kontakt_id + " ;";
                    count = befehl.ExecuteNonQuery();
                    //Bild 
//
//http://www.mycsharp.de/wbb2/thread.php?threadid=93730
                    OleDbCommand cmd = new OleDbCommand("UPDATE Kontakte SET Bild=@BildData where kontakt_id = " + kontakt_id + " ;", dBVerbindung);
                    FileStream myFileStream = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
                    Byte[] myByte = new Byte[myFileStream.Length];
                    myFileStream.Read(myByte, 0, myByte.Length);
                    myFileStream.Close();

                    OleDbParameter prm = new OleDbParameter("@BildData", OleDbType.VarBinary, myByte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, myByte);
                    cmd.Parameters.Add(prm);
                    cmd.ExecuteNonQuery();

                    //Übersicht neu anzeigen 
                    befehl.CommandText = "select * from Kontakte;";
                    datenleser = befehl.ExecuteReader();
                    int row = 0;
                    while (datenleser.Read())
                    {   
                        dataGridViewKontakte.Rows[row].Cells[0].Value = datenleser.GetInt32(0).ToString();
                        dataGridViewKontakte.Rows[row].Cells[1].Value = datenleser.GetString(1);
                        dataGridViewKontakte.Rows[row].Cells[2].Value = datenleser.GetString(2);
                        dataGridViewKontakte.Rows[row].Cells[3].Value = datenleser.GetString(3);
                        dataGridViewKontakte.Rows[row].Cells[4].Value = datenleser.GetString(4);
                        dataGridViewKontakte.Rows[row].Cells[5].Value = datenleser.GetString(5);
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
            openBild.Filter = "png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|tif files (*.tif)|*.tif|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg";
            openBild.FilterIndex = 4;
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
                    //Pfad des Bildes merken um Bild in die Datenbank zu speichern 
                    picturePath = fileName;

                    // Neues Vorgabeverzeichnis fürs Öffnen
                    openBild.InitialDirectory = System.IO.Path.GetDirectoryName(fileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bild konnte nicht geöffnet werden! " + ex.Message);
                }
            }

        }

        private void dataGridViewKontakte_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

    }

}