using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{

    public partial class Form1 : Form
    {
        private string databadania;
        private string terazData;
        private string terazCzas;
       

        public Form1()
        {
            InitializeComponent();
        }
        string[] kolejka = new string[100];
        int poczatek = -1;
        int koniec = -1;
        int r = 100;
        int pozycja = 3;
       
        void Insert(string imie, string badanie, string data)
        {
            if(koniec == r - 1)
            {
                lBlad.Text = "TABLICA PRZEPEŁNIONA!";
            }
            else
            {
                if(poczatek == - 1)
                {
                    koniec++;
                    kolejka[koniec] = imie;
                    koniec++;
                    kolejka[koniec] = badanie;
                    koniec++;
                    kolejka[koniec] = data;
                  
                    
                }
            }
        }
        void Delete()
        {
            
                poczatek = +3;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTime Date = DateTime.Today;
            DateTime Time = DateTime.Now;
            terazCzas = Time.ToString("hh:mm");
            terazData =  Date.ToString("d");
            lDataTeraz.Text = terazData;
            lGodzinaTeraz.Text = terazCzas;

        }

        private void bDodaj_Click(object sender, EventArgs e)
        {
            
           
            string imie = tbImie.Text;
            string badanie = tbBadanie.Text;
            string data = dTPdata.Value.ToString("yyyy-MM-dd");
            Insert(imie,badanie,data);
            Display();
        }

        private void lDataTeraz_Click(object sender, EventArgs e)
        {

        }

        private void dTPdata_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void pTyl_Click(object sender, EventArgs e)
        {
           
        }

        private void bPrzod_Click(object sender, EventArgs e)
        {
            lp1imie.Text = kolejka[0 + pozycja];
            lp1nazwab.Text = kolejka[1 + pozycja];
            lp1data.Text = kolejka[2 + pozycja];
            pozycja += 3;
        }

        private void bUsun_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
