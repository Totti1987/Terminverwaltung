namespace Terminverwaltung
{
    partial class Terminverwaltung
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
            this.Kontaktdaten = new System.Windows.Forms.Button();
            this.Terminansicht = new System.Windows.Forms.Button();
            this.Ende = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kontaktdaten
            // 
            this.Kontaktdaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kontaktdaten.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Kontaktdaten.Location = new System.Drawing.Point(31, 35);
            this.Kontaktdaten.Name = "Kontaktdaten";
            this.Kontaktdaten.Size = new System.Drawing.Size(203, 47);
            this.Kontaktdaten.TabIndex = 0;
            this.Kontaktdaten.Text = "Kontaktdaten";
            this.Kontaktdaten.UseVisualStyleBackColor = true;
            this.Kontaktdaten.Click += new System.EventHandler(this.Kontaktdaten_Click);
            // 
            // Terminansicht
            // 
            this.Terminansicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminansicht.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Terminansicht.Location = new System.Drawing.Point(31, 103);
            this.Terminansicht.Name = "Terminansicht";
            this.Terminansicht.Size = new System.Drawing.Size(203, 49);
            this.Terminansicht.TabIndex = 1;
            this.Terminansicht.Text = "Terminansicht";
            this.Terminansicht.UseVisualStyleBackColor = true;
            this.Terminansicht.Click += new System.EventHandler(this.Terminansicht_Click);
            // 
            // Ende
            // 
            this.Ende.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ende.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Ende.Location = new System.Drawing.Point(137, 251);
            this.Ende.Name = "Ende";
            this.Ende.Size = new System.Drawing.Size(97, 49);
            this.Ende.TabIndex = 2;
            this.Ende.Text = "Ende";
            this.Ende.UseVisualStyleBackColor = true;
            this.Ende.Click += new System.EventHandler(this.Ende_Click);
            // 
            // Terminverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 317);
            this.Controls.Add(this.Ende);
            this.Controls.Add(this.Terminansicht);
            this.Controls.Add(this.Kontaktdaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Terminverwaltung";
            this.Text = "Terminverwaltung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Kontaktdaten;
        private System.Windows.Forms.Button Terminansicht;
        private System.Windows.Forms.Button Ende;
    }
}