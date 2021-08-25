using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.IB190020
{
    public partial class frmKorisniciPolozeniPredmeti : Form
    {
        IB190020_Korsinik korisnik;
        public frmKorisniciPolozeniPredmeti(IB190020_Korsinik korisnik)
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            this.korisnik = korisnik;
            UcitajPredmete();
            UcitajOcjene();
            UcitajPolozenePredmete();
        }

        private void UcitajPolozenePredmete()
        {
            try
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = IB190020_Baza.DB.KorisniciPredmeti.Where(kp => kp.Korisnik.Id == korisnik.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void UcitajOcjene()
        {
            cmbOcjene.DataSource = null;
            cmbOcjene.DataSource = new List<int> { 6, 7, 8, 9, 10 };
        }

        private void UcitajPredmete()
        {
            try
            {
                cmbPredmeti.DataSource = null;
                cmbPredmeti.DataSource = IB190020_Baza.DB.Predmeti.ToList();
                cmbPredmeti.ValueMember = "Id";
                cmbPredmeti.DisplayMember = "Naziv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            IB190020_KorisnikPredmet noviPolozeni = new IB190020_KorisnikPredmet()
            {
                Korisnik = korisnik,
                Predmet = cmbPredmeti.SelectedItem as IB190020_Predmet,
                Ocjena = int.Parse(cmbOcjene.Text),
                DatumPolaganja = dtpDatumVrijeme.Value.ToString()
            };
            IB190020_Baza.DB.KorisniciPredmeti.Add(noviPolozeni);
            IB190020_Baza.DB.SaveChanges();
            UcitajPolozenePredmete();
            ProvjeraCheckedChanged();
            //ProvjeraDodanog();
        }
        private void ProvjeraCheckedChanged()
        {
            if (chbNepolozeni.Checked)
            {
                List<IB190020_KorisnikPredmet> polozeni = IB190020_Baza.DB.KorisniciPredmeti.Where(kp => kp.Korisnik.Id == korisnik.Id).ToList();
                List<IB190020_Predmet> nepolozeni = new List<IB190020_Predmet>();
                foreach (IB190020_Predmet p in IB190020_Baza.DB.Predmeti.ToList())
                {
                    bool prisutan = false;
                    foreach (IB190020_KorisnikPredmet kp in polozeni)
                    {
                        if (kp.Predmet.Id == p.Id)
                        {
                            prisutan = true;
                            break;
                        }
                    }
                    if (!prisutan) nepolozeni.Add(p);
                }

                cmbPredmeti.DataSource = null;
                cmbPredmeti.DataSource = nepolozeni;
            }
        }
        private void chbNepolozeni_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNepolozeni.Checked) ProvjeraCheckedChanged();
            else UcitajPredmete();
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                PrintajUvjerenje printajUvjerenje = new PrintajUvjerenje(korisnik);
                printajUvjerenje.ShowDialog();
            }
        }

        async void Dodaj500()
        {
            IB190020_KorisnikPredmet noviPolozeni = new IB190020_KorisnikPredmet()
            {
                Korisnik = korisnik,
                Ocjena = 6,
                Predmet = cmbPredmeti.SelectedItem as IB190020_Predmet,
                DatumPolaganja = DateTime.Now.ToString()
            };
            await Task.Run(()=> { 
            
                for (int i=0; i<500; i++)
                {
                    IB190020_Baza.DB.KorisniciPredmeti.Add(noviPolozeni);
                    IB190020_Baza.DB.SaveChanges();
                }
            });

            UcitajPolozenePredmete();
            
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            Dodaj500();
        }

        //void ProvjeraDodanog()
        //{
        //    bool pronadjen = false;
        //    IB190020_Predmet selectedSubject = cmbPredmeti.SelectedItem as IB190020_Predmet;
        //    foreach(IB190020_KorisnikPredmet kp in IB190020_Baza.DB.KorisniciPredmeti.Where(k=>k.Korisnik.Id == korisnik.Id))
        //    {
        //        if (kp.Predmet.Id == selectedSubject.Id) pronadjen = true;
        //    }
        //    if (pronadjen) btnDodaj.Enabled = false;
        //    else btnDodaj.Enabled = true;
        //}

    }
}
