using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Tudose_Razvan
{
    [Serializable]
    public class TipAbonament
    {
        public string Denumire { get; set; }

        public TipAbonament() { }

        public TipAbonament(string denumire)
        {
            Denumire = denumire;
        }

        public override string ToString()
        {
            return $"{Denumire}";
        }
    }
}
