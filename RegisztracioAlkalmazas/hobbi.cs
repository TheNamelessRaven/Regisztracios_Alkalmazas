using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class Hobbi
    {
        string nev;
        private string name;

        public Hobbi(string name)
        {
            this.name = name;
        }

        public string Nev { get => nev; set => nev = value; }
    }
}
