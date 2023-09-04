using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Timer
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_COMENZAR_Click(object sender, EventArgs e)
        {
            timer1.Start();
            LB_Estable.Visible = true;
            Lista.Visible = true;
            LB_Temperatura.Visible = true;
        }


        private void AgregarNumero()
        {
            // Modificar aleatorios
            int Alea = random.Next( 30 , 101);
            Lista.Items.Add(Alea);
           
            if ( Alea > 30 && Alea < 80 )
            {
                PIC.BackColor = Color.Green;
                LB_Estable.Text = "Temperatura Estable";
                contador++;
                if ( contador == 5)
                {
                    timer1.Stop();
                    MessageBox.Show(" Felicidades ");
                }
            }
            else
            {
                timer1.Stop();
                PIC.BackColor = Color.Red;
                LB_Estable.Text = "Temperatura NO ESTABLE";
                MessageBox.Show(" ERROR ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AgregarNumero();
        }
    }
}
