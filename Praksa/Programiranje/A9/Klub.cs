using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9
{
    public class Klub
    {
        public string ime, stadion, grad, drzava, sajt;
        public Klub(string ime, string stadion, string grad, string drzava, string sajt) 
        { 
            this.ime = ime;
            this.stadion = stadion;
            this.grad = grad;
            this.drzava = drzava;
            this.sajt = sajt;
        }
    }
}
