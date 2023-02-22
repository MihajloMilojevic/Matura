using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13
{
    public class Producent
    {
        public string sifra;
        public string ime;
        public string email;
        public Producent(string sifra, string ime, string email)
        {
            this.sifra = sifra;
            this.ime = ime;
            this.email = email;
        }
        public override string ToString()
        {
            return sifra.PadRight(5 - sifra.Length) + "\t" + ime.PadRight(45 - ime.Length) + "\t" + email.PadRight(40 - email.Length);
        }
    }
}
