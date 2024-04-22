using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiuneStudenti
{
    public partial class FormStudent : Form
    {
        private List<Student> studenti = new List<Student>();
        private Form1 form1;

        public FormStudent(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.studenti = form1.Studenti;
        }

        private void btnAdaugaStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int marca = int.Parse(txtMarca.Text);
                string nume = txtNume.Text;
                string facultate = txtFacultate.Text;
                string[] noteStr = txtNote.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] note = new int[noteStr.Length];

                for (int i = 0; i < noteStr.Length; i++)
                {
                    note[i] = int.Parse(noteStr[i]);
                }

                Student student = new Student(marca, nume, facultate, note);
                studenti.Add(student);

                //Aici adauga stundetii in listViewStudenti din Form1
                form1.AdaugaStudentiInListView();


                MessageBox.Show($"Student adaugat: Marca: {marca}, Nume: {nume}, Facultate: {facultate}, Note: {string.Join(", ", note)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la adaugarea studentului: {ex.Message}");
            }
        }

        private void btnAfiseazaStudentii_Click(object sender, EventArgs e)
        {
            if (studenti.Count == 0)
            {
                MessageBox.Show("Nu exista studenti inregistrati.");
                return;
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var student in studenti)
            {
                float media = student;
                stringBuilder.AppendLine($"Marca: {student.Marca}, Nume: {student.Nume}, Facultate: {student.Facultate}, Medie: {media:F2}");
            }

            // Setează textul construit în TextBox
            txtAfisareStudenti.Text = stringBuilder.ToString();
        }
    }
}
