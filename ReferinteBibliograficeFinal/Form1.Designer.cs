namespace ReferinteBibliograficeFinal
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
            this.carteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPublicatii = new System.Windows.Forms.TextBox();
            this.txtAutori = new System.Windows.Forms.TextBox();
            this.lvPublicatii = new System.Windows.Forms.ListView();
            this.lbAutori = new System.Windows.Forms.ListBox();
            this.Titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Detalii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carteToolStripMenuItem
            // 
            this.carteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem});
            this.carteToolStripMenuItem.Name = "carteToolStripMenuItem";
            this.carteToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.carteToolStripMenuItem.Text = "Carte";
            this.carteToolStripMenuItem.Click += new System.EventHandler(this.carteToolStripMenuItem_Click);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // txtPublicatii
            // 
            this.txtPublicatii.Location = new System.Drawing.Point(139, 380);
            this.txtPublicatii.Multiline = true;
            this.txtPublicatii.Name = "txtPublicatii";
            this.txtPublicatii.Size = new System.Drawing.Size(100, 20);
            this.txtPublicatii.TabIndex = 1;
            // 
            // txtAutori
            // 
            this.txtAutori.Location = new System.Drawing.Point(545, 380);
            this.txtAutori.Multiline = true;
            this.txtAutori.Name = "txtAutori";
            this.txtAutori.Size = new System.Drawing.Size(100, 20);
            this.txtAutori.TabIndex = 2;
            // 
            // lvPublicatii
            // 
            this.lvPublicatii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titlu,
            this.Detalii});
            this.lvPublicatii.HideSelection = false;
            this.lvPublicatii.Location = new System.Drawing.Point(51, 86);
            this.lvPublicatii.Name = "lvPublicatii";
            this.lvPublicatii.Size = new System.Drawing.Size(227, 168);
            this.lvPublicatii.TabIndex = 3;
            this.lvPublicatii.UseCompatibleStateImageBehavior = false;
            this.lvPublicatii.View = System.Windows.Forms.View.Details;
            this.lvPublicatii.SelectedIndexChanged += new System.EventHandler(this.lvPublicatii_SelectedIndexChanged);
            // 
            // lbAutori
            // 
            this.lbAutori.FormattingEnabled = true;
            this.lbAutori.Location = new System.Drawing.Point(545, 112);
            this.lbAutori.Name = "lbAutori";
            this.lbAutori.Size = new System.Drawing.Size(120, 95);
            this.lbAutori.TabIndex = 5;
            // 
            // Titlu
            // 
            this.Titlu.Text = "Titlu";
            this.Titlu.Width = 115;
            // 
            // Detalii
            // 
            this.Detalii.Text = "Detalii";
            this.Detalii.Width = 104;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAutori);
            this.Controls.Add(this.lvPublicatii);
            this.Controls.Add(this.txtAutori);
            this.Controls.Add(this.txtPublicatii);
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
        private System.Windows.Forms.ToolStripMenuItem carteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPublicatii;
        private System.Windows.Forms.TextBox txtAutori;
        private System.Windows.Forms.ListView lvPublicatii;
        private System.Windows.Forms.ColumnHeader Titlu;
        private System.Windows.Forms.ColumnHeader Detalii;
        private System.Windows.Forms.ListBox lbAutori;
    }
}

