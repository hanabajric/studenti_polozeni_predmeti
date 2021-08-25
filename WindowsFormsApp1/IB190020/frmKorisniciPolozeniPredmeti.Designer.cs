namespace WindowsFormsApp1.IB190020
{
    partial class frmKorisniciPolozeniPredmeti
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
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.dtpDatumVrijeme = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbNepolozeni = new System.Windows.Forms.CheckBox();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnPrintajUvjerenje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(12, 12);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(276, 24);
            this.cmbPredmeti.TabIndex = 0;
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Location = new System.Drawing.Point(306, 12);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(121, 24);
            this.cmbOcjene.TabIndex = 1;
            // 
            // dtpDatumVrijeme
            // 
            this.dtpDatumVrijeme.Location = new System.Drawing.Point(445, 13);
            this.dtpDatumVrijeme.Name = "dtpDatumVrijeme";
            this.dtpDatumVrijeme.Size = new System.Drawing.Size(250, 22);
            this.dtpDatumVrijeme.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(713, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(97, 24);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.Datum});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(12, 70);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.RowHeadersWidth = 51;
            this.dgvPolozeniPredmeti.RowTemplate.Height = 24;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(798, 263);
            this.dgvPolozeniPredmeti.TabIndex = 4;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "DatumPolaganja";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // chbNepolozeni
            // 
            this.chbNepolozeni.AutoSize = true;
            this.chbNepolozeni.Location = new System.Drawing.Point(12, 43);
            this.chbNepolozeni.Name = "chbNepolozeni";
            this.chbNepolozeni.Size = new System.Drawing.Size(143, 21);
            this.chbNepolozeni.TabIndex = 5;
            this.chbNepolozeni.Text = "Učitaj nepoložene";
            this.chbNepolozeni.UseVisualStyleBackColor = true;
            this.chbNepolozeni.CheckedChanged += new System.EventHandler(this.chbNepolozeni_CheckedChanged);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(12, 342);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(143, 24);
            this.btnAsync.TabIndex = 6;
            this.btnAsync.Text = "Run ASYNC";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // btnPrintajUvjerenje
            // 
            this.btnPrintajUvjerenje.Location = new System.Drawing.Point(673, 339);
            this.btnPrintajUvjerenje.Name = "btnPrintajUvjerenje";
            this.btnPrintajUvjerenje.Size = new System.Drawing.Size(137, 24);
            this.btnPrintajUvjerenje.TabIndex = 7;
            this.btnPrintajUvjerenje.Text = "Printaj uvjerenje";
            this.btnPrintajUvjerenje.UseVisualStyleBackColor = true;
            this.btnPrintajUvjerenje.Click += new System.EventHandler(this.btnPrintajUvjerenje_Click);
            // 
            // frmKorisniciPolozeniPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 378);
            this.Controls.Add(this.btnPrintajUvjerenje);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.chbNepolozeni);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpDatumVrijeme);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.cmbPredmeti);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKorisniciPolozeniPredmeti";
            this.Text = "Položeni predmeti korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.DateTimePicker dtpDatumVrijeme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.CheckBox chbNepolozeni;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnPrintajUvjerenje;
    }
}