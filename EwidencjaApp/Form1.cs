using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EwidencjaApp
{
    public partial class Form1 : Form
    {
        List<Pojazd> baza = new List<Pojazd>();

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            dgvPojazdy.AutoGenerateColumns = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Pojazd auto = new Pojazd();
                auto.NrRejestracyjny = txtNrRej.Text;
                auto.Marka = txtMarka.Text;
                auto.Model = txtModel.Text;
                auto.RokProdukcji = (int)numRok.Value;
                auto.DataPrzegladu = dtpPrzeglad.Value;
                auto.Wlasciciel = txtWlasciciel.Text;

                baza.Add(auto);
                odswiez();

                
                txtNrRej.Text = "";
                txtMarka.Text = "";
                txtModel.Text = "";
                txtWlasciciel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void odswiez()
        {
            dgvPojazdy.DataSource = null;
            dgvPojazdy.DataSource = baza;
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;

            
            var temp = baza.Where(x =>
                x.DataPrzegladu.Month == d.Month &&
                x.DataPrzegladu.Year == d.Year
            ).ToList();

            if (temp.Count == 0)
            {
                MessageBox.Show("Brak aut z przeglądem w tym miesiącu.");
                return;
            }

            Form f = new Form();
            f.Text = "Podgląd Raportu";
            f.Size = new System.Drawing.Size(800, 600);

            ReportViewer rv = new ReportViewer();
            rv.Dock = DockStyle.Fill;

            
            rv.LocalReport.ReportPath = "Raport.rdlc";
            rv.LocalReport.DataSources.Clear();

            
            rv.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", temp));

            f.Controls.Add(rv);
            rv.RefreshReport();
            f.ShowDialog();
        }
    }
}