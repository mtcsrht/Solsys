using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solsys
{

    class Bolygo
    {
        private string nev;
        private int holdakSzama;
        private double terfogatArany;

        public string Nev { get => nev;}
        public int HoldakSzama { get => holdakSzama;}
        public double TerfogatArany { get => terfogatArany;}

        public Bolygo(string sor)
        {
            string[] s = sor.Split(';');
            nev = s[0];
            holdakSzama = int.Parse(s[1]);
            terfogatArany = double.Parse(s[2].Replace('.', ','));
        }
    }
}
