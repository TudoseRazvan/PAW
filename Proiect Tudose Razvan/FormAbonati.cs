using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Tudose_Razvan
{
    public partial class FormAbonati : Form
    {
        private Client client;
        public Client Client { get { return client; } }
        private ListView lvAbonati;

        private FormPrincipal formPrincipal;
        private ErrorProvider errorProvider;
        public FormAbonati()
        {
            errorProvider = new ErrorProvider();
            this.client = client;
            this.formPrincipal = formPrincipal;

            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += FormAbonati_KeyDown;
        }

        private void FormAbonati_Load(object sender, EventArgs e)
        {

        }

        private void PopulateControls(Client client)
        {
            txtNume.Text = client.Nume;
            txtPrenume.Text = client.Prenume;
            txtTelefon.Text = client.Telefon;
            cmbAbonament.SelectedItem = client.Abonament?.Denumire;
            dtpPlata.Value = client.Plati.Any() ? client.Plati[0].DataPlatii : DateTime.Now;
            cmbExtraOptiuni.SelectedItem = client.ExtraOptiuni.Any() ? client.ExtraOptiuni[0].Denumire : null;
            txtSuma.Text = client.Plati.Any() ? client.Plati[0].Suma.ToString() : "";
        }

        public FormAbonati(Client client, FormPrincipal formPrincipal) : this()
        {
            this.client = client;
            this.formPrincipal = formPrincipal;
            txtNume.Text = client.Nume;
            txtPrenume.Text = client.Prenume;
            txtTelefon.Text = client.Telefon;
            cmbAbonament.SelectedItem = client.Abonament?.Denumire;
            dtpPlata.Value = client.Plati.Any() ? client.Plati[0].DataPlatii : DateTime.Now;
            cmbExtraOptiuni.SelectedItem = client.ExtraOptiuni.Any() ? client.ExtraOptiuni[0].Denumire : null;
            txtSuma.Text = client.Plati.Any() ? client.Plati[0].Suma.ToString() : "";
            PopulateControls(client);
        }


        private void SaveData()
        {
            //Validare nume
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                errorProvider.SetError(txtNume, "Introduceti un nume valid.");
                return;
            }
            else
            {
                errorProvider.SetError(txtNume, "");
            }

            //Validare prenume
            if (string.IsNullOrWhiteSpace(txtPrenume.Text))
            {
                errorProvider.SetError(txtPrenume, "Introduceti un prenume valid.");
                return;
            }
            else
            {
                errorProvider.SetError(txtPrenume, "");
            }

            //Validare telefon 
            string telefonPattern = @"^\d{10}$"; //Telefonul trebuie sa aiba 10 cifre
            if (!Regex.IsMatch(txtTelefon.Text, telefonPattern))
            {
                errorProvider.SetError(txtTelefon, "Introduceti un numar de telefon valid format din 10 cifre.");
                return;
            }
            else
            {
                errorProvider.SetError(txtTelefon, "");
            }

            //Validare adresa de email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                errorProvider.SetError(txtEmail, "Introduceti o adresa de email valida.");
                return;
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }

            //Validare suma
            decimal suma;
            if (!decimal.TryParse(txtSuma.Text, out suma) || suma <= 0)
            {
                errorProvider.SetError(txtSuma, "Introduceti o suma valida si pozitiva.");
                return;
            }
            else
            {
                errorProvider.SetError(txtSuma, "");
            }

            client.Nume = txtNume.Text;
            client.Prenume = txtPrenume.Text;
            client.Telefon = txtTelefon.Text;
            client.Abonament = new TipAbonament { Denumire = cmbAbonament.SelectedItem.ToString() };
            client.Email = txtEmail.Text;
            client.Plati = new List<Plata> { new Plata { DataPlatii = dtpPlata.Value, Suma = decimal.Parse(txtSuma.Text) } };
            client.ExtraOptiuni = new List<ExtraOptiune> { new ExtraOptiune { Denumire = cmbExtraOptiuni.SelectedItem.ToString() } };

            //Verifica daca clientul exista deja in ListView-ul din FormPrincipal
            bool clientExists = formPrincipal.LvAbonati.Items
                .OfType<ListViewItem>()
                .Any(item => item.SubItems[0].Text.Equals(client.Nume) &&
                             item.SubItems[1].Text.Equals(client.Prenume) &&
                             item.SubItems[2].Text.Equals(client.Telefon));

            if (!clientExists)
            {
                //Adauga clientul in ListView-ul din FormPrincipal
                ListViewItem item = new ListViewItem(client.Nume);
                item.SubItems.Add(client.Prenume);
                item.SubItems.Add(client.Telefon);
                item.SubItems.Add(client.Email);
                item.SubItems.Add(client.Abonament?.Denumire);
                item.SubItems.Add(client.Plati.Any() ? client.Plati[0].DataPlatii.ToShortDateString() : "");
                item.SubItems.Add(client.ExtraOptiuni.Any() ? client.ExtraOptiuni[0].Denumire : "");
                item.SubItems.Add(client.Plati.Any() ? client.Plati[0].Suma.ToString() : ""); 
                formPrincipal.LvAbonati.Items.Add(item);
            }

            //Actualizeaza textul in TextBox-ul din Form2
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem listViewItem in formPrincipal.LvAbonati.Items)
            {
                sb.AppendLine("Nume: " + listViewItem.SubItems[0].Text);
                sb.AppendLine("Prenume: " + listViewItem.SubItems[1].Text);
                sb.AppendLine("Telefon: " + listViewItem.SubItems[2].Text);
                sb.AppendLine("Email: " + listViewItem.SubItems[3].Text);
                sb.AppendLine("Abonament: " + listViewItem.SubItems[4].Text);
                sb.AppendLine("Data Plății: " + listViewItem.SubItems[5].Text);
                sb.AppendLine("Suma: " + listViewItem.SubItems[6].Text); 
                sb.AppendLine("Extra Opțiune: " + listViewItem.SubItems[7].Text);
                sb.AppendLine();
            }

            //Seteaza textul in TextBox-ul din Form2
            formPrincipal.SetForm2TextBoxText(sb.ToString());

            //Adauga clientul in lista clienti din FormPrincipal
            formPrincipal.AdaugaClient(client);

            MessageBox.Show("Datele au fost salvate cu succes!\n" + client.ToString());
            this.Close();
            formPrincipal.RefreshGrid();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Acces la campuri prin acceleratori, interceptand tastatura
        private void FormAbonati_KeyDown(object sender, KeyEventArgs e)
        {
            //Verifica daca combinatia de taste Ctrl + S este apasata
            if (e.Control && e.KeyCode == Keys.S)
            {
                //Salveaza datele
                SaveData();
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                //Inchide FormAbonati si se intoarce la FormPrincipal
                this.Close();
                formPrincipal.Show();
            }
        }
    }
}
