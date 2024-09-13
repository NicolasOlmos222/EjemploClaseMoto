using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Moto MiMoto = new Moto("Rouser", "Negro", 17000);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiMoto.Encender();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MiMoto.Apagar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textVelocidad.Text, out int velocidad);
            MiMoto.Acelerar(velocidad);
            label1.Text = "La velocidad actual es: " + MiMoto.MostrarVelocidad().ToString();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            int velocidad = MiMoto.MostrarVelocidad();
            MessageBox.Show("Velocidad: "+ velocidad);
        }
    }
}
