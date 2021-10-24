using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Przychodnia
{

    public partial class Form1 : Form
    {
        
        private string terazData;
        private string terazCzas;
        const int pojemnosc = 100;
        string[] kolejka = new string[pojemnosc];
        int  rozmiar = 0;
        int r = 100;

        int p0 = 0;
        int p1 = 1;
        int p2 = 2;


        public Form1()
        {
            InitializeComponent();
        }


        void Insert(string imie, string badanie, string data)
        {
            if (rozmiar > pojemnosc)
            {
                lBlad.Text = "KOLEJKA PRZEPEŁNIONA!";
            }
            else
            {
                kolejka[rozmiar++] = imie;
                kolejka[rozmiar++] = badanie;
                kolejka[rozmiar++] = data;
            }
        }
        void Delete()
        {
            if(rozmiar != 0)
            {
                for (int i = 0; i < 3 ; i++)
                    kolejka[0] = kolejka[i + 3];
                rozmiar--;
            }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime Date = DateTime.Today;
            DateTime Time = DateTime.Now;
            terazCzas = Time.ToString("hh:mm");
            terazData = Date.ToString("d");
            lDataTeraz.Text = terazData;
            lGodzinaTeraz.Text = terazCzas;

        }

        private void bDodaj_Click(object sender, EventArgs e)
        {


            string imie = tbImie.Text;
            string badanie = tbBadanie.Text;
            string data = dTPdata.Value.ToString("d");
            Insert(imie, badanie, data);

        /*
            lb1imie.Text = kolejka[0];
            lb1badanie.Text = kolejka[1];
            lb1data.Text = kolejka[2];

            */
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
            if (p0 == 3)
            {
                lBlad.Text = "Jesteś na pierwszym polu kolejki";
                
            }
            else
            {
                p0 -= 3;
                p1 -= 3;
                p2 -= 3;
                //poprzedni
                lb0imie.Text = kolejka[p0 - 3];
                lb0badanie.Text = kolejka[p1 - 3];
                lb0data.Text = kolejka[p2 - 3];
                
                //obecny
                lb1imie.Text = kolejka[p0];
                lb1badanie.Text = kolejka[p1];
                if (kolejka[p2] == terazData)
                {
                    lb1data.Text = kolejka[p2];
                    lb1data.ForeColor = System.Drawing.Color.Red;
                    
                }
                else
                {
                    lb1data.Text = kolejka[p2];
                }
                //następny
                lb2imie.Text = kolejka[p0+3];
                lb2badanie.Text = kolejka[p1+3];
                lb2data.Text = kolejka[p2+3];
                
                label5.Text = p0.ToString();
                label6.Text = p1.ToString();
                label7.Text = p2.ToString();
            }
        }

        private void bPrzod_Click(object sender, EventArgs e)
        {
            p0 += 3;
            p1 += 3;
            p2 += 3;
            //poprzedni
            lb0imie.Text = kolejka[p0-3];
            lb0badanie.Text=kolejka[p1-3];
            lb0data.Text = kolejka[p2-3];
            //obecny
            lb1imie.Text = kolejka[p0];
            lb1badanie.Text = kolejka[p1];
            if (kolejka[p2] == terazData)
            {
                lb1data.Text = kolejka[p2];
                lb1data.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                lb1data.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lb1data.ForeColor = System.Drawing.Color.Black;
                lb1data.Text =  kolejka[p2];
            }
            //następny
            lb2imie.Text = kolejka[p0 + 3];
            lb2badanie.Text = kolejka[p1 + 3];
            lb2data.Text = kolejka[p2 + 3];
           
            label5.Text = p0.ToString();
            label6.Text = p1.ToString();
            label7.Text = p2.ToString();

        }

        private void bUsun_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void bZapisz_Click(object sender, EventArgs e)
        {
                    File.WriteAllLines("przychodnia.txt", kolejka);
        }
    }
}
      
