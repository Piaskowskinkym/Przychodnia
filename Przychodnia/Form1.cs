﻿using System;
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
        private string terazData;
        private string terazCzas;
        struct Dane
        {
            string Imie;
            string Badanie;
            DateTime Wizyta;

        }

        public Form1()
        {
            InitializeComponent();
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
            
            
           
            
        }
    }
}
