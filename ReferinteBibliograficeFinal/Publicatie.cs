using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferinteBibliograficeFinal
{
    public abstract class Publicatie
    {
        private string titlu;
        private float pret;

        public Publicatie(string titlu, float pret)
        {
            this.titlu = titlu;
            this.pret = pret;
        }

        public string Titlu
        { 
            get { return titlu; }
            set { titlu = value; }
        }

        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }
        
        //Metoda abstracta ce intoarce string si nu are argumente
        public abstract string genereazaReferinta();

    }
}
