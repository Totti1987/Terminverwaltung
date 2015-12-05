namespace Terminverwaltung
{
    partial class Terminansicht
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TerminLabel = new System.Windows.Forms.Label();
            this.WocheDaten = new System.Windows.Forms.Label();
            this.TerminGridView = new System.Windows.Forms.DataGridView();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mittwoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donnerstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freitag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Samstag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonntag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekPicker = new System.Windows.Forms.DateTimePicker();
            this.labelTermDetails = new System.Windows.Forms.Label();
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelUhrzeit = new System.Windows.Forms.Label();
            this.labelKontakt = new System.Windows.Forms.Label();
            this.textBoxTermBeschr = new System.Windows.Forms.TextBox();
            this.labelTextTitel = new System.Windows.Forms.Label();
            this.labelTextDatum = new System.Windows.Forms.Label();
            this.labelTextUhrzeit = new System.Windows.Forms.Label();
            this.labelTextKontakt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TerminGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TerminLabel
            // 
            this.TerminLabel.AutoSize = true;
            this.TerminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminLabel.Location = new System.Drawing.Point(121, 585);
            this.TerminLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TerminLabel.Name = "TerminLabel";
            this.TerminLabel.Size = new System.Drawing.Size(281, 18);
            this.TerminLabel.TabIndex = 0;
            this.TerminLabel.Text = "Terminübersicht für die Woche vom:";
            // 
            // WocheDaten
            // 
            this.WocheDaten.AutoSize = true;
            this.WocheDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WocheDaten.Location = new System.Drawing.Point(445, 585);
            this.WocheDaten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WocheDaten.Name = "WocheDaten";
            this.WocheDaten.Size = new System.Drawing.Size(52, 18);
            this.WocheDaten.TabIndex = 2;
            this.WocheDaten.Text = "Daten";
            // 
            // TerminGridView
            // 
            this.TerminGridView.AllowUserToAddRows = false;
            this.TerminGridView.AllowUserToDeleteRows = false;
            this.TerminGridView.AllowUserToResizeColumns = false;
            this.TerminGridView.AllowUserToResizeRows = false;
            this.TerminGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TerminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TerminGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit,
            this.Montag,
            this.Dienstag,
            this.Mittwoch,
            this.Donnerstag,
            this.Freitag,
            this.Samstag,
            this.Sonntag});
            this.TerminGridView.Location = new System.Drawing.Point(9, 9);
            this.TerminGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TerminGridView.Name = "TerminGridView";
            this.TerminGridView.RowHeadersVisible = false;
            this.TerminGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TerminGridView.Size = new System.Drawing.Size(996, 543);
            this.TerminGridView.TabIndex = 4;
            this.TerminGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TerminGridView_CellClick);
            this.TerminGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TerminGridView_CellMouseEnter);
            this.TerminGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.TerminGridView_CellMouseLeave);
            // 
            // Zeit
            // 
            this.Zeit.Frozen = true;
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.Name = "Zeit";
            this.Zeit.Width = 50;
            // 
            // Montag
            // 
            this.Montag.Frozen = true;
            this.Montag.HeaderText = "Montag";
            this.Montag.Name = "Montag";
            // 
            // Dienstag
            // 
            this.Dienstag.Frozen = true;
            this.Dienstag.HeaderText = "Dienstag";
            this.Dienstag.Name = "Dienstag";
            // 
            // Mittwoch
            // 
            this.Mittwoch.Frozen = true;
            this.Mittwoch.HeaderText = "Mittwoch";
            this.Mittwoch.Name = "Mittwoch";
            // 
            // Donnerstag
            // 
            this.Donnerstag.Frozen = true;
            this.Donnerstag.HeaderText = "Donnerstag";
            this.Donnerstag.Name = "Donnerstag";
            // 
            // Freitag
            // 
            this.Freitag.Frozen = true;
            this.Freitag.HeaderText = "Freitag";
            this.Freitag.Name = "Freitag";
            // 
            // Samstag
            // 
            this.Samstag.Frozen = true;
            this.Samstag.HeaderText = "Samstag";
            this.Samstag.Name = "Samstag";
            // 
            // Sonntag
            // 
            this.Sonntag.Frozen = true;
            this.Sonntag.HeaderText = "Sonntag";
            this.Sonntag.Name = "Sonntag";
            // 
            // WeekPicker
            // 
            this.WeekPicker.CustomFormat = "dd.mm.yyyy";
            this.WeekPicker.Location = new System.Drawing.Point(843, 578);
            this.WeekPicker.Margin = new System.Windows.Forms.Padding(4);
            this.WeekPicker.Name = "WeekPicker";
            this.WeekPicker.Size = new System.Drawing.Size(161, 22);
            this.WeekPicker.TabIndex = 5;
            this.WeekPicker.ValueChanged += new System.EventHandler(this.WeekPicker_ValueChanged);
            // 
            // labelTermDetails
            // 
            this.labelTermDetails.AutoSize = true;
            this.labelTermDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTermDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTermDetails.Location = new System.Drawing.Point(1109, 26);
            this.labelTermDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTermDetails.Name = "labelTermDetails";
            this.labelTermDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTermDetails.Size = new System.Drawing.Size(136, 24);
            this.labelTermDetails.TabIndex = 6;
            this.labelTermDetails.Text = "Termindetails";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(1063, 85);
            this.labelTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(45, 17);
            this.labelTitel.TabIndex = 7;
            this.labelTitel.Text = "Titel:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(1063, 116);
            this.labelDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(59, 17);
            this.labelDatum.TabIndex = 8;
            this.labelDatum.Text = "Datum:";
            // 
            // labelUhrzeit
            // 
            this.labelUhrzeit.AutoSize = true;
            this.labelUhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUhrzeit.Location = new System.Drawing.Point(1063, 146);
            this.labelUhrzeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUhrzeit.Name = "labelUhrzeit";
            this.labelUhrzeit.Size = new System.Drawing.Size(65, 17);
            this.labelUhrzeit.TabIndex = 9;
            this.labelUhrzeit.Text = "Uhrzeit:";
            // 
            // labelKontakt
            // 
            this.labelKontakt.AutoSize = true;
            this.labelKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKontakt.Location = new System.Drawing.Point(1063, 208);
            this.labelKontakt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKontakt.Name = "labelKontakt";
            this.labelKontakt.Size = new System.Drawing.Size(68, 17);
            this.labelKontakt.TabIndex = 10;
            this.labelKontakt.Text = "Kontakt:";
            // 
            // textBoxTermBeschr
            // 
            this.textBoxTermBeschr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTermBeschr.Enabled = false;
            this.textBoxTermBeschr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTermBeschr.Location = new System.Drawing.Point(1067, 257);
            this.textBoxTermBeschr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTermBeschr.Multiline = true;
            this.textBoxTermBeschr.Name = "textBoxTermBeschr";
            this.textBoxTermBeschr.ReadOnly = true;
            this.textBoxTermBeschr.Size = new System.Drawing.Size(230, 268);
            this.textBoxTermBeschr.TabIndex = 11;
            // 
            // labelTextTitel
            // 
            this.labelTextTitel.AutoSize = true;
            this.labelTextTitel.Location = new System.Drawing.Point(1176, 85);
            this.labelTextTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextTitel.Name = "labelTextTitel";
            this.labelTextTitel.Size = new System.Drawing.Size(46, 17);
            this.labelTextTitel.TabIndex = 12;
            this.labelTextTitel.Text = "label1";
            // 
            // labelTextDatum
            // 
            this.labelTextDatum.AutoSize = true;
            this.labelTextDatum.Location = new System.Drawing.Point(1176, 116);
            this.labelTextDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextDatum.Name = "labelTextDatum";
            this.labelTextDatum.Size = new System.Drawing.Size(46, 17);
            this.labelTextDatum.TabIndex = 13;
            this.labelTextDatum.Text = "label1";
            // 
            // labelTextUhrzeit
            // 
            this.labelTextUhrzeit.AutoSize = true;
            this.labelTextUhrzeit.Location = new System.Drawing.Point(1176, 146);
            this.labelTextUhrzeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextUhrzeit.Name = "labelTextUhrzeit";
            this.labelTextUhrzeit.Size = new System.Drawing.Size(46, 17);
            this.labelTextUhrzeit.TabIndex = 14;
            this.labelTextUhrzeit.Text = "label1";
            // 
            // labelTextKontakt
            // 
            this.labelTextKontakt.AutoSize = true;
            this.labelTextKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextKontakt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTextKontakt.Location = new System.Drawing.Point(1176, 208);
            this.labelTextKontakt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextKontakt.Name = "labelTextKontakt";
            this.labelTextKontakt.Size = new System.Drawing.Size(52, 17);
            this.labelTextKontakt.TabIndex = 15;
            this.labelTextKontakt.Text = "label1";
            // 
            // Terminansicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 623);
            this.Controls.Add(this.labelTextKontakt);
            this.Controls.Add(this.labelTextUhrzeit);
            this.Controls.Add(this.labelTextDatum);
            this.Controls.Add(this.labelTextTitel);
            this.Controls.Add(this.textBoxTermBeschr);
            this.Controls.Add(this.labelKontakt);
            this.Controls.Add(this.labelUhrzeit);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.labelTermDetails);
            this.Controls.Add(this.WeekPicker);
            this.Controls.Add(this.TerminGridView);
            this.Controls.Add(this.WocheDaten);
            this.Controls.Add(this.TerminLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Terminansicht";
            this.Text = "Terminansicht";
            ((System.ComponentModel.ISupportInitialize)(this.TerminGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TerminLabel;
        private System.Windows.Forms.Label WocheDaten;
        private System.Windows.Forms.DataGridView TerminGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mittwoch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donnerstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freitag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Samstag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonntag;
        private System.Windows.Forms.DateTimePicker WeekPicker;
        private System.Windows.Forms.Label labelTermDetails;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelUhrzeit;
        private System.Windows.Forms.Label labelKontakt;
        private System.Windows.Forms.TextBox textBoxTermBeschr;
        private System.Windows.Forms.Label labelTextTitel;
        private System.Windows.Forms.Label labelTextDatum;
        private System.Windows.Forms.Label labelTextUhrzeit;
        private System.Windows.Forms.Label labelTextKontakt;
    }
}

