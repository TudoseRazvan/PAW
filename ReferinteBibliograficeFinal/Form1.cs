using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferinteBibliograficeFinal
{
    public partial class Form1 : Form
    {
        public List<Publicatie> publicatii = new List<Publicatie>();
        private List<Autor> autori = new List<Autor>();
        public Form1()
        {
            InitializeComponent();

            autori.Add(new Autor("Autor1", "Grad 1"));
            autori.Add(new Autor("Autor2", "Grad 2"));
            autori.Add(new Autor("Autor3", "Grad 3"));
        }

        private void carteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarte formCarte = new FormCarte();
            formCarte.Owner = this;  // Setare Owner
            formCarte.CarteAdaugata += FormCarte_CarteAdaugata;
            formCarte.ShowDialog();
        }

        public void UpdateTextBoxes()
        {
            //Afisare publicatii sortate dupa titlu
            var publicatiiSortate = publicatii.OrderBy(p => p.Titlu).Select(p => p.genereazaReferinta());
            txtPublicatii.Text = string.Join(Environment.NewLine, publicatiiSortate);

            //Afisare autori inregistrati in sistem
            var numeAutori = autori.Select(a => a.Nume);
            txtAutori.Text = string.Join(Environment.NewLine, numeAutori);
        }

        public void UpdateListViewes()
        {
            // Populare ListView lvPublicatii cu publicații sortate după titlu
            lvPublicatii.Items.Clear();
            foreach (var publicatie in publicatii.OrderBy(p => p.Titlu))
            {
                var item = new ListViewItem(new[] { publicatie.Titlu, publicatie.genereazaReferinta() });
                lvPublicatii.Items.Add(item);
            }

            // Populare ListBox lbAutori cu numele autorilor
            lbAutori.Items.Clear();
            foreach (var autor in autori)
            {
                lbAutori.Items.Add($"{autor.Nume} - {autor.Grad_Didactic}");
            }
        }

        private void FormCarte_CarteAdaugata(object sender, EventArgs e)
        {
            UpdateListViewes();
        }


        public void AdaugaAutor(Autor autor)
        {
            autori.Add(autor);
        }

        private void lvPublicatii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
