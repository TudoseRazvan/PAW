using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferinteBibliograficeFinal
{
    public class Autor
    {
        private string nume;
        private string grad_didactic;
        private const int marca = 1;


        public Autor(string nume, string grad_didactic) 
        {
            this.nume = nume;
            this.grad_didactic = grad_didactic;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Grad_Didactic
        {
            get { return grad_didactic; }
            set { grad_didactic = value; }
        }


    }
}
