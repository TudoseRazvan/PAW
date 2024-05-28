using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Tudose_Razvan
{
    [Serializable]
    public class ExtraOptiune
    {
        public string Denumire { get; set; }

        public ExtraOptiune() { }

        public ExtraOptiune(string denumire)
        {
            Denumire = denumire;
        }

        public override string ToString()
        {
            return $"{Denumire}";
        }
    }
}
