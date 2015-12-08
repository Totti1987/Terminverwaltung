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
using System.Text.RegularExpressions;

namespace Terminverwaltung
{
    public partial class Kontaktdaten : Form
    {

        string verbindungsstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Temp\\Terminverwaltung.accdb";
        System.Data.OleDb.OleDbConnection dBVerbindung = null;
        System.Data.OleDb.OleDbCommand befehl = null;
        System.Data.OleDb.OleDbDataReader datenleser = null;
        //Kennzeichen ob DB-Verbindung Offen
        bool offen = false;
        //Speichern der Kontakt_iD für Updates
        string kontakt_id;
        //Count Variable für Rückgabe, Ausführung SQL Befehle
        int count = 0;
        //PicturePath / Picture Variablen zum speichern von Bilddaten oder Bildpfad
        string picturePath = "";
        byte[] picture;

        public Kontaktdaten()
        {
            InitializeComponent();
            try
            {
                dBVerbindung = new OleDbConnection(verbindungsstring);
                dBVerbindung.Open();
                offen = true;
                befehl = dBVerbindung.CreateCommand();
                //Übersicht (DataGHridView) anzeigen 
                befehl.CommandText = "select * from Kontakte;";
                datenleser = befehl.ExecuteReader();
                int row = 0;
                while (datenleser.Read())
                {
                    //leere zeile hinzufügen
                    string[] row_init = { "", "", "", "", "" };
                    dataGridViewKontakte.Rows.Add(row_init);
                    //GridView füllen
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
                    if (Zuname.Text != "" && Vorname.Text != "")
                    {
                        dBVerbindung = new OleDbConnection(verbindungsstring);
                        dBVerbindung.Open();
                        offen = true;
                        befehl = dBVerbindung.CreateCommand();
                        //Insert in die Datenbank
                        //Vorab Zeilenbrüche ersetzen 
                        this.Adresse.Text = Regex.Replace(this.Adresse.Text, "\r\n", ", ");
                        befehl.CommandText = "insert into Kontakte (name, vorname, adresse, telefon, email)  values('" + this.Zuname.Text + "', '" + this.Vorname.Text + "','" + this.Adresse.Text + "', '" + this.Telefon.Text + "','" + this.Email.Text + "' );";
                        string get_id = "Select @@Identity";
                        count = befehl.ExecuteNonQuery();
                        befehl.CommandText = get_id;
                        int ID = (int)befehl.ExecuteScalar();
                        kontakt_id = ID.ToString();
                        //Adresse wieder korrekt anzeigen
                        this.Adresse.Text = Regex.Replace(this.Adresse.Text, ", ", Environment.NewLine);
                        //Bild hinzufügen
                        if (picturePath != "")
                        {
                            OleDbCommand cmd = new OleDbCommand("UPDATE Kontakte SET Bild=@BildData where kontakt_id = " + kontakt_id + " ;", dBVerbindung);
                            FileStream myFileStream = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
                            Byte[] myByte = new Byte[myFileStream.Length];
                            myFileStream.Read(myByte, 0, myByte.Length);
                            myFileStream.Close();
                            OleDbParameter prm = new OleDbParameter("@BildData", OleDbType.VarBinary, myByte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, myByte);
                            cmd.Parameters.Add(prm);
                            cmd.ExecuteNonQuery();
                            //Pfad wieder leeren
                            picturePath = "";
                        }
                        //Übersicht neu anzeigen 
                        befehl.CommandText = "select * from Kontakte;";
                        datenleser = befehl.ExecuteReader();
                        int row = 0;
                        //eine neue Zeile hinzufügen
                        string[] row_init = { "", "", "", "", "" };
                        dataGridViewKontakte.Rows.Add(row_init);
                        while (datenleser.Read())
                        {
                            //GridView füllen
                            dataGridViewKontakte.Rows[row].Cells[0].Value = datenleser.GetInt32(0).ToString();
                            dataGridViewKontakte.Rows[row].Cells[1].Value = datenleser.GetString(1);
                            dataGridViewKontakte.Rows[row].Cells[2].Value = datenleser.GetString(2);
                            dataGridViewKontakte.Rows[row].Cells[3].Value = datenleser.GetString(3);
                            dataGridViewKontakte.Rows[row].Cells[4].Value = datenleser.GetString(4);
                            dataGridViewKontakte.Rows[row].Cells[5].Value = datenleser.GetString(5);
                            row = row + 1;
                        }
                        //Bild neu selektieren 
                        //um Bild anzuzeigen und gespeichertes Bild in der 
                        //Variable Picture zu speichern
                        OleDbCommand comd = new OleDbCommand("SELECT Bild FROM Kontakte WHERE kontakt_id = " + kontakt_id + " ;", dBVerbindung);
                        OleDbDataReader myReader = comd.ExecuteReader(CommandBehavior.SequentialAccess);

                        while (myReader.Read())
                        {
                            if (!myReader.IsDBNull(0))
                            {
                                byte[] myByte = (byte[])myReader.GetValue(0);
                                if (myByte.Length != 0)
                                {
                                    //Byte array für Update speichern
                                    picture = myByte;
                                    //Bild anzeigen 
                                    MemoryStream myStream = new MemoryStream(myByte, 0, myByte.Length);
                                    myStream.Write(myByte, 0, myByte.Length);
                                    Bild.Image = Image.FromStream(myStream);
                                }
                                else
                                {
                                    Bild.Image = null;
                                    Array.Clear(picture, 0, picture.Length);
                                    picture.Initialize();
                                }
                            }
                            else
                            {
                                Bild.Image = null;
                                Array.Clear(picture, 0, picture.Length);
                                picture.Initialize();
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Bitte geben Sie einen Vor- und Zunamen ein!");
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
                    if (Zuname.Text != "" && Vorname.Text != "")
                    {
                        dBVerbindung = new OleDbConnection(verbindungsstring);
                        dBVerbindung.Open();
                        offen = true;
                        befehl = dBVerbindung.CreateCommand();
                        //Update des Datenbankeintrags
                        //vorab Zeilenumbrüche ersetzen
                        this.Adresse.Text = Regex.Replace(this.Adresse.Text, "\r\n", ", ");
                        befehl.CommandText = "Update Kontakte set name = '" + this.Zuname.Text + "',vorname = '" + this.Vorname.Text + "', adresse = '" + this.Adresse.Text + "' , telefon = '" + this.Telefon.Text + "', email = '" + this.Email.Text + "', bild= '" + this.Bild.Image + "' where kontakt_id = " + kontakt_id + " ;";
                        count = befehl.ExecuteNonQuery();
                        //Adresse wieder korrekt anzeigen
                        this.Adresse.Text = Regex.Replace(this.Adresse.Text, ", ", Environment.NewLine);
                        //Bild
                        //neues Bild in die Datenbank laden
                        bool addpicture = false;
                        MessageBox.Show("1");
                        if (picturePath != "")
                        {
                            OleDbCommand cmd = new OleDbCommand("UPDATE Kontakte SET Bild=@BildData where kontakt_id = " + kontakt_id + " ;", dBVerbindung);
                            FileStream myFileStream = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
                            Byte[] myByte = new Byte[myFileStream.Length];
                            myFileStream.Read(myByte, 0, myByte.Length);
                            myFileStream.Close();
                            OleDbParameter prm = new OleDbParameter("@BildData", OleDbType.VarBinary, myByte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, myByte);
                            cmd.Parameters.Add(prm);
                            cmd.ExecuteNonQuery();
                            //addpicture Variable auf true setzen,
                            //es wurd ein Bild in die DB geladen
                            addpicture = true;
                            //Pfad wieder leeren
                            picturePath = "";
                        }
                        //vorhandene Bilddaten in die Datenbank laden,
                        //wenn keine neue Bilddatei geladen wurde!
                        if (picture.Length != 0 && !addpicture)
                        {
                            OleDbCommand cmd = new OleDbCommand("UPDATE Kontakte SET Bild=@BildData where kontakt_id = " + kontakt_id + " ;", dBVerbindung);
                            OleDbParameter prm = new OleDbParameter("@BildData", OleDbType.VarBinary, picture.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, picture);
                            cmd.Parameters.Add(prm);
                            cmd.ExecuteNonQuery();
                        }
                        //Übersicht neu anzeigen 
                        befehl.CommandText = "select * from Kontakte;";
                        datenleser = befehl.ExecuteReader();
                        int row = 0;
                        while (datenleser.Read())
                        {
                            //GridView füllen
                            dataGridViewKontakte.Rows[row].Cells[0].Value = datenleser.GetInt32(0).ToString();
                            dataGridViewKontakte.Rows[row].Cells[1].Value = datenleser.GetString(1);
                            dataGridViewKontakte.Rows[row].Cells[2].Value = datenleser.GetString(2);
                            dataGridViewKontakte.Rows[row].Cells[3].Value = datenleser.GetString(3);
                            dataGridViewKontakte.Rows[row].Cells[4].Value = datenleser.GetString(4);
                            dataGridViewKontakte.Rows[row].Cells[5].Value = datenleser.GetString(5);
                            row = row + 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte geben Sie einen Vor- und Zunamen ein!");
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bild konnte nicht geöffnet werden! " + ex.Message);
                }
            }

        }

 
        private void Neu_Click(object sender, EventArgs e)
        {
            //leeren der Kontakt_id, Bilddaten, Pfad und der Eingabefelder + Bild
            //um eine neueingabe zu ermöglichen
            Zuname.Text = null;
            Vorname.Text = null;
            Adresse.Text = null;
            Telefon.Text = null;
            Email.Text = null;
            Bild.Image = null;
            kontakt_id = null;
            picturePath = "";
            Array.Clear(picture, 0, picture.Length);
            picture.Initialize();
        }

        private void dataGridViewKontakte_CellEnter(object sender, DataGridViewCellEventArgs e)
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
                    this.Zuname.Text = datenleser.GetString(1);
                    this.Vorname.Text = datenleser.GetString(2);
                    this.Adresse.Text = datenleser.GetString(3);
                    this.Adresse.Text = Regex.Replace(this.Adresse.Text, ", ", Environment.NewLine);
                    this.Telefon.Text = datenleser.GetString(4);
                    this.Email.Text = datenleser.GetString(5);
                    //Die Daten sind bereits vorhanden daher wird für ein 
                    //eventuelles Update die Kontakt_id gespeichert
                    kontakt_id = datenleser.GetInt32(0).ToString();
                }
                //Bild selektieren 
                OleDbCommand cmd = new OleDbCommand("SELECT Bild FROM Kontakte WHERE kontakt_id = " + kontakt_id + " ;", dBVerbindung);
                OleDbDataReader myReader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);

                while (myReader.Read())
                {
                    if (!myReader.IsDBNull(0))
                    {
                        byte[] myByte = (byte[])myReader.GetValue(0);
                        if (myByte.Length != 0)
                        {
                            //Byte array für Update speichern
                            picture = myByte;
                            //Bild anzeigen 
                            MemoryStream myStream = new MemoryStream(myByte, 0, myByte.Length);
                            myStream.Write(myByte, 0, myByte.Length);
                            Bild.Image = Image.FromStream(myStream);
                        }
                        else
                        {
                            Bild.Image = null;
                            Array.Clear(picture, 0, picture.Length);
                            picture.Initialize();
                        }
                    }
                    else
                    {
                        Bild.Image = null;
                        Array.Clear(picture, 0, picture.Length);
                        picture.Initialize();
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


    }

}