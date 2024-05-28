using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Tudose_Razvan
{
    [Serializable]
    public class Plata
    {
        public DateTime DataPlatii { get; set; }
        public decimal Suma { get; set; }
        public Client Client { get; set; }

        public Plata() { }

        public Plata(DateTime dataPlatii, decimal suma, Client client)
        {
            DataPlatii = dataPlatii;
            Suma = suma;
            Client = client;
        }

        public override string ToString()
        {
            return $"{DataPlatii.ToShortDateString()} - {Suma}";
        }
    }
}
