
namespace P06AplikacjaTypuWPF
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
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.numWzrost = new System.Windows.Forms.NumericUpDown();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 0;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 41);
            this.lbDane.Name = "lbDane";
            this.lbDane.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDane.Size = new System.Drawing.Size(265, 251);
            this.lbDane.TabIndex = 1;
            this.lbDane.SelectedIndexChanged += new System.EventHandler(this.lbDane_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(284, 41);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(284, 71);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 3;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(284, 101);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(387, 57);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(174, 20);
            this.txtImie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(387, 101);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(174, 20);
            this.txtNazwisko.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kraj";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(387, 143);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(174, 20);
            this.txtKraj.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data urodzenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Wzrost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Waga";
            // 
            // dtpDataUrodzenia
            // 
            this.dtpDataUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUrodzenia.Location = new System.Drawing.Point(387, 187);
            this.dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            this.dtpDataUrodzenia.Size = new System.Drawing.Size(174, 20);
            this.dtpDataUrodzenia.TabIndex = 17;
            // 
            // numWzrost
            // 
            this.numWzrost.Location = new System.Drawing.Point(387, 232);
            this.numWzrost.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numWzrost.Name = "numWzrost";
            this.numWzrost.Size = new System.Drawing.Size(174, 20);
            this.numWzrost.TabIndex = 18;
            // 
            // numWaga
            // 
            this.numWaga.Location = new System.Drawing.Point(387, 277);
            this.numWaga.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numWaga.Name = "numWaga";
            this.numWaga.Size = new System.Drawing.Size(174, 20);
            this.numWaga.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 309);
            this.Controls.Add(this.numWaga);
            this.Controls.Add(this.numWzrost);
            this.Controls.Add(this.dtpDataUrodzenia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lbDane);
            this.Controls.Add(this.btnWczytaj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
        private System.Windows.Forms.NumericUpDown numWzrost;
        private System.Windows.Forms.NumericUpDown numWaga;
    }
}

