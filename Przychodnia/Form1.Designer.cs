
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
            this.lp1imie = new System.Windows.Forms.Label();
            this.lp1nazwab = new System.Windows.Forms.Label();
            this.lp1data = new System.Windows.Forms.Label();
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
            // lp1imie
            // 
            this.lp1imie.AutoSize = true;
            this.lp1imie.Location = new System.Drawing.Point(35, 128);
            this.lp1imie.Name = "lp1imie";
            this.lp1imie.Size = new System.Drawing.Size(35, 13);
            this.lp1imie.TabIndex = 10;
            this.lp1imie.Text = "label2";
            this.lp1imie.Click += new System.EventHandler(this.label2_Click);
            // 
            // lp1nazwab
            // 
            this.lp1nazwab.AutoSize = true;
            this.lp1nazwab.Location = new System.Drawing.Point(128, 128);
            this.lp1nazwab.Name = "lp1nazwab";
            this.lp1nazwab.Size = new System.Drawing.Size(35, 13);
            this.lp1nazwab.TabIndex = 11;
            this.lp1nazwab.Text = "label3";
            // 
            // lp1data
            // 
            this.lp1data.AutoSize = true;
            this.lp1data.Location = new System.Drawing.Point(235, 128);
            this.lp1data.Name = "lp1data";
            this.lp1data.Size = new System.Drawing.Size(35, 13);
            this.lp1data.TabIndex = 12;
            this.lp1data.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 383);
            this.Controls.Add(this.lp1data);
            this.Controls.Add(this.lp1nazwab);
            this.Controls.Add(this.lp1imie);
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
        private System.Windows.Forms.Label lp1imie;
        private System.Windows.Forms.Label lp1nazwab;
        private System.Windows.Forms.Label lp1data;
    }
}

