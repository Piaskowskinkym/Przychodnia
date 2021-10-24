
namespace Przychodnia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbBadanie = new System.Windows.Forms.TextBox();
            this.dTPdata = new System.Windows.Forms.DateTimePicker();
            this.lImie = new System.Windows.Forms.Label();
            this.lBadanie = new System.Windows.Forms.Label();
            this.lData = new System.Windows.Forms.Label();
            this.lDataTeraz = new System.Windows.Forms.Label();
            this.lGodzinaTeraz = new System.Windows.Forms.Label();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.lb1imie = new System.Windows.Forms.Label();
            this.lb1badanie = new System.Windows.Forms.Label();
            this.lb1data = new System.Windows.Forms.Label();
            this.lBlad = new System.Windows.Forms.Label();
            this.bPrzod = new System.Windows.Forms.Button();
            this.pTyl = new System.Windows.Forms.Button();
            this.bUsun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb0imie = new System.Windows.Forms.Label();
            this.lb0badanie = new System.Windows.Forms.Label();
            this.lb0data = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb2imie = new System.Windows.Forms.Label();
            this.lb2badanie = new System.Windows.Forms.Label();
            this.lb2data = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bDodaj
            // 
            this.bDodaj.Location = new System.Drawing.Point(444, 35);
            this.bDodaj.Name = "bDodaj";
            this.bDodaj.Size = new System.Drawing.Size(174, 23);
            this.bDodaj.TabIndex = 0;
            this.bDodaj.Text = "Zarejestruj";
            this.bDodaj.UseVisualStyleBackColor = true;
            this.bDodaj.Click += new System.EventHandler(this.bDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(25, 34);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(100, 20);
            this.tbImie.TabIndex = 2;
            // 
            // tbBadanie
            // 
            this.tbBadanie.Location = new System.Drawing.Point(131, 34);
            this.tbBadanie.Name = "tbBadanie";
            this.tbBadanie.Size = new System.Drawing.Size(100, 20);
            this.tbBadanie.TabIndex = 3;
            // 
            // dTPdata
            // 
            this.dTPdata.Location = new System.Drawing.Point(238, 34);
            this.dTPdata.Name = "dTPdata";
            this.dTPdata.Size = new System.Drawing.Size(200, 20);
            this.dTPdata.TabIndex = 4;
            this.dTPdata.Value = new System.DateTime(2021, 10, 22, 12, 14, 59, 0);
            this.dTPdata.ValueChanged += new System.EventHandler(this.dTPdata_ValueChanged);
            // 
            // lImie
            // 
            this.lImie.AutoSize = true;
            this.lImie.Location = new System.Drawing.Point(22, 18);
            this.lImie.Name = "lImie";
            this.lImie.Size = new System.Drawing.Size(26, 13);
            this.lImie.TabIndex = 5;
            this.lImie.Text = "Imie";
            // 
            // lBadanie
            // 
            this.lBadanie.AutoSize = true;
            this.lBadanie.Location = new System.Drawing.Point(128, 18);
            this.lBadanie.Name = "lBadanie";
            this.lBadanie.Size = new System.Drawing.Size(82, 13);
            this.lBadanie.TabIndex = 6;
            this.lBadanie.Text = "Nazwa Badania";
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(235, 18);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(72, 13);
            this.lData.TabIndex = 7;
            this.lData.Text = "Data Badania";
            // 
            // lDataTeraz
            // 
            this.lDataTeraz.AutoSize = true;
            this.lDataTeraz.Location = new System.Drawing.Point(13, 358);
            this.lDataTeraz.Name = "lDataTeraz";
            this.lDataTeraz.Size = new System.Drawing.Size(28, 13);
            this.lDataTeraz.TabIndex = 8;
            this.lDataTeraz.Text = "data";
            this.lDataTeraz.Click += new System.EventHandler(this.lDataTeraz_Click);
            // 
            // lGodzinaTeraz
            // 
            this.lGodzinaTeraz.AutoSize = true;
            this.lGodzinaTeraz.Location = new System.Drawing.Point(90, 358);
            this.lGodzinaTeraz.Name = "lGodzinaTeraz";
            this.lGodzinaTeraz.Size = new System.Drawing.Size(29, 13);
            this.lGodzinaTeraz.TabIndex = 9;
            this.lGodzinaTeraz.Text = "czas";
            // 
            // tTimer
            // 
            this.tTimer.Enabled = true;
            this.tTimer.Interval = 10000;
            this.tTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb1imie
            // 
            this.lb1imie.AutoSize = true;
            this.lb1imie.Location = new System.Drawing.Point(116, 177);
            this.lb1imie.Name = "lb1imie";
            this.lb1imie.Size = new System.Drawing.Size(25, 13);
            this.lb1imie.TabIndex = 10;
            this.lb1imie.Text = "imie";
            this.lb1imie.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb1badanie
            // 
            this.lb1badanie.AutoSize = true;
            this.lb1badanie.Location = new System.Drawing.Point(201, 177);
            this.lb1badanie.Name = "lb1badanie";
            this.lb1badanie.Size = new System.Drawing.Size(45, 13);
            this.lb1badanie.TabIndex = 11;
            this.lb1badanie.Text = "badanie";
            // 
            // lb1data
            // 
            this.lb1data.AutoSize = true;
            this.lb1data.Location = new System.Drawing.Point(272, 177);
            this.lb1data.Name = "lb1data";
            this.lb1data.Size = new System.Drawing.Size(28, 13);
            this.lb1data.TabIndex = 12;
            this.lb1data.Text = "data";
            // 
            // lBlad
            // 
            this.lBlad.AutoSize = true;
            this.lBlad.Location = new System.Drawing.Point(235, 358);
            this.lBlad.Name = "lBlad";
            this.lBlad.Size = new System.Drawing.Size(35, 13);
            this.lBlad.TabIndex = 13;
            this.lBlad.Text = "label2";
            // 
            // bPrzod
            // 
            this.bPrzod.Location = new System.Drawing.Point(204, 257);
            this.bPrzod.Name = "bPrzod";
            this.bPrzod.Size = new System.Drawing.Size(75, 23);
            this.bPrzod.TabIndex = 14;
            this.bPrzod.Text = ">";
            this.bPrzod.UseVisualStyleBackColor = true;
            this.bPrzod.Click += new System.EventHandler(this.bPrzod_Click);
            // 
            // pTyl
            // 
            this.pTyl.Location = new System.Drawing.Point(76, 257);
            this.pTyl.Name = "pTyl";
            this.pTyl.Size = new System.Drawing.Size(75, 23);
            this.pTyl.TabIndex = 15;
            this.pTyl.Text = "<";
            this.pTyl.UseVisualStyleBackColor = true;
            this.pTyl.Click += new System.EventHandler(this.pTyl_Click);
            // 
            // bUsun
            // 
            this.bUsun.Location = new System.Drawing.Point(444, 78);
            this.bUsun.Name = "bUsun";
            this.bUsun.Size = new System.Drawing.Size(174, 23);
            this.bUsun.TabIndex = 16;
            this.bUsun.Text = "Usuń";
            this.bUsun.UseVisualStyleBackColor = true;
            this.bUsun.Click += new System.EventHandler(this.bUsun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Obecna :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Poprzednia :";
            // 
            // lb0imie
            // 
            this.lb0imie.AutoSize = true;
            this.lb0imie.Location = new System.Drawing.Point(116, 143);
            this.lb0imie.Name = "lb0imie";
            this.lb0imie.Size = new System.Drawing.Size(25, 13);
            this.lb0imie.TabIndex = 19;
            this.lb0imie.Text = "imie";
            // 
            // lb0badanie
            // 
            this.lb0badanie.AutoSize = true;
            this.lb0badanie.Location = new System.Drawing.Point(201, 143);
            this.lb0badanie.Name = "lb0badanie";
            this.lb0badanie.Size = new System.Drawing.Size(45, 13);
            this.lb0badanie.TabIndex = 20;
            this.lb0badanie.Text = "badanie";
            // 
            // lb0data
            // 
            this.lb0data.AutoSize = true;
            this.lb0data.Location = new System.Drawing.Point(273, 143);
            this.lb0data.Name = "lb0data";
            this.lb0data.Size = new System.Drawing.Size(28, 13);
            this.lb0data.TabIndex = 21;
            this.lb0data.Text = "data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Następna :";
            // 
            // lb2imie
            // 
            this.lb2imie.AutoSize = true;
            this.lb2imie.Location = new System.Drawing.Point(116, 216);
            this.lb2imie.Name = "lb2imie";
            this.lb2imie.Size = new System.Drawing.Size(25, 13);
            this.lb2imie.TabIndex = 23;
            this.lb2imie.Text = "imie";
            // 
            // lb2badanie
            // 
            this.lb2badanie.AutoSize = true;
            this.lb2badanie.Location = new System.Drawing.Point(201, 216);
            this.lb2badanie.Name = "lb2badanie";
            this.lb2badanie.Size = new System.Drawing.Size(45, 13);
            this.lb2badanie.TabIndex = 24;
            this.lb2badanie.Text = "badanie";
            // 
            // lb2data
            // 
            this.lb2data.AutoSize = true;
            this.lb2data.Location = new System.Drawing.Point(272, 216);
            this.lb2data.Name = "lb2data";
            this.lb2data.Size = new System.Drawing.Size(28, 13);
            this.lb2data.TabIndex = 25;
            this.lb2data.Text = "data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "label7";
            // 
            // bZapisz
            // 
            this.bZapisz.Location = new System.Drawing.Point(444, 119);
            this.bZapisz.Name = "bZapisz";
            this.bZapisz.Size = new System.Drawing.Size(174, 23);
            this.bZapisz.TabIndex = 29;
            this.bZapisz.Text = "Zapisz";
            this.bZapisz.UseVisualStyleBackColor = true;
            this.bZapisz.Click += new System.EventHandler(this.bZapisz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 383);
            this.Controls.Add(this.bZapisz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb2data);
            this.Controls.Add(this.lb2badanie);
            this.Controls.Add(this.lb2imie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb0data);
            this.Controls.Add(this.lb0badanie);
            this.Controls.Add(this.lb0imie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bUsun);
            this.Controls.Add(this.pTyl);
            this.Controls.Add(this.bPrzod);
            this.Controls.Add(this.lBlad);
            this.Controls.Add(this.lb1data);
            this.Controls.Add(this.lb1badanie);
            this.Controls.Add(this.lb1imie);
            this.Controls.Add(this.lGodzinaTeraz);
            this.Controls.Add(this.lDataTeraz);
            this.Controls.Add(this.lData);
            this.Controls.Add(this.lBadanie);
            this.Controls.Add(this.lImie);
            this.Controls.Add(this.dTPdata);
            this.Controls.Add(this.tbBadanie);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbBadanie;
        private System.Windows.Forms.DateTimePicker dTPdata;
        private System.Windows.Forms.Label lImie;
        private System.Windows.Forms.Label lBadanie;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.Label lDataTeraz;
        private System.Windows.Forms.Label lGodzinaTeraz;
        private System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.Label lb1imie;
        private System.Windows.Forms.Label lb1badanie;
        private System.Windows.Forms.Label lb1data;
        private System.Windows.Forms.Label lBlad;
        private System.Windows.Forms.Button bPrzod;
        private System.Windows.Forms.Button pTyl;
        private System.Windows.Forms.Button bUsun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb0imie;
        private System.Windows.Forms.Label lb0badanie;
        private System.Windows.Forms.Label lb0data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb2imie;
        private System.Windows.Forms.Label lb2badanie;
        private System.Windows.Forms.Label lb2data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bZapisz;
    }
}

