namespace gestiuneStudenti
{
    partial class FormStudent
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtFacultate = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAdaugaStudent = new System.Windows.Forms.Button();
            this.btnAfiseazaStudentii = new System.Windows.Forms.Button();
            this.txtAfisareStudenti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Facultate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(105, 18);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(240, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(105, 70);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(240, 20);
            this.txtNume.TabIndex = 5;
            // 
            // txtFacultate
            // 
            this.txtFacultate.Location = new System.Drawing.Point(105, 131);
            this.txtFacultate.Name = "txtFacultate";
            this.txtFacultate.Size = new System.Drawing.Size(240, 20);
            this.txtFacultate.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(105, 200);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(240, 20);
            this.txtNote.TabIndex = 7;
            // 
            // btnAdaugaStudent
            // 
            this.btnAdaugaStudent.Location = new System.Drawing.Point(15, 283);
            this.btnAdaugaStudent.Name = "btnAdaugaStudent";
            this.btnAdaugaStudent.Size = new System.Drawing.Size(103, 55);
            this.btnAdaugaStudent.TabIndex = 8;
            this.btnAdaugaStudent.Text = "Adauga Student";
            this.btnAdaugaStudent.UseVisualStyleBackColor = true;
            this.btnAdaugaStudent.Click += new System.EventHandler(this.btnAdaugaStudent_Click);
            // 
            // btnAfiseazaStudentii
            // 
            this.btnAfiseazaStudentii.Location = new System.Drawing.Point(375, 283);
            this.btnAfiseazaStudentii.Name = "btnAfiseazaStudentii";
            this.btnAfiseazaStudentii.Size = new System.Drawing.Size(110, 55);
            this.btnAfiseazaStudentii.TabIndex = 9;
            this.btnAfiseazaStudentii.Text = "Afiseaza studentii";
            this.btnAfiseazaStudentii.UseVisualStyleBackColor = true;
            this.btnAfiseazaStudentii.Click += new System.EventHandler(this.btnAfiseazaStudentii_Click);
            // 
            // txtAfisareStudenti
            // 
            this.txtAfisareStudenti.Location = new System.Drawing.Point(375, 362);
            this.txtAfisareStudenti.Multiline = true;
            this.txtAfisareStudenti.Name = "txtAfisareStudenti";
            this.txtAfisareStudenti.Size = new System.Drawing.Size(399, 20);
            this.txtAfisareStudenti.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAfisareStudenti);
            this.Controls.Add(this.btnAfiseazaStudentii);
            this.Controls.Add(this.btnAdaugaStudent);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtFacultate);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtFacultate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAdaugaStudent;
        private System.Windows.Forms.Button btnAfiseazaStudentii;
        private System.Windows.Forms.TextBox txtAfisareStudenti;
    }
}

