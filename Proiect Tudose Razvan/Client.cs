using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Tudose_Razvan
{
    [Serializable]
    public class Client
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public TipAbonament Abonament { get; set; }
        public List<Plata> Plati { get; set; }
        public List<ExtraOptiune> ExtraOptiuni { get; set; }

        public Client()
        {
            Plati = new List<Plata>();
            ExtraOptiuni = new List<ExtraOptiune>();
        }

        public Client(int id, string nume, string prenume, string telefon, string email, TipAbonament abonament)
            : this()
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            Email = email;
            Abonament = abonament;
        }

        public void AdaugaPlata(Plata plata)
        {
            Plati.Add(plata);
        }

        public void AdaugaExtraOptiune(ExtraOptiune extraOptiune)
        {
            ExtraOptiuni.Add(extraOptiune);
        }

        public override string ToString()
        {
            return $"{Nume} {Prenume} - {Telefon} - {Email}";
        }
    }

}
