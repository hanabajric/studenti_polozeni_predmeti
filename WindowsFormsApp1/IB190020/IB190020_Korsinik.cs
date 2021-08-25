using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.IB190020
{
    [Table("Korisnici")]
    public class IB190020_Korsinik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Admin { get; set; }
        public virtual IB190020_Spol Spol { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
