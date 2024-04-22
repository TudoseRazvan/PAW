using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiuneStudenti
{
    public class Student : Persoana
    {
        private string facultate;
        private int[] note;

        public Student(int marca, string nume, string facultate, int[] note) : base(marca, nume)
        {
            this.facultate = facultate;
            this.note = note;
        }

        public string Facultate
        { 
        get { return this.facultate;}
        set { this.facultate = value; }
        }

        public int[] Note
        { 
            get { return this.note;}
            set { this.note = value; }
        }

        //Metoda pentru a calcula media
        public static implicit operator float(Student student)
        {
            if(student.note == null || student.note.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach(int nota in student.note) 
            {
                sum += nota;
            }
            return (float)sum / student.note.Length;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}, Nume: {Nume}, Facultate: {facultate}, Note: [{string.Join(", ", note)}]";
        }

    }
}
