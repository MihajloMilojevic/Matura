using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20
{
    public class Ugovor
    {
        public string id, destinacija, klijent;
        public DateTime pocetak, kraj;
        public Ugovor(string id, string destinacija, string klijent, DateTime pocetak, DateTime kraj)
        {
            this.id = id;
            this.destinacija = destinacija;
            this.klijent = klijent;
            this.pocetak = pocetak;
            this.kraj = kraj;
        }
    }
}
