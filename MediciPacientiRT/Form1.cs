using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediciPacientiRT
{
    public partial class Form1 : Form
    {
        Medic m1, m2;

        public Form1()
        {
            InitializeComponent();

            m1 = new Medic("5039217190278", "Marian", 2020, "Chirurgie Plastica", new DateTime(1980, 05, 25));
            m2 = new Medic("6273817263782", "Ana", 2015, "Neurologie", new DateTime(1978, 08, 15));

            // Adauga in lbMedic
            lbMedici.Items.Add(m1.Nume);
            lbMedici.Items.Add(m2.Nume);

            // Adauga medici in lvMedici
            ListViewItem lv = new ListViewItem(m1.Nume);
            lv.SubItems.Add(m1.Cnp);
            lv.SubItems.Add(m1.AnAbsolvire.ToString());
            lv.SubItems.Add(m1.Specializare);
            lv.SubItems.Add(m1.DataNastere.ToString());
            lv.Tag = m1;
            lvMedici.Items.Add(lv);

            ListViewItem lv2 = new ListViewItem(new string[]
                {m2.Nume, m2.Cnp, m2.AnAbsolvire.ToString(), 
                    m2.Specializare, m2.DataNastere.ToString()});
            lv2.Tag = m2;
            lvMedici.Items.Add(lv2);

            // Adauga in tvMedici
            TreeNode t = new TreeNode(m1.Nume + " " + m1.Specializare);
            t.Tag = m1;
            tvMedici.Nodes.Add(t);

            TreeNode t2 = new TreeNode(m2.Nume + " " + m2.Specializare);
            t2.Tag = m2;
            tvMedici.Nodes.Add(t2);

            // Adauga pacienti in lvPacienti
            Pacient p1 = new Pacient("5039217190278", "Neacsu Ionut", "Card 1",
                "Programator", new DateTime(1980, 05, 25));
            Pacient p2 = new Pacient("465745645645", "Matei Isabela", "Card 2",
                "Profesor", new DateTime(1980, 05, 25));

            ListViewItem lv3 = new ListViewItem(new string[]
            {
                p1.Nume, p1.Cnp, p1.CardSanatate, p1.Ocupatie, p1.DataNastere.ToString()
            });
            lv3.Tag = p1;
            lvPacienti.Items.Add(lv3);

            ListViewItem lv4 = new ListViewItem(new string[]
                {p2.Nume, p2.Cnp, p2.CardSanatate, 
                    p2.Ocupatie, p2.DataNastere.ToString()});
            lv4.Tag = p2;
            lvPacienti.Items.Add(lv4);

    }

        private void lvMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMedici.SelectedItems.Count > 0)
            {
                tbMedic.Text = "";
                ListViewItem lv = lvMedici.SelectedItems[0];
                tbMedic.Text += lv.Text + "," + lv.SubItems[1].Text + "," + lv.SubItems[2].Text +
                                 "," + lv.SubItems[3].Text + "," + lv.SubItems[4].Text;
            }
        }

        // Evenimentul pentru adăugarea unui nou medic
        public void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creează un nou formular pentru adăugarea unui medic cu valorile implicite
            FormMedic form = new FormMedic(null);

            // Verifică dacă formularul a fost închis cu OK (adică s-au introdus date valide)
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Obține medicul introdus din formular
                Medic m = form.mFormMedic;

                // Creează un element în lista de medici cu informațiile noului medic
                ListViewItem lv3 = new ListViewItem(new string[]
                {m.Nume, m.Cnp, m.AnAbsolvire.ToString(),
            m.Specializare, m.DataNastere.ToString()});

                // Adaugă medicul în lista de medici
                lv3.Tag = m;
                lvMedici.Items.Add(lv3);

                //Adauga numele medicul in listBox
                lbMedici.Items.Add(m.Nume);

                //Adauga numele medicului in treeView
                TreeNode t3 = new TreeNode(m.Nume + " " + m.Specializare);
                t3.Tag = m;
                tvMedici.Nodes.Add(t3);
            }
        }

        // Evenimentul pentru modificarea unui medic selectat
        private void modificaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Verifică dacă există un medic selectat în lista de medici
            if (lvMedici.SelectedItems.Count > 0)
            {
                // Obține medicul selectat
                Medic m = lvMedici.SelectedItems[0].Tag as Medic;

                // Creează un formular pentru modificarea medicului cu valorile acestuia
                FormMedic form = new FormMedic(m);

                // Verifică dacă formularul a fost închis cu OK (adică s-au făcut modificări valide)
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Actualizează informațiile medicului în lista de medici
                    ListViewItem lv = lvMedici.SelectedItems[0] as ListViewItem;
                    lv.SubItems[0].Text = m.Nume;
                    lv.SubItems[1].Text = m.Cnp;
                    lv.SubItems[2].Text = m.AnAbsolvire.ToString();
                    lv.SubItems[3].Text = m.Specializare;
                    lv.SubItems[4].Text = m.DataNastere.ToString();
                }
            }
        }

        // Evenimentul pentru ștergerea unui medic selectat
        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifică dacă există un medic selectat în lista de medici
            if (lvMedici.SelectedItems.Count > 0)
            {
                // Afisează o fereastră de confirmare pentru ștergerea medicului
                if (MessageBox.Show("Ești sigur că vrei să ștergi medicul selectat?", "Confirmare",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Șterge medicul selectat din lista de medici
                    lvMedici.SelectedItems[0].Remove();
                }
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugaToolStripMenuItem_Click(sender, e);
        }

        private void modificaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modificaToolStripMenuItem_Click(sender, e);
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stergeToolStripMenuItem_Click(sender, e);
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mediciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
