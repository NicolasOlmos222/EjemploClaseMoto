using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    internal class Moto
    {
            private string marca;
            private int velocidad;
            private string color;
            private int kilometraje;

            public string Marca
            {
                set
                {
                    marca = value;
                }
                get
                {
                    return marca;
                }
            }
            public string Color
            {
                set
                {
                    color = value;
                }
                get
                {
                    return color;
                }
            }
            public int Kilometraje
            {
                set
                {
                    kilometraje = value;
                }
                get
                {
                    return kilometraje;
                }
            }

            public int Velocidad
            {
                set
                {
                    velocidad = value;
                }
                get
                {
                    return velocidad;
                }
            }

            public Moto(string marca, string color, int kilometraje)
            {
                Marca = marca;
                Color = color;
                Kilometraje = kilometraje;
                Velocidad = 0;
            }

            public void Encender()
            {
                MessageBox.Show("Prendio la moto");
            }

            public void Apagar()
            {
                MessageBox.Show("Apago la moto");
            }

            public void Acelerar(int nuevaVelocidad)
            {
                Velocidad = nuevaVelocidad;
            }

            public int MostrarVelocidad()
            {
                return Velocidad;
            }

            public void Frenar()
            {
                Velocidad = 0;
            }
        }
    
}
