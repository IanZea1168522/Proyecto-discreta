using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_matemática_discreta_II
{
    

    public partial class Form1 : Form
    {

        //variables globales
        string usuario1, usuario2;
        string nombre1, nombre2;
        string apellido1, apellido2;
        int edad1, edad2;
        bool dosP;
        //para saber el valor del grafo
        int currentColor = 0;
        //para el grafo en difícil
        int VD1, VD2, VD3, VD4, VD5, VD6, VD7, VD8, VD9, VD10;

        private void pictureBoxV5_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR5.Visible = true;
                VD5 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA5.Visible = true;
                VD5 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV5.Visible = true;
                VD5 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pictureBoxV6_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR6.Visible = true;
                VD6 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA6.Visible = true;
                VD6 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV6.Visible = true;
                VD6 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pictureBoxV7_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR7.Visible = true;
                VD7 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA7.Visible = true;
                VD7 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV7.Visible = true;
                VD7 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pictureBoxV8_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR8.Visible = true;
                VD8 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA8.Visible = true;
                VD8 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV8.Visible = true;
                VD8 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pictureBoxV9_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR9.Visible = true;
                VD9 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA9.Visible = true;
                VD9 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV9.Visible = true;
                VD9 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pictureBoxV10_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR10.Visible = true;
                VD10 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA10.Visible = true;
                VD10 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV10.Visible = true;
                VD10 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pictureBoxV4_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR4.Visible = true;
                VD4 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA4.Visible = true;
                VD4 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV4.Visible = true;
                VD4 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pictureBoxV3_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR3.Visible = true;
                VD3 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA3.Visible = true;
                VD3 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV3.Visible = true;
                VD3 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pictureBoxV2_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR2.Visible = true;
                VD2 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA2.Visible = true;
                VD2 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV2.Visible = true;
                VD2 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentColor = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentColor = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentColor = 1;
        }

        private void pictureBoxV1_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pictureBoxVR1.Visible = true;
                VD1 = 1;
            }
            else if (currentColor == 2)
            {
                pictureBoxVA1.Visible = true;
                VD1 = 2;
            }
            else if (currentColor == 3)
            {
                pictureBoxVV1.Visible = true;
                VD1 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //try/catch en caso de error
            try
            {
                //se asignan los valores a las variables
                nombre1 = textBoxNombre.Text;
                apellido1 = textBoxApellido.Text;
                usuario1 = textBoxUsuario.Text;
                edad1 = Convert.ToInt32(textBox1.Text);
                nombre2 = textBox5.Text;
                apellido2 = textBox4.Text;
                usuario2 = textBox3.Text;
                edad2 = Convert.ToInt32(textBox2.Text);
                //se comprueba si tiene la edad o no
                if(edad1 >= 18 && edad2 >= 18)
                {
                    //puede proceder a elegir el juego
                    button8.Enabled = false;
                    button2.Enabled = true;
                    button1.Enabled = true;
                    textBoxNombre.Enabled = false;
                    textBoxApellido.Enabled = false;
                    textBoxUsuario.Enabled = false;
                    textBox1.Enabled = false;
                }
                else
                {
                    //se indica que no puede
                    MessageBox.Show("Edad insuficiente para jugar");
                }
            }
            catch
            {
                //aparece mensaje de error
                MessageBox.Show("Datos ingresados erróneos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se mueven las pestañas y se habilitan/deshabilitan botones
            tabControl1.SelectedIndex = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //se mueven las pestañas y se habilitan/deshabilitan botones
            tabControl1.SelectedIndex = 2;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //se juega contra la máquina
                dosP = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
            else
            { 
                //juega contra jugadores por lo que se habilita la entrada de datos del segundo jugador
                dosP = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
            }
        }
    }
}
