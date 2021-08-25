using Microsoft.Reporting.WinForms;
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
    public partial class PrintajUvjerenje : Form
    {
        IB190020_Korsinik korisnik;
        public PrintajUvjerenje(IB190020_Korsinik user)
        {
            InitializeComponent();
            this.korisnik = user;
        }

        private void PrintajUvjerenje_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("ImePrezime", korisnik.ToString()));

            List<IB190020_KorisnikPredmet> polozeni = IB190020_Baza.DB.KorisniciPredmeti.Where(KP => KP.Korisnik.Id == korisnik.Id).ToList();
            List<IB190020_Predmet> predmeti = IB190020_Baza.DB.Predmeti.ToList();

            DataSet1.DataTable1DataTable tabela = new DataSet1.DataTable1DataTable();

            for (int i=0; i<predmeti.Count; i++)
            {
                DataSet1.DataTable1Row red = tabela.NewDataTable1Row();
                bool pronadjen = false;
                int ocjena = 0;
                string datum = "";
                for(int j=0; j<polozeni.Count; j++)
                {
                    if (polozeni[j].Predmet.Id == predmeti[i].Id)
                    {
                        pronadjen = true;
                        ocjena = polozeni[j].Ocjena;
                        datum = polozeni[j].DatumPolaganja;
                    }
                }

                red.Predmet = predmeti[i].ToString();
                if (!pronadjen)
                {
                    red.Datum = "NIJE POLOŽENO";
                    red.Ocjena = "NIJE POLOŽENO";
                }
                else
                {
                    red.Ocjena = ocjena.ToString();
                    red.Datum = datum;
                }
                tabela.Rows.Add(red);
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "KPPolozeni";
            rds.Value = tabela;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
