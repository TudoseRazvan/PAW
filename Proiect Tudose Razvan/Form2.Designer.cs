namespace Proiect_Tudose_Razvan
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tbClienti = new System.Windows.Forms.TextBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareInFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareInFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbClienti
            // 
            this.tbClienti.Location = new System.Drawing.Point(72, 121);
            this.tbClienti.Margin = new System.Windows.Forms.Padding(4);
            this.tbClienti.Multiline = true;
            this.tbClienti.Name = "tbClienti";
            this.tbClienti.Size = new System.Drawing.Size(774, 226);
            this.tbClienti.TabIndex = 2;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.BackColor = System.Drawing.SystemColors.Info;
            this.btnAfiseaza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAfiseaza.BackgroundImage")));
            this.btnAfiseaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseaza.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAfiseaza.Location = new System.Drawing.Point(72, 47);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(12);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(211, 49);
            this.btnAfiseaza.TabIndex = 3;
            this.btnAfiseaza.Text = "Afisare abonati";
            this.btnAfiseaza.UseVisualStyleBackColor = false;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareTXT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvareTXT
            // 
            this.salvareTXT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareInFisierTextToolStripMenuItem,
            this.deschidereFisierTextToolStripMenuItem,
            this.salvareInFisierBinarToolStripMenuItem,
            this.deschidereFisierBinarToolStripMenuItem});
            this.salvareTXT.Name = "salvareTXT";
            this.salvareTXT.Size = new System.Drawing.Size(37, 20);
            this.salvareTXT.Text = "File";
            // 
            // salvareInFisierTextToolStripMenuItem
            // 
            this.salvareInFisierTextToolStripMenuItem.Name = "salvareInFisierTextToolStripMenuItem";
            this.salvareInFisierTextToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.salvareInFisierTextToolStripMenuItem.Text = "Salvare in fisier text";
            this.salvareInFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salvareInFisierTextToolStripMenuItem_Click);
            // 
            // deschidereFisierTextToolStripMenuItem
            // 
            this.deschidereFisierTextToolStripMenuItem.Name = "deschidereFisierTextToolStripMenuItem";
            this.deschidereFisierTextToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deschidereFisierTextToolStripMenuItem.Text = "Deschidere fisier text";
            this.deschidereFisierTextToolStripMenuItem.Click += new System.EventHandler(this.deschidereFisierTextToolStripMenuItem_Click);
            // 
            // salvareInFisierBinarToolStripMenuItem
            // 
            this.salvareInFisierBinarToolStripMenuItem.Name = "salvareInFisierBinarToolStripMenuItem";
            this.salvareInFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.salvareInFisierBinarToolStripMenuItem.Text = "Salvare in fisier binar";
            this.salvareInFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareInFisierBinarToolStripMenuItem_Click);
            // 
            // deschidereFisierBinarToolStripMenuItem
            // 
            this.deschidereFisierBinarToolStripMenuItem.Name = "deschidereFisierBinarToolStripMenuItem";
            this.deschidereFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deschidereFisierBinarToolStripMenuItem.Text = "Deschidere fisier binar";
            this.deschidereFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.deschidereFisierBinarToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.tbClienti);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClienti;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareTXT;
        private System.Windows.Forms.ToolStripMenuItem salvareInFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareInFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereFisierBinarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}