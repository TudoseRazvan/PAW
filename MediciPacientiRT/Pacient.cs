using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediciPacientiRT
{
    public class Pacient
    {
        private string cnp;
        private string nume;
        private string cardSanatate;
        private string ocupatie;
        private DateTime dataNastere;

        public Pacient() { }
        public Pacient(string cnp, string nume, string cardSanatate, string ocupatie, DateTime dataNastere)
        {
            this.cnp = cnp;
            this.nume = nume;
            this.cardSanatate = cardSanatate;
            this.ocupatie = ocupatie;
            this.dataNastere = dataNastere;
        }

        public string Cnp 
        { 
            get { return cnp; } 
            set { cnp = value; } 
        }

        public string Nume
        { get { return nume; } set {  nume = value; } }

        public string CardSanatate 
        { 
            get {  return cardSanatate; } 
            set {  cardSanatate = value; } 
        }
        public string Ocupatie 
        { 
            get {  return ocupatie; } 
            set {  ocupatie = value; } 
        }
        public DateTime DataNastere 
        { 
            get { return dataNastere; } 
            set { dataNastere = value; } 
        }
    }
}
