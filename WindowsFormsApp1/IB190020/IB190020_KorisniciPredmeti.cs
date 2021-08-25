using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.IB190020
{
    [Table("KorisniciPredmeti")]
    public class IB190020_KorisnikPredmet
    {
        public int Id { get; set; }
        public virtual IB190020_Predmet Predmet { get; set; }
        public virtual IB190020_Korsinik Korisnik { get; set; }
        public int Ocjena { get; set; }
        public string DatumPolaganja { get; set; }
    }
}
