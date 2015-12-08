<<<<<<< HEAD
﻿namespace Terminverwaltung
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
            this.Zuname = new System.Windows.Forms.TextBox();
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
            this.Speichern = new System.Windows.Forms.Button();
            this.dataGridViewKontakte = new System.Windows.Forms.DataGridView();
            this.Neu = new System.Windows.Forms.Button();
            this.KontaktID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_COl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Bild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).BeginInit();
            this.SuspendLayout();
            // 
            // Zuname
            // 
            this.Zuname.Location = new System.Drawing.Point(102, 246);
            this.Zuname.Name = "Zuname";
            this.Zuname.Size = new System.Drawing.Size(176, 20);
            this.Zuname.TabIndex = 0;
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
            this.Bild.Size = new System.Drawing.Size(118, 158);
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
            // Speichern
            // 
            this.Speichern.Location = new System.Drawing.Point(349, 484);
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(131, 31);
            this.Speichern.TabIndex = 13;
            this.Speichern.Text = "Speichern";
            this.Speichern.UseVisualStyleBackColor = true;
            this.Speichern.Click += new System.EventHandler(this.Speichern_Click);
            // 
            // dataGridViewKontakte
            // 
            this.dataGridViewKontakte.AllowUserToAddRows = false;
            this.dataGridViewKontakte.AllowUserToDeleteRows = false;
            this.dataGridViewKontakte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontakte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KontaktID,
            this.Name_Col,
            this.Vorname_Col,
            this.Adresse_Col,
            this.Telefon_Col,
            this.EMAIL_COl});
            this.dataGridViewKontakte.Location = new System.Drawing.Point(26, 12);
            this.dataGridViewKontakte.Name = "dataGridViewKontakte";
            this.dataGridViewKontakte.ReadOnly = true;
            this.dataGridViewKontakte.RowHeadersVisible = false;
            this.dataGridViewKontakte.Size = new System.Drawing.Size(766, 208);
            this.dataGridViewKontakte.TabIndex = 14;
            this.dataGridViewKontakte.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKontakte_CellEnter);
            // 
            // Neu
            // 
            this.Neu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Neu.Location = new System.Drawing.Point(268, 484);
            this.Neu.Name = "Neu";
            this.Neu.Size = new System.Drawing.Size(75, 31);
            this.Neu.TabIndex = 15;
            this.Neu.Text = "Neu";
            this.Neu.UseVisualStyleBackColor = true;
            this.Neu.Click += new System.EventHandler(this.Neu_Click);
            // 
            // KontaktID
            // 
            this.KontaktID.HeaderText = "Kontakt ID";
            this.KontaktID.Name = "KontaktID";
            this.KontaktID.ReadOnly = true;
            this.KontaktID.Width = 90;
            // 
            // Name_Col
            // 
            this.Name_Col.HeaderText = "Name";
            this.Name_Col.Name = "Name_Col";
            this.Name_Col.ReadOnly = true;
            this.Name_Col.Width = 120;
            // 
            // Vorname_Col
            // 
            this.Vorname_Col.HeaderText = "Vorname";
            this.Vorname_Col.Name = "Vorname_Col";
            this.Vorname_Col.ReadOnly = true;
            this.Vorname_Col.Width = 120;
            // 
            // Adresse_Col
            // 
            this.Adresse_Col.HeaderText = "Adresse";
            this.Adresse_Col.Name = "Adresse_Col";
            this.Adresse_Col.ReadOnly = true;
            this.Adresse_Col.Width = 180;
            // 
            // Telefon_Col
            // 
            this.Telefon_Col.HeaderText = "Telefon";
            this.Telefon_Col.Name = "Telefon_Col";
            this.Telefon_Col.ReadOnly = true;
            this.Telefon_Col.Width = 110;
            // 
            // EMAIL_COl
            // 
            this.EMAIL_COl.HeaderText = "E-Mail";
            this.EMAIL_COl.Name = "EMAIL_COl";
            this.EMAIL_COl.ReadOnly = true;
            this.EMAIL_COl.Width = 140;
            // 
            // Kontaktdaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.Neu);
            this.Controls.Add(this.dataGridViewKontakte);
            this.Controls.Add(this.Speichern);
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
            this.Controls.Add(this.Zuname);
            this.Name = "Kontaktdaten";
            this.Text = "Kontaktdaten";
            ((System.ComponentModel.ISupportInitialize)(this.Bild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Zuname;
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
        private System.Windows.Forms.Button Speichern;
        private System.Windows.Forms.DataGridView dataGridViewKontakte;
        private System.Windows.Forms.Button Neu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_COl;
    }
=======
﻿namespace Terminverwaltung
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
            this.Speichern = new System.Windows.Forms.Button();
            this.dataGridViewKontakte = new System.Windows.Forms.DataGridView();
            this.KontaktID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_COl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Bild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).BeginInit();
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
            this.Bild.Size = new System.Drawing.Size(118, 158);
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
            // dataGridViewKontakte
            // 
            this.dataGridViewKontakte.AllowUserToAddRows = false;
            this.dataGridViewKontakte.AllowUserToDeleteRows = false;
            this.dataGridViewKontakte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontakte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KontaktID,
            this.Name_Col,
            this.Vorname_Col,
            this.Adresse_Col,
            this.Telefon_Col,
            this.EMAIL_COl});
            this.dataGridViewKontakte.Location = new System.Drawing.Point(37, 12);
            this.dataGridViewKontakte.Name = "dataGridViewKontakte";
            this.dataGridViewKontakte.ReadOnly = true;
            this.dataGridViewKontakte.RowHeadersVisible = false;
            this.dataGridViewKontakte.Size = new System.Drawing.Size(713, 178);
            this.dataGridViewKontakte.TabIndex = 14;
            this.dataGridViewKontakte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKontakte_CellContentClick);
            // 
            // KontaktID
            // 
            this.KontaktID.HeaderText = "Kontakt ID";
            this.KontaktID.Name = "KontaktID";
            this.KontaktID.ReadOnly = true;
            this.KontaktID.Width = 90;
            // 
            // Name_Col
            // 
            this.Name_Col.HeaderText = "Name";
            this.Name_Col.Name = "Name_Col";
            this.Name_Col.ReadOnly = true;
            this.Name_Col.Width = 120;
            // 
            // Vorname_Col
            // 
            this.Vorname_Col.HeaderText = "Vorname";
            this.Vorname_Col.Name = "Vorname_Col";
            this.Vorname_Col.ReadOnly = true;
            this.Vorname_Col.Width = 120;
            // 
            // Adresse_Col
            // 
            this.Adresse_Col.HeaderText = "Adresse";
            this.Adresse_Col.Name = "Adresse_Col";
            this.Adresse_Col.ReadOnly = true;
            this.Adresse_Col.Width = 150;
            // 
            // Telefon_Col
            // 
            this.Telefon_Col.HeaderText = "Telefon";
            this.Telefon_Col.Name = "Telefon_Col";
            this.Telefon_Col.ReadOnly = true;
            this.Telefon_Col.Width = 110;
            // 
            // EMAIL_COl
            // 
            this.EMAIL_COl.HeaderText = "E-Mail";
            this.EMAIL_COl.Name = "EMAIL_COl";
            this.EMAIL_COl.ReadOnly = true;
            this.EMAIL_COl.Width = 120;
            // 
            // Kontaktdaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.dataGridViewKontakte);
            this.Controls.Add(this.Speichern);
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
            this.Text = "Kontaktdaten";
            ((System.ComponentModel.ISupportInitialize)(this.Bild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).EndInit();
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
        private System.Windows.Forms.Button Speichern;
        private System.Windows.Forms.DataGridView dataGridViewKontakte;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_COl;
    }
>>>>>>> origin/master
}