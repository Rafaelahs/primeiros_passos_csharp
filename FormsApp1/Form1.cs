using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
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

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnn_Click(object sender, EventArgs e)
        {
            { // // short  -32,786, 32,897
              // short idade = 56;
              ////
              // int valoresMenor = 17;
              // long valorGrande = 3216954785646;

                // //byte = 0 a 225
                // byte idades = 255;

                // //
                // float valorVirgula = 10.5f;
                // double valorVirgula1 = 10.7;
                // decimal valorVirgula2 = 15.6m;

                //double valorVirgula2 = (double)1 / 2;
                //caixatxt.Text = valorVirgula2.ToString();


                // ALFANUMERICAS
                //string nome = "123+65 = " + 48 + 20;

                //int p1 = 10;
                //int p2 = 25;
                //string resultado = p1.ToString() + "+" + p2.ToString() + "=" + ( p1 + p2);
                //caixatxt.Text = resultado;  


                //string resultado = "Rafaela";

                //int numeroCaractere = resultado.Length;
                //caixatxt.Text = "Nº caracteres =" + numeroCaractere;


            }
            int parcelaa1 = int.Parse(parcela1.Text);
            int parcelaa2 = int.Parse(parcela2.Text);
            string po = "+";
            label2.Text = po.ToString();
             
            int resultado;
          

            resultado = parcelaa1 + parcelaa2;

            caixatxt.Text ="O resultado é: " + resultado.ToString();







        }
    }
}
