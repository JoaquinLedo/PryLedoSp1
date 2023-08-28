using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace PryLedoSp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnArchivo_Click(object sender, EventArgs e)
        {
            try 
            {
                StreamWriter swCrearArchivo = new StreamWriter("MiArchivito", false);
                MessageBox.Show("Archivo Creado");

                
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }


        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("MiArchivito", true);
                swCrearArchivo.WriteLine(Txt.Text);
                swCrearArchivo.Close();
                MessageBox.Show("Guardando");


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }

        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            StreamReader swCrearArchivo = new StreamReader("MiArchivito");

            while(swCrearArchivo.EndOfStream==false)
            {
                Txt.Text += swCrearArchivo.ReadLine();
            }
        }
    }
}
