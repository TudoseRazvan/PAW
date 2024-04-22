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

    public partial class FormCarte : Form
    {
        public event EventHandler CarteAdaugata;
        public FormCarte()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormCarte_Load(object sender, EventArgs e)
        {
            cmbCategorie.Items.Add("Ficțiune");
            cmbCategorie.Items.Add("Non-ficțiune");
            cmbCategorie.Items.Add("Poezie");
            cmbCategorie.Items.Add("Dramă");
        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                // Validare ISBN și preț
                if (!IsISBNValid(txtISBN.Text))
                {
                    MessageBox.Show("ISBN invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float pret;
                if (!float.TryParse(txtPret.Text, out pret))
                {
                    MessageBox.Show("Pret invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inițializare categorie (doar una din cele 4 posibile)
                string categorie = cmbCategorie.SelectedItem.ToString();

                // Inițializare lista de autori (golă, deoarece nu se permite inserarea autorilor)
                List<Autor> autori = new List<Autor>();

                // Creare obiect de tip Carte
                Carte carte = new Carte(txtTitlu.Text, pret, categorie, autori);


                MessageBox.Show("Carte adăugată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizare textBoxuri și listView
                ((Form1)this.Owner).UpdateListViewes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsISBNValid(string isbn)
        {
            // Simplă validare: verificăm dacă ISBN are lungimea corectă
            return isbn.Length == 10 || isbn.Length == 13;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
