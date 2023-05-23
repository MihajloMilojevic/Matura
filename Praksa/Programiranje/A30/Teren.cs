using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A30
{
    public class Teren
    {
        public string id, naziv, adresa, telefon, grad;
        public Teren(string id, string naziv, string adresa, string telefon, string grad)
        {
            this.id = id;
            this.naziv = naziv;
            this.adresa = adresa;
            this.telefon = telefon;
            this.grad = grad;
        }
        public override string ToString()
        {
            return (
                    id.PadRight(5 - id.Length) + "\t" +
                    naziv.PadRight(50 - naziv.Length) + "\t" +
                    adresa.PadRight(50 - adresa.Length) + "\t" +
                    telefon.PadRight(20 - telefon.Length) + "\t" +
                    grad.PadRight(15 - grad.Length)
                );
        }
    }
}
