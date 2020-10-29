using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class register
    {
        string nev;
        string nem;
        DateTime szul;
        string hobby;

        public register(string nev, string nem, DateTime szul, DateTime szul1, string hobby)
        {
            Nev = nev;
            Nem = nem;
            Szul = szul;
            Hobby = hobby;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Nem { get => nem; set => nem = value; }
        public DateTime Szul { get => szul; set => szul = value; }
        public string Hobby { get => hobby; set => hobby = value; }
    }
}
