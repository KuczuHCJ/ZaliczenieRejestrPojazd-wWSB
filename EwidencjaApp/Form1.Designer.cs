namespace EwidencjaApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.txtNrRej = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtWlasciciel = new System.Windows.Forms.TextBox();
            this.numRok = new System.Windows.Forms.NumericUpDown();
            this.dtpPrzeglad = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnRaport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPojazdy
            // 
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Location = new System.Drawing.Point(12, 288);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.RowHeadersWidth = 51;
            this.dgvPojazdy.RowTemplate.Height = 24;
            this.dgvPojazdy.Size = new System.Drawing.Size(776, 150);
            this.dgvPojazdy.TabIndex = 0;
            // 
            // txtNrRej
            // 
            this.txtNrRej.Location = new System.Drawing.Point(30, 27);
            this.txtNrRej.Name = "txtNrRej";
            this.txtNrRej.Size = new System.Drawing.Size(100, 22);
            this.txtNrRej.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(30, 71);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(30, 122);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 3;
            // 
            // txtWlasciciel
            // 
            this.txtWlasciciel.Location = new System.Drawing.Point(30, 184);
            this.txtWlasciciel.Name = "txtWlasciciel";
            this.txtWlasciciel.Size = new System.Drawing.Size(100, 22);
            this.txtWlasciciel.TabIndex = 4;
            // 
            // numRok
            // 
            this.numRok.Location = new System.Drawing.Point(642, 28);
            this.numRok.Name = "numRok";
            this.numRok.Size = new System.Drawing.Size(120, 22);
            this.numRok.TabIndex = 5;
            // 
            // dtpPrzeglad
            // 
            this.dtpPrzeglad.Location = new System.Drawing.Point(562, 71);
            this.dtpPrzeglad.Name = "dtpPrzeglad";
            this.dtpPrzeglad.Size = new System.Drawing.Size(200, 22);
            this.dtpPrzeglad.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(699, 243);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(605, 243);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(75, 23);
            this.btnRaport.TabIndex = 8;
            this.btnRaport.Text = "Generuj Raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpPrzeglad);
            this.Controls.Add(this.numRok);
            this.Controls.Add(this.txtWlasciciel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtNrRej);
            this.Controls.Add(this.dgvPojazdy);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPojazdy;
        private System.Windows.Forms.TextBox txtNrRej;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtWlasciciel;
        private System.Windows.Forms.NumericUpDown numRok;
        private System.Windows.Forms.DateTimePicker dtpPrzeglad;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnRaport;
    }
}