namespace MediciPacientiRT
{
    partial class FormMedic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.cbSpec = new System.Windows.Forms.ComboBox();
            this.dateDataNastere = new System.Windows.Forms.DateTimePicker();
            this.adaugaBtn = new System.Windows.Forms.Button();
            this.renuntaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "An absolvire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Specializare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data nastere";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(131, 58);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(200, 20);
            this.tbNume.TabIndex = 5;
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(131, 172);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(200, 20);
            this.tbAn.TabIndex = 7;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(131, 117);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(200, 20);
            this.tbCNP.TabIndex = 8;
            this.tbCNP.Validating += new System.ComponentModel.CancelEventHandler(this.tbCNP_Validating);
            // 
            // cbSpec
            // 
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Items.AddRange(new object[] {
            "Chirurgie",
            "Chirurgie plastica",
            "Neurologie",
            "Cardiologie",
            "Ginecologie"});
            this.cbSpec.Location = new System.Drawing.Point(131, 233);
            this.cbSpec.Name = "cbSpec";
            this.cbSpec.Size = new System.Drawing.Size(200, 21);
            this.cbSpec.TabIndex = 9;
            // 
            // dateDataNastere
            // 
            this.dateDataNastere.Location = new System.Drawing.Point(131, 288);
            this.dateDataNastere.Name = "dateDataNastere";
            this.dateDataNastere.Size = new System.Drawing.Size(200, 20);
            this.dateDataNastere.TabIndex = 10;
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.Location = new System.Drawing.Point(63, 345);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(89, 48);
            this.adaugaBtn.TabIndex = 11;
            this.adaugaBtn.Text = "Adauga";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            this.adaugaBtn.Click += new System.EventHandler(this.adaugaBtn_Click);
            // 
            // renuntaBtn
            // 
            this.renuntaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.renuntaBtn.Location = new System.Drawing.Point(231, 345);
            this.renuntaBtn.Name = "renuntaBtn";
            this.renuntaBtn.Size = new System.Drawing.Size(100, 48);
            this.renuntaBtn.TabIndex = 12;
            this.renuntaBtn.Text = "Renunta";
            this.renuntaBtn.UseVisualStyleBackColor = false;
            // 
            // FormMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renuntaBtn);
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.dateDataNastere);
            this.Controls.Add(this.cbSpec);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbAn);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMedic";
            this.Text = "FormMedic";
            this.Load += new System.EventHandler(this.FormMedic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.ComboBox cbSpec;
        private System.Windows.Forms.DateTimePicker dateDataNastere;
        private System.Windows.Forms.Button adaugaBtn;
        private System.Windows.Forms.Button renuntaBtn;
    }
}