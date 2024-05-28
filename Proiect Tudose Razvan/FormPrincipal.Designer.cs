namespace Proiect_Tudose_Razvan
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficPlatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaAbonatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaAbonatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeAbonatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvAbonati = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipAbonament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPlata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExtraOptiuni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSuma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfisareStudentiForm2 = new System.Windows.Forms.Button();
            this.chartPlati = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnPopulare = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.abonatiToolStripMenuItem,
            this.modificareGraficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1048, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficPlatiToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // graficPlatiToolStripMenuItem
            // 
            this.graficPlatiToolStripMenuItem.Name = "graficPlatiToolStripMenuItem";
            this.graficPlatiToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.graficPlatiToolStripMenuItem.Text = "Grafic plati";
            this.graficPlatiToolStripMenuItem.Click += new System.EventHandler(this.graficPlatiToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // abonatiToolStripMenuItem
            // 
            this.abonatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaAbonatToolStripMenuItem,
            this.modificaAbonatToolStripMenuItem,
            this.stergeAbonatToolStripMenuItem});
            this.abonatiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.abonatiToolStripMenuItem.Name = "abonatiToolStripMenuItem";
            this.abonatiToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.abonatiToolStripMenuItem.Text = "Abonati";
            // 
            // adaugaAbonatToolStripMenuItem
            // 
            this.adaugaAbonatToolStripMenuItem.Name = "adaugaAbonatToolStripMenuItem";
            this.adaugaAbonatToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.adaugaAbonatToolStripMenuItem.Text = "Adauga abonat";
            this.adaugaAbonatToolStripMenuItem.Click += new System.EventHandler(this.adaugaAbonatToolStripMenuItem_Click);
            // 
            // modificaAbonatToolStripMenuItem
            // 
            this.modificaAbonatToolStripMenuItem.Name = "modificaAbonatToolStripMenuItem";
            this.modificaAbonatToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.modificaAbonatToolStripMenuItem.Text = "Modifica abonat";
            this.modificaAbonatToolStripMenuItem.Click += new System.EventHandler(this.modificaAbonatToolStripMenuItem_Click);
            // 
            // stergeAbonatToolStripMenuItem
            // 
            this.stergeAbonatToolStripMenuItem.Name = "stergeAbonatToolStripMenuItem";
            this.stergeAbonatToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.stergeAbonatToolStripMenuItem.Text = "Sterge abonat";
            this.stergeAbonatToolStripMenuItem.Click += new System.EventHandler(this.stergeAbonatToolStripMenuItem_Click);
            // 
            // modificareGraficToolStripMenuItem
            // 
            this.modificareGraficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.culoareToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.modificareGraficToolStripMenuItem.Name = "modificareGraficToolStripMenuItem";
            this.modificareGraficToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.modificareGraficToolStripMenuItem.Text = "Modificare grafic";
            // 
            // culoareToolStripMenuItem
            // 
            this.culoareToolStripMenuItem.Name = "culoareToolStripMenuItem";
            this.culoareToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.culoareToolStripMenuItem.Text = "Culoare";
            this.culoareToolStripMenuItem.Click += new System.EventHandler(this.culoareToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // lvAbonati
            // 
            this.lvAbonati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chPrenume,
            this.chTelefon,
            this.chEmail,
            this.chTipAbonament,
            this.chPlata,
            this.chExtraOptiuni,
            this.chSuma});
            this.lvAbonati.HideSelection = false;
            this.lvAbonati.Location = new System.Drawing.Point(28, 30);
            this.lvAbonati.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvAbonati.Name = "lvAbonati";
            this.lvAbonati.Size = new System.Drawing.Size(879, 124);
            this.lvAbonati.TabIndex = 1;
            this.lvAbonati.UseCompatibleStateImageBehavior = false;
            this.lvAbonati.View = System.Windows.Forms.View.Details;
            this.lvAbonati.SelectedIndexChanged += new System.EventHandler(this.lvAbonati_SelectedIndexChanged);
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 92;
            // 
            // chPrenume
            // 
            this.chPrenume.Text = "Prenume";
            this.chPrenume.Width = 93;
            // 
            // chTelefon
            // 
            this.chTelefon.Text = "Telefon";
            this.chTelefon.Width = 86;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 175;
            // 
            // chTipAbonament
            // 
            this.chTipAbonament.Text = "Tip abonament";
            this.chTipAbonament.Width = 102;
            // 
            // chPlata
            // 
            this.chPlata.Text = "Data platii";
            this.chPlata.Width = 102;
            // 
            // chExtraOptiuni
            // 
            this.chExtraOptiuni.Text = "Extra optiune";
            this.chExtraOptiuni.Width = 145;
            // 
            // chSuma
            // 
            this.chSuma.Text = "Suma platii";
            this.chSuma.Width = 80;
            // 
            // btnAfisareStudentiForm2
            // 
            this.btnAfisareStudentiForm2.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAfisareStudentiForm2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAfisareStudentiForm2.BackgroundImage")));
            this.btnAfisareStudentiForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAfisareStudentiForm2.Location = new System.Drawing.Point(28, 160);
            this.btnAfisareStudentiForm2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAfisareStudentiForm2.Name = "btnAfisareStudentiForm2";
            this.btnAfisareStudentiForm2.Size = new System.Drawing.Size(356, 40);
            this.btnAfisareStudentiForm2.TabIndex = 19;
            this.btnAfisareStudentiForm2.Text = "Afiseaza abonatii pentru salvare";
            this.btnAfisareStudentiForm2.UseVisualStyleBackColor = false;
            this.btnAfisareStudentiForm2.Click += new System.EventHandler(this.btnAfisareStudentiForm2_Click);
            // 
            // chartPlati
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPlati.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPlati.Legends.Add(legend1);
            this.chartPlati.Location = new System.Drawing.Point(438, 157);
            this.chartPlati.Name = "chartPlati";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPlati.Series.Add(series1);
            this.chartPlati.Size = new System.Drawing.Size(469, 255);
            this.chartPlati.TabIndex = 20;
            this.chartPlati.Text = "chartPlati";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Location = new System.Drawing.Point(28, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 100);
            this.panel1.TabIndex = 22;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.BackColor = System.Drawing.SystemColors.Info;
            this.btnAfiseaza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAfiseaza.BackgroundImage")));
            this.btnAfiseaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseaza.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAfiseaza.Location = new System.Drawing.Point(28, 259);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(12);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(356, 49);
            this.btnAfiseaza.TabIndex = 23;
            this.btnAfiseaza.Text = "Trageti fisierul pentru afisarea in ListView";
            this.btnAfiseaza.UseVisualStyleBackColor = false;
            // 
            // btnPopulare
            // 
            this.btnPopulare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPopulare.BackgroundImage")));
            this.btnPopulare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnPopulare.Location = new System.Drawing.Point(28, 206);
            this.btnPopulare.Name = "btnPopulare";
            this.btnPopulare.Size = new System.Drawing.Size(356, 43);
            this.btnPopulare.TabIndex = 25;
            this.btnPopulare.Text = "Populare cu abonatii din baza de date";
            this.btnPopulare.UseVisualStyleBackColor = true;
            this.btnPopulare.Click += new System.EventHandler(this.btnPopulare_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Proiect_Tudose_Razvan.Client);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.btnPopulare);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chartPlati);
            this.Controls.Add(this.btnAfisareStudentiForm2);
            this.Controls.Add(this.lvAbonati);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaAbonatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaAbonatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeAbonatToolStripMenuItem;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ListView lvAbonati;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chPrenume;
        private System.Windows.Forms.ColumnHeader chTelefon;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chTipAbonament;
        private System.Windows.Forms.ColumnHeader chPlata;
        private System.Windows.Forms.ColumnHeader chExtraOptiuni;
        private System.Windows.Forms.Button btnAfisareStudentiForm2;
        private System.Windows.Forms.ColumnHeader chSuma;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlati;
        private System.Windows.Forms.ToolStripMenuItem graficPlatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoareToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnPopulare;
    }
}

