using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiuneStudenti
{
    public class Persoana
    {
        private int marca;
        private string nume;

        public Persoana(int marca, string nume)
        {
            this.marca = marca;
            this.nume = nume;
        }

        public int Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Nume
        { 
            get { return nume; } 
            set {  nume = value; } 
        }

        public override string ToString()
        {
            return $"Marca: {marca}, Nume: {nume}";
        }
    }
}
