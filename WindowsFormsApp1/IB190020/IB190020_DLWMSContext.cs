using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.IB190020;

namespace WindowsFormsApp1
{
    public class IB190020_DLWMSContext : DbContext
    {
        public IB190020_DLWMSContext() : base("PutanjaDoBaze")
        {
        }

        public virtual DbSet<IB190020_Korsinik> Korisnici { get; set; }
        public virtual DbSet<IB190020_Spol> Spolovi { get; set; }
        public virtual DbSet<IB190020_Predmet> Predmeti { get; set; }
        public virtual  DbSet<IB190020_KorisnikPredmet> KorisniciPredmeti { get; set; }
    }
}
