namespace MediciPacientiRT
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvMedici = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnAbsolvire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbMedici = new System.Windows.Forms.ListBox();
            this.tbMedic = new System.Windows.Forms.TextBox();
            this.tvMedici = new System.Windows.Forms.TreeView();
            this.lvPacienti = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCardSanatate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOcupatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.mediciToolStripMenuItem,
            this.despreAplicatieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuAplicatie";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareBinarToolStripMenuItem,
            this.restaurareBinarToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salvareBinarToolStripMenuItem.Text = "Salvare binar";
            // 
            // restaurareBinarToolStripMenuItem
            // 
            this.restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            this.restaurareBinarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restaurareBinarToolStripMenuItem.Text = "Restaurare binar";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.iesireToolStripMenuItem.Text = "Iesire";
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.mediciToolStripMenuItem.Text = "Medici";
            this.mediciToolStripMenuItem.Click += new System.EventHandler(this.mediciToolStripMenuItem_Click);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click_1);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // despreAplicatieToolStripMenuItem
            // 
            this.despreAplicatieToolStripMenuItem.Name = "despreAplicatieToolStripMenuItem";
            this.despreAplicatieToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.despreAplicatieToolStripMenuItem.Text = "Despre aplicatie";
            // 
            // lvMedici
            // 
            this.lvMedici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.CNP,
            this.AnAbsolvire,
            this.Specializare});
            this.lvMedici.HideSelection = false;
            this.lvMedici.Location = new System.Drawing.Point(24, 53);
            this.lvMedici.Name = "lvMedici";
            this.lvMedici.Size = new System.Drawing.Size(343, 191);
            this.lvMedici.TabIndex = 1;
            this.lvMedici.UseCompatibleStateImageBehavior = false;
            this.lvMedici.View = System.Windows.Forms.View.Details;
            this.lvMedici.SelectedIndexChanged += new System.EventHandler(this.lvMedici_SelectedIndexChanged);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 69;
            // 
            // CNP
            // 
            this.CNP.Text = "CNP";
            this.CNP.Width = 72;
            // 
            // AnAbsolvire
            // 
            this.AnAbsolvire.Text = "An absolvire";
            this.AnAbsolvire.Width = 90;
            // 
            // Specializare
            // 
            this.Specializare.Text = "Specializare";
            this.Specializare.Width = 88;
            // 
            // lbMedici
            // 
            this.lbMedici.FormattingEnabled = true;
            this.lbMedici.Location = new System.Drawing.Point(582, 320);
            this.lbMedici.Name = "lbMedici";
            this.lbMedici.Size = new System.Drawing.Size(177, 121);
            this.lbMedici.TabIndex = 2;
            // 
            // tbMedic
            // 
            this.tbMedic.Location = new System.Drawing.Point(24, 270);
            this.tbMedic.Name = "tbMedic";
            this.tbMedic.Size = new System.Drawing.Size(482, 20);
            this.tbMedic.TabIndex = 3;
            // 
            // tvMedici
            // 
            this.tvMedici.Location = new System.Drawing.Point(24, 320);
            this.tvMedici.Name = "tvMedici";
            this.tvMedici.Size = new System.Drawing.Size(163, 121);
            this.tvMedici.TabIndex = 4;
            // 
            // lvPacienti
            // 
            this.lvPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chCNP,
            this.chCardSanatate,
            this.chOcupatie});
            this.lvPacienti.HideSelection = false;
            this.lvPacienti.Location = new System.Drawing.Point(409, 53);
            this.lvPacienti.Name = "lvPacienti";
            this.lvPacienti.Size = new System.Drawing.Size(350, 191);
            this.lvPacienti.TabIndex = 5;
            this.lvPacienti.UseCompatibleStateImageBehavior = false;
            this.lvPacienti.View = System.Windows.Forms.View.Details;
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 100;
            // 
            // chCNP
            // 
            this.chCNP.Text = "CNP";
            this.chCNP.Width = 71;
            // 
            // chCardSanatate
            // 
            this.chCardSanatate.Text = "Card Sanatate";
            this.chCardSanatate.Width = 95;
            // 
            // chOcupatie
            // 
            this.chOcupatie.Text = "Ocupatie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvPacienti);
            this.Controls.Add(this.tvMedici);
            this.Controls.Add(this.tbMedic);
            this.Controls.Add(this.lbMedici);
            this.Controls.Add(this.lvMedici);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreAplicatieToolStripMenuItem;
        private System.Windows.Forms.ListView lvMedici;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader CNP;
        private System.Windows.Forms.ColumnHeader AnAbsolvire;
        private System.Windows.Forms.ColumnHeader Specializare;
        private System.Windows.Forms.ListBox lbMedici;
        private System.Windows.Forms.TextBox tbMedic;
        private System.Windows.Forms.TreeView tvMedici;
        private System.Windows.Forms.ListView lvPacienti;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chCNP;
        private System.Windows.Forms.ColumnHeader chCardSanatate;
        private System.Windows.Forms.ColumnHeader chOcupatie;
    }
}

