namespace Terminverwaltung
{
    partial class Kontaktdaten
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Name = new System.Windows.Forms.TextBox();
            this.Vorname = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Bild = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Vorname = new System.Windows.Forms.Label();
            this.label_Adresse = new System.Windows.Forms.Label();
            this.label_Telefon = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Bild = new System.Windows.Forms.Label();
            this.dataGridViewKontakte = new System.Windows.Forms.DataGridView();
            this.kontaktidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontakteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.terminverwaltungDataSet = new CTerminverwaltung.TerminverwaltungDataSet();
            //this.kontakteTableAdapter = new CTerminverwaltung.TerminverwaltungDataSetTableAdapters.KontakteTableAdapter();
            this.Speichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.terminverwaltungDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(102, 246);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(176, 20);
            this.Name.TabIndex = 0;
            // 
            // Vorname
            // 
            this.Vorname.Location = new System.Drawing.Point(102, 275);
            this.Vorname.Name = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(176, 20);
            this.Vorname.TabIndex = 1;
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(102, 305);
            this.Adresse.Multiline = true;
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(176, 137);
            this.Adresse.TabIndex = 2;
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(476, 246);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(176, 20);
            this.Telefon.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(476, 275);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(176, 20);
            this.Email.TabIndex = 4;
            // 
            // Bild
            // 
            this.Bild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bild.Location = new System.Drawing.Point(476, 305);
            this.Bild.Name = "Bild";
            this.Bild.Size = new System.Drawing.Size(216, 137);
            this.Bild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bild.TabIndex = 5;
            this.Bild.TabStop = false;
            this.Bild.Click += new System.EventHandler(this.Bild_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(34, 252);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(45, 16);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Name";
            // 
            // label_Vorname
            // 
            this.label_Vorname.AutoSize = true;
            this.label_Vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Vorname.Location = new System.Drawing.Point(34, 278);
            this.label_Vorname.Name = "label_Vorname";
            this.label_Vorname.Size = new System.Drawing.Size(63, 16);
            this.label_Vorname.TabIndex = 7;
            this.label_Vorname.Text = "Vorname";
            // 
            // label_Adresse
            // 
            this.label_Adresse.AutoSize = true;
            this.label_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Adresse.Location = new System.Drawing.Point(34, 305);
            this.label_Adresse.Name = "label_Adresse";
            this.label_Adresse.Size = new System.Drawing.Size(59, 16);
            this.label_Adresse.TabIndex = 8;
            this.label_Adresse.Text = "Adresse";
            // 
            // label_Telefon
            // 
            this.label_Telefon.AutoSize = true;
            this.label_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Telefon.Location = new System.Drawing.Point(416, 246);
            this.label_Telefon.Name = "label_Telefon";
            this.label_Telefon.Size = new System.Drawing.Size(54, 16);
            this.label_Telefon.TabIndex = 9;
            this.label_Telefon.Text = "Telefon";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(416, 275);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(46, 16);
            this.label_Email.TabIndex = 10;
            this.label_Email.Text = "E-Mail";
            // 
            // label_Bild
            // 
            this.label_Bild.AutoSize = true;
            this.label_Bild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bild.Location = new System.Drawing.Point(416, 306);
            this.label_Bild.Name = "label_Bild";
            this.label_Bild.Size = new System.Drawing.Size(31, 16);
            this.label_Bild.TabIndex = 11;
            this.label_Bild.Text = "Bild";
            // 
            // dataGridViewKontakte
            // 
            this.dataGridViewKontakte.AllowUserToAddRows = false;
            this.dataGridViewKontakte.AllowUserToDeleteRows = false;
            this.dataGridViewKontakte.AutoGenerateColumns = false;
            this.dataGridViewKontakte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontakte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kontaktidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bildDataGridViewTextBoxColumn});
            this.dataGridViewKontakte.DataSource = this.kontakteBindingSource;
            this.dataGridViewKontakte.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewKontakte.Name = "dataGridViewKontakte";
            this.dataGridViewKontakte.ReadOnly = true;
            this.dataGridViewKontakte.RowHeadersVisible = false;
            this.dataGridViewKontakte.Size = new System.Drawing.Size(758, 191);
            this.dataGridViewKontakte.TabIndex = 12;
            this.dataGridViewKontakte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // kontaktidDataGridViewTextBoxColumn
            // 
            this.kontaktidDataGridViewTextBoxColumn.DataPropertyName = "Kontakt_id";
            this.kontaktidDataGridViewTextBoxColumn.HeaderText = "Kontakt_id";
            this.kontaktidDataGridViewTextBoxColumn.Name = "kontaktidDataGridViewTextBoxColumn";
            this.kontaktidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // bildDataGridViewTextBoxColumn
            // 
            this.bildDataGridViewTextBoxColumn.DataPropertyName = "Bild";
            this.bildDataGridViewTextBoxColumn.HeaderText = "Bild";
            this.bildDataGridViewTextBoxColumn.Name = "bildDataGridViewTextBoxColumn";
            this.bildDataGridViewTextBoxColumn.ReadOnly = true;
            this.bildDataGridViewTextBoxColumn.Width = 5;
            // 
            // kontakteBindingSource
            // 
            this.kontakteBindingSource.DataMember = "Kontakte";
            //this.kontakteBindingSource.DataSource = this.terminverwaltungDataSet;
            // 
            // terminverwaltungDataSet
            // 
            //this.terminverwaltungDataSet.DataSetName = "TerminverwaltungDataSet";
            //this.terminverwaltungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontakteTableAdapter
            // 
            //this.kontakteTableAdapter.ClearBeforeFill = true;
            // 
            // Speichern
            // 
            this.Speichern.Location = new System.Drawing.Point(316, 462);
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(131, 31);
            this.Speichern.TabIndex = 13;
            this.Speichern.Text = "Speichern";
            this.Speichern.UseVisualStyleBackColor = true;
            this.Speichern.Click += new System.EventHandler(this.Speichern_Click);
            // 
            // Kontaktdaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.Speichern);
            this.Controls.Add(this.dataGridViewKontakte);
            this.Controls.Add(this.label_Bild);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Telefon);
            this.Controls.Add(this.label_Adresse);
            this.Controls.Add(this.label_Vorname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.Bild);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Vorname);
            this.Controls.Add(this.Name);
            // this.Name = "Kontaktdaten";
            this.Text = "Kontaktdaten";
            this.Load += new System.EventHandler(this.Kontaktdaten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.terminverwaltungDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Vorname;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.PictureBox Bild;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Vorname;
        private System.Windows.Forms.Label label_Adresse;
        private System.Windows.Forms.Label label_Telefon;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Bild;
        private System.Windows.Forms.DataGridView dataGridViewKontakte;
        //private TerminverwaltungDataSet terminverwaltungDataSet;
        private System.Windows.Forms.BindingSource kontakteBindingSource;
        //private TerminverwaltungDataSetTableAdapters.KontakteTableAdapter kontakteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bildDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Speichern;
    }
}