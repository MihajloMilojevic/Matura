using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A26
{
    public class Ugovor
    {
        public string ugovorId, ugovarac, pocetak, dana, zaUplatu, rok, dug;
        public Ugovor(string ugovorId, string ugovarac, string pocetak, string dana, string zaUplatu, string rok, string dug)
        {
            this.ugovorId = ugovorId;
            this.ugovarac = ugovarac;
            this.pocetak = pocetak;
            this.dana = dana;
            this.zaUplatu = zaUplatu;
            this.rok = rok;
            this.dug = dug;
        }
        public Ugovor() { }
    }
}
