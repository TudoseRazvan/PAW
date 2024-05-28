using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Proiect_Tudose_Razvan
{
    public partial class Form2 : Form
    {
        private List<Client> listaClienti;
        private FormPrincipal formPrincipal;
        public TextBox TbClienti
        {
            get { return tbClienti; }
        }
        public Form2(List<Client> clienti, FormPrincipal formPrincipal)
        {
            listaClienti = clienti;
            InitializeComponent();
            InitializeCustomComponents();
            this.formPrincipal = formPrincipal;
        }

        private void InitializeCustomComponents()
        {
            this.saveFileDialog1 = new SaveFileDialog();
            this.openFileDialog1 = new OpenFileDialog();

            //Configurarea filtrului pentru SaveFileDialog si OpenFileDialog
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        }

        public void SetTextBoxText(string text)
        {
            tbClienti.Text = text;
        }

        public void UpdateClientList(List<Client> clientList)
        {
            //Sterge continutul actual din tbClienti
            tbClienti.Clear();

            //Adauga fiecare client la tbClienti
            foreach (Client client in clientList)
            {
                tbClienti.AppendText(client.ToString() + Environment.NewLine);
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Client client in listaClienti)
            {
                sb.AppendLine(client.ToString());
            }
            tbClienti.Text = sb.ToString();
        }

        private void salvareInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (Client c in listaClienti)
                    {
                        sw.WriteLine(c.ToString());
                    }
                }
                tbClienti.Clear();
            }
        }

        private void deschidereFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    tbClienti.Text = sr.ReadToEnd();
                }
            }
        }

        private void salvareInFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, listaClienti);
                }
                tbClienti.Clear();
                MessageBox.Show("S-a salvat fisierul serializat cu informatiile despre clienti!");
            }
        }

        private void deschidereFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    List<Client> listaClientiDeserializati = (List<Client>)bf.Deserialize(fs);
                    tbClienti.Clear();
                    foreach (Client c in listaClientiDeserializati)
                    {
                        tbClienti.Text += c.ToString() + Environment.NewLine;
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
