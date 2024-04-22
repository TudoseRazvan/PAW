using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferinteBibliograficeFinal
{
    public class Carte : Publicatie, ICloneable
    {
        private const string ISBN = "123456789";
        private string categorie;
        private List<Autor> autori = new List<Autor>();


        public Carte(string titlu, float pret, string categorie, List<Autor> autori)
            :base(titlu, pret)
        {
            this.categorie = categorie;
            this.autori = autori;
        }

        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public List<Autor> Autori
        {
            get { return autori; }
            set { autori = value; }
        }

        //Implementeaza metoda genereazaReferinta() din clasa de baza
        public override string genereazaReferinta()
        {

            string listaAutori = string.Join(", ", autori.Select(autor => autor.Nume));
            return $"{listaAutori} - {Titlu}, {ISBN}";
        }

        public object Clone()
        {
            return new Carte(this.Titlu, this.Pret, this.categorie, new List<Autor>(this.Autori));
        }

        //Supraincarca operatorul+ pentru a adauga un Autor la lista
        public static Carte operator+ (Carte carte, Autor autor)
        {
            if(carte == null) 
            {
                throw new ArgumentNullException(nameof(carte));
            }

            if(autor ==null)
            {
                throw new ArgumentNullException(nameof(autor));
            }

            //Verificam daca autorul exista deja in lista
            if(!carte.Autori.Any(a => a.Equals(autor)))
            {
                carte.Autori.Add(autor);
            }
            return carte;
        }
    }
}
