using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_Tudose_Razvan
{
    public partial class FormPrincipal : Form
    {
        public List<Client> clienti;
        private List<Client> listaClienti;
        Client client { get; set; }

        public ListView LvAbonati { get { return lvAbonati; } }
        private Form2 form2;

        public FormPrincipal()
        {
            clienti = new List<Client>();
            listaClienti = new List<Client>();
            InitializeComponent();
        }
        public void AdaugaClient(Client client)
        {
            clienti.Add(client);
        }
        public void SetForm2TextBoxText(string text)
        {
            if (form2 != null && !form2.IsDisposed)
            {
                form2.SetTextBoxText(text);
            }
        }


        public void AdaugaAbonatInListView(Client client)
        {
            //Creeaza un ListViewItem pentru noul abonat si adauga informatiile
            ListViewItem item = new ListViewItem(client.Nume);
            item.SubItems.Add(client.Prenume);
            item.SubItems.Add(client.Telefon);
            item.SubItems.Add(client.Email);
            item.SubItems.Add(client.Abonament?.Denumire);
            item.SubItems.Add(client.Plati.Any() ? client.Plati[0].DataPlatii.ToShortDateString() : "");
            item.SubItems.Add(client.ExtraOptiuni.Any() ? client.ExtraOptiuni[0].Denumire : "");
            item.SubItems.Add(client.Plati.Any() ? client.Plati[0].Suma.ToString() : "");

            //Adauga elementul in ListView
            lvAbonati.Items.Add(item);
        }

        private void ModificaAbonatInListView(Client client)
        {
            //Verifica daca un abonat este selectat in ListView
            if (lvAbonati.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvAbonati.SelectedItems[0];

                //Actualizeaza valorile abonatului selectat in ListView
                selectedItem.SubItems[0].Text = client.Nume;
                selectedItem.SubItems[1].Text = client.Prenume;
                selectedItem.SubItems[2].Text = client.Telefon;
                selectedItem.SubItems[3].Text = client.Email;
                selectedItem.SubItems[4].Text = client.Abonament?.Denumire;
                selectedItem.SubItems[5].Text = client.Plati.Any() ? client.Plati[0].DataPlatii.ToShortDateString() : "";
                selectedItem.SubItems[6].Text = client.ExtraOptiuni.Any() ? client.ExtraOptiuni[0].Denumire : "";
                selectedItem.SubItems[7].Text = client.Plati.Any() ? client.Plati[0].Suma.ToString() : "";
            }
        }

        private void StergeAbonatDinListView()
        {
            //Verifica daca un abonat este selectat in lv
            if (lvAbonati.SelectedItems.Count > 0)
            {
                //Sterge abonatul selectat
                lvAbonati.SelectedItems[0].Remove();
            }
        }

        private void lvAbonati_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adaugaAbonatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();

            using (var formAbonati = new FormAbonati(newClient, this))
            {
                if (formAbonati.ShowDialog() == DialogResult.OK)
                {
                    Client client = formAbonati.Client;
                    clienti.Add(client);

                    RefreshGrid();
                }
            }
        }



        private Client GetClientFromListViewItem(ListViewItem item)
        {
            //Obtine valorile din sub-elementele ListViewItem 
            string nume = item.SubItems[0].Text;
            string prenume = item.SubItems[1].Text;
            string telefon = item.SubItems[2].Text;
            string email = item.SubItems[3].Text;
            string abonament = item.SubItems[4].Text;
            DateTime dataPlatii;
            DateTime.TryParse(item.SubItems[5].Text, out dataPlatii);
            string extraOptiune = item.SubItems[6].Text;
            decimal sumaPlatita;
            Decimal.TryParse(item.SubItems[7].Text, out sumaPlatita); 

            return new Client
            {
                Nume = nume,
                Prenume = prenume,
                Telefon = telefon,
                Email = email,
                Abonament = new TipAbonament { Denumire = abonament },
                Plati = new List<Plata> { new Plata { DataPlatii = dataPlatii, Suma = sumaPlatita } }, 
                ExtraOptiuni = new List<ExtraOptiune> { new ExtraOptiune { Denumire = extraOptiune } }
            };
        }


        private void modificaAbonatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvAbonati.SelectedItems.Count > 0)
            {
                //Obtine abonatul selectat din lv
                ListViewItem selectedItem = lvAbonati.SelectedItems[0];
                Client client = GetClientFromListViewItem(selectedItem);

                //Deschide formularul FormAbonati pentru modificare cu abonatul selectat
                using (var formAbonati = new FormAbonati(client, this))
                {
                    if (formAbonati.ShowDialog() == DialogResult.OK)
                    {
                        //Actualizeaza detaliile abonatului in ListView dupa salvare
                        client = formAbonati.Client;
                        ModificaAbonatInListView(client);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectati un abonat pentru modificare.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stergeAbonatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvAbonati.SelectedItems.Count > 0)
            {
                StergeAbonatDinListView();
            }
            else
            {
                MessageBox.Show("Selectati un abonat pentru stergere.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RefreshGrid()
        {
            lvAbonati.Items.Clear();
            foreach (var client in clienti)
            {
                AdaugaAbonatInListView(client);
            }
        }
        private void RefreshForm2ClientList()
        {
            if (form2 != null && !form2.IsDisposed)
            {
                form2.UpdateClientList(clienti);
            }
            else
            {
                form2 = new Form2(clienti, this);
                form2.Show();
            }
        }

        private void btnAfisareStudentiForm2_Click(object sender, EventArgs e)
        {
            RefreshForm2ClientList();
            clienti.Add(new Client(1, "Popescu", "Ion", "0712345678", "popescu.ion@example.com", new TipAbonament("Standard")));
            clienti.Add(new Client(2, "Ionescu", "Maria", "0712345679", "ionescu.maria@example.com", new TipAbonament("Premium")));
        }


        private void AfisareGraficPlati()
        {
            chartPlati.Series.Clear();
            chartPlati.ChartAreas.Clear();
            chartPlati.Titles.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.Name = "PlatiChartArea";

            chartPlati.ChartAreas.Add(chartArea);

            //Adauga o noua serie pentru plati
            Series seriesPlati = new Series();
            seriesPlati.Name = "Suma Plati";
            seriesPlati.ChartType = SeriesChartType.Column; // Tipul graficului - coloane
            seriesPlati.XValueType = ChartValueType.String; // Tipul valorilor de pe axa x - siruri

            //Adauga seria la controlul Chart
            chartPlati.Series.Add(seriesPlati);

            //Adauga titlul graficului
            chartPlati.Titles.Add("Suma Plati per Client");

            //Creeaza un dictionar pentru a tine sumele platilor pentru fiecare client
            Dictionary<string, decimal> sumePlatiPeClient = new Dictionary<string, decimal>();

            foreach (var client in clienti)
            {
                //Calculeaza suma platilor pentru clientul curent
                decimal sumaTotalaPlati = client.Plati.Sum(plata => plata.Suma);

                //Adauga sau actualizeaza suma platilor pentru acest client in dictionar
                if (!sumePlatiPeClient.ContainsKey(client.Nume))
                {
                    sumePlatiPeClient.Add(client.Nume, sumaTotalaPlati);
                }
                else
                {
                    sumePlatiPeClient[client.Nume] += sumaTotalaPlati;
                }
            }

            //Adauga sumele platilor din dictionar in seria graficului
            foreach (var kvp in sumePlatiPeClient)
            {
                seriesPlati.Points.AddXY(kvp.Key, kvp.Value);
            }
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void graficPlatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfisareGraficPlati();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(chartPlati.Width, chartPlati.Height);

            //Deseneaza graficul pe bitmap
            chartPlati.DrawToBitmap(bmp, new Rectangle(0, 0, chartPlati.Width, chartPlati.Height));

            e.Graphics.DrawImage(bmp, new Point(100, 100)); 
        }




        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();

            //Ataseaza un handler pentru evenimentul PrintPage
            printDocument.PrintPage += PrintDocument_PrintPage;

            //Creaza un obiect PrintPreviewDialog si seteaza documentul pentru previzualizare
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            //Afiseaza fereastra de previzualizare a imprimarii
            printPreviewDialog.ShowDialog();
        }

        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Deschide fereastra de dialog pentru selectarea culorii
            ColorDialog colorDialog = new ColorDialog();

            //Verifica daca utilizatorul a selectat o culoare si face actualizarile
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;

                chartPlati.Series[0].Color = selectedColor;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Deschide fereastra de dialog pentru selectarea fontului
            FontDialog fontDialog = new FontDialog();

            //Verifica dacă utilizatorul a selectat un font si face actualizarile
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                //Obtine fontul
                Font selectedFont = fontDialog.Font;

                //Actualizeaza fontul
                chartPlati.Titles[0].Font = selectedFont; // Font pentru titlu
                chartPlati.ChartAreas[0].AxisX.TitleFont = selectedFont; // Font pentru axa x
                chartPlati.ChartAreas[0].AxisY.TitleFont = selectedFont; // Font pentru axa y
                chartPlati.ChartAreas[0].AxisX.LabelStyle.Font = selectedFont; // Font pentru etichetele axei x
                chartPlati.ChartAreas[0].AxisY.LabelStyle.Font = selectedFont; // Font pentru etichetele axei y
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //Obtine lista de cai catre fisierele trase si aruncate
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                //Verifica daca fișierul este de tipul (.txt)
                if (Path.GetExtension(file).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    //Citeste fisierul text si extrage clientii din el
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        //Desparte informatiile despre client
                        string[] clientInfo = line.Split(',');

                        //Verifica daca exista suficiente informatii pentru a crea un client
                        if (clientInfo.Length >= 8)
                        {
                            //Creaza un obiect Client cu informatiile din fisier
                            Client client = new Client
                            {
                                Nume = clientInfo[0].Trim(),
                                Prenume = clientInfo[1].Trim(),
                                Telefon = clientInfo[2].Trim(),
                                Email = clientInfo[3].Trim(),
                                Abonament = new TipAbonament(clientInfo[4].Trim()),
                                Plati = new List<Plata>
                        {
                            new Plata
                            {
                                DataPlatii = DateTime.Parse(clientInfo[5].Trim()),
                                Suma = decimal.Parse(clientInfo[7].Trim())
                            }
                        },
                                ExtraOptiuni = new List<ExtraOptiune>
                        {
                            new ExtraOptiune
                            {
                                Denumire = clientInfo[6].Trim()
                            }
                        }
                            };

                            //Adauga clientul in lvAbonati
                            AdaugaAbonatInListView(client);
                        }
                        else
                        {
                            //Daca linia nu contine suficiente informatii, afisam un mesaj de eroare
                            MessageBox.Show($"Linia '{line}' nu contine suficiente informatii. Formatul corect este 'nume,prenume,telefon,email,abonament,data_platii,extra_optiuni,suma'.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Dacă fișierul nu este de tipul dorit, afișăm un mesaj de eroare
                    MessageBox.Show("Fisierul selectat nu este de tip text (.txt)!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
        }


        //Incarcare clienti din Baza de date Access in lvAbonati
        private void IncarcaDateBazaDeDateInListView()
        {
            //Conexiunea catre baza de date Access
            string BDAbonatiConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDAbonati.accdb;";

            //Interogarea SQL pentru a selecta datele dorite
            string query = "SELECT Nume, Prenume, Telefon, Email, TipAbonament, DataPlatii, ExtraOptiune, Suma FROM BDAbonati";

            //Crearea conexiunii
            using (OleDbConnection connection = new OleDbConnection(BDAbonatiConnectionString))
            {
                //Deschiderea conexiunii
                connection.Open();

                //Crearea comenzii SQL
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    //Executarea interogarii SQL si citirea datelor
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        //Verifica daca exista randuri pentru a citi
                        if (reader.HasRows)
                        {
                            //Parcurge prin fiecare rand
                            while (reader.Read())
                            {
                                //Creaza un obiect ListViewItem cu informatiile din baza de date
                                ListViewItem item = new ListViewItem(reader["Nume"].ToString());
                                item.SubItems.Add(reader["Prenume"].ToString());
                                item.SubItems.Add(reader["Telefon"].ToString());
                                item.SubItems.Add(reader["Email"].ToString());
                                item.SubItems.Add(reader["TipAbonament"].ToString());
                                item.SubItems.Add(reader["DataPlatii"].ToString());
                                item.SubItems.Add(reader["ExtraOptiune"].ToString());
                                item.SubItems.Add(reader["Suma"].ToString());

                                //Adauga obiectul ListViewItem in ListView
                                lvAbonati.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu exista date in baza de date.");
                        }
                    }
                }
            }
        }

        private void btnPopulare_Click(object sender, EventArgs e)
        {
            IncarcaDateBazaDeDateInListView();
        }

    }
}
