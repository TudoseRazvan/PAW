using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestiuneStudenti
{
    public partial class Form1 : Form
    {
        private List<Student> studenti;
        public Form1()
        {
            InitializeComponent();
            this.studenti = new List<Student>();
        }

        public List<Student> Studenti
        {
            get { return studenti; }
            set { studenti = value; }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudenti.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewStudenti.SelectedItems[0];
                string detalii = $"Marca: {selectedItem.SubItems[0].Text}\r\n" +
                                 $"Nume: {selectedItem.SubItems[1].Text}\r\n" +
                                 $"Facultate: {selectedItem.SubItems[2].Text}\r\n" +
                                 $"Medie: {selectedItem.SubItems[3].Text}";

            }
        }

        public void AdaugaStudentiInListView()
        {
            listViewStudenti.Items.Clear();

            foreach (var student in studenti)
            {
                float media = student;

                ListViewItem item = new ListViewItem(student.Marca.ToString());
                item.SubItems.Add(student.Nume);
                item.SubItems.Add(student.Facultate);
                item.SubItems.Add(media.ToString("F2"));

                listViewStudenti.Items.Add(item);
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent(this);
            formStudent.ShowDialog();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
