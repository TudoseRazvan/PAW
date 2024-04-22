using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediciPacientiRT
{
    public class Medic
    {
        private string cnp;
        private string nume;
        private int anAbsolvire;
        private string specializare;
        private DateTime dataNastare;

        public Medic() { }

        public Medic(string cnp, string nume, int anAbsolvire, 
            string specializare, DateTime dataNastare)
        {
            this.cnp = cnp;
            this.nume = nume;
            this.anAbsolvire = anAbsolvire;
            this.specializare = specializare;
            this.dataNastare = dataNastare;
        }

        public string Cnp
        { 
        get { return cnp; }
        set { cnp = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int AnAbsolvire
        {
            get { return anAbsolvire; }
            set { anAbsolvire = value; }
        }

        public string Specializare
        { 
            get { return specializare; } 
            set { specializare = value; } 
        }

        public DateTime DataNastere
        {
            get { return dataNastare; }
            set { dataNastare = value; }
        }
    }
}
