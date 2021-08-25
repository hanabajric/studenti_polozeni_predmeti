using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.IB190020;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
            UcitajKorisnike();
            IzracunajProsjek(IB190020_Baza.DB.Korisnici.ToList());
        }

        private void UcitajKorisnike(List<IB190020_Korsinik> korisnici = null)
        {
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? IB190020_Baza.DB.Korisnici.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string sadrzaj = txtPretraga.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(sadrzaj))
            {
                List<IB190020_Korsinik> pretrazeni = IB190020_Baza.DB.Korisnici.Where(k => k.Ime.ToLower().Contains(sadrzaj) || k.Prezime.ToLower().Contains(sadrzaj)).ToList();
                UcitajKorisnike(pretrazeni);
                IzracunajProsjek(pretrazeni);
            }
            else
            {
                UcitajKorisnike();
                IzracunajProsjek(IB190020_Baza.DB.Korisnici.ToList());
            }
        }

        private void IzracunajProsjek(List<IB190020_Korsinik> korisnici)
        {
            double prosjek = 0;
            int brojac = 0;
            foreach (IB190020_Korsinik k in korisnici)
            {
                List<IB190020_KorisnikPredmet> polozeni = IB190020_Baza.DB.KorisniciPredmeti.Where(kp => kp.Korisnik.Id == k.Id).ToList();
                if (polozeni.Count != 0 && polozeni != null)
                {
                    foreach(IB190020_KorisnikPredmet kp in polozeni)
                    {
                        prosjek += kp.Ocjena;
                        brojac++;
                    }
                }
            }
            if (brojac != 0)
            {
                prosjek /= brojac;
                lblProsjek.Text = $"Prikazano je {korisnici.Count} korisnika, a njihov prosjek iznosi -> {Math.Round(prosjek, 2)}";
            }
            else
            {
               lblProsjek.Text = $"Prikazano je {korisnici.Count} korisnika, a njihov prosjek iznosi -> nedefinirano";
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IB190020_Korsinik selectedUser = dgvKorisnici.SelectedRows[0].DataBoundItem as IB190020_Korsinik;
            if (selectedUser != null)
            {
                if (e.ColumnIndex == 5)
                {
                    frmKorisniciPolozeniPredmeti frmKorisniciPolozeniPredmeti = new frmKorisniciPolozeniPredmeti(selectedUser);
                    frmKorisniciPolozeniPredmeti.ShowDialog();
                }
            }
        }
    }
}
