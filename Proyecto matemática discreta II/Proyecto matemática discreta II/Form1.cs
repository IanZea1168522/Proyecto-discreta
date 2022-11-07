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
        int VD1, VD2, VD3, VD4, VD5, VD6, VD7, VD8, VD9, VD10 = 0;
        int VF1, VF2, VF3, VF4, VF5, VF6 = 0;

        private void pictureBoxV5_Click(object sender, EventArgs e)
        {
            //Se muestra el color dependiendo de lo elegido por el usuario
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
            //se reinicia el valor
            currentColor = 0;
            //se comprueba se se perdió 2
            if (VD5 != 0 && (VD5 == VD1 || VD5 == VD10 || VD5 == VD4))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD10 == 0 && VD10 != VD5 && VD10 != VD7 && VD8 != VD10 && VD5 != VD8 && VD5 != VD7 && VD7 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD4 == 0 && VD4 != VD3 && VD4 != VD5 && VD4 != VD9 && VD3 != VD9 && VD3 != VD5 && VD5 != VD9)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se se ganó 
            if (VD1 == 0 && VD2 != VD5 && VD2 != VD6 && VD5 != VD6 && VD2 != VD1 && VD5 != VD1 && VD6 != VD1)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            //se comprueba se se perdió 2
            if (VD6 != 0 && (VD6 == VD1 || VD6 == VD8 || VD6 == VD9))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se gana
            if (VD8 == 0 && VD8 != VD3 && VD8 != VD6 && VD8 != VD10 && VD6 != VD3 && VD6 != VD10 && VD3 != VD10)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //ganó
            if (VD1 == 0 && VD2 != VD5 && VD2 != VD6 && VD5 != VD6 && VD2 != VD1 && VD5 != VD1 && VD6 != VD1)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1 );
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD9 == 0 && VD9 != VD6 && VD9 != VD7 && VD9 != VD4 && VD6 != VD7 && VD6 != VD4 && VD7 != VD4)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            //se comprueba se se perdió 2
            if (VD7 != 0 && (VD7 == VD2 || VD7 == VD10 || VD7 == VD9))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD9 == 0 && VD9 != VD6 && VD9 != VD7 && VD9 != VD4 && VD6 != VD7 && VD6 != VD4 && VD7 != VD4)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //gana
            if (VD2 == 0 && VD2 != VD1 && VD2 != VD7 && VD2 != VD3 && VD1 != VD3 && VD1 != VD7 && VD3 != VD7)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            if (VD10 == 0 && VD10 != VD5 && VD10 != VD7 && VD8 != VD10 && VD5 != VD8 && VD5 != VD7 && VD7 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            //se comprueba se se perdió 2
            if (VD8 != 0 && (VD8 == VD3 || VD6 == VD8 || VD8 == VD10))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //ganó
            if (VD10 == 0 && VD10 != VD5 && VD10 != VD7 && VD8 != VD10 && VD5 != VD8 && VD5 != VD7 && VD7 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //ganó
            if (VD6 == 0 && VD6 != VD1 && VD6 != VD8 && VD6 != VD9 && VD1 != VD8 && VD1 != VD9 && VD9 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se gana
            if (VD3 == 0 && VD3 != VD2 && VD3 != VD4 && VD3 != VD8 && VD2 != VD4 && VD2 != VD8 && VD4 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            if (VD9 != 0 && (VD9 == VD4 || VD9 == VD6 || VD9 == VD7))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            if (VD7 == 0 && VD7 != VD2 && VD7 != VD9 && VD7 != VD10 && VD2 != VD9 && VD2 != VD10 && VD10 != VD9)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //ganó
            if (VD6 == 0 && VD6 != VD1 && VD6 != VD8 && VD6 != VD9 && VD1 != VD8 && VD1 != VD9 && VD9 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD4 == 0 && VD4 != VD3 && VD4 != VD5 && VD4 != VD9 && VD3 != VD9 && VD3 != VD5 && VD5 != VD9)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            if (VD10 != 0 && (VD10 == VD5 || VD10 == VD7 || VD10 == VD8))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se gana
            if (VD8 == 0 && VD8 != VD3 && VD8 != VD6 && VD8 != VD10 && VD6 != VD3 && VD6 != VD10 && VD3 != VD10)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            if (VD7 == 0 && VD7 != VD2 && VD7 != VD9 && VD7 != VD10 && VD2 != VD9 && VD2 != VD10 && VD10 != VD9)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            if (VD5 == 0 && VD1 != VD5 && VD1 != VD10 && VD5 != VD10 && VD1 != VD4 && VD5 != VD4 && VD10 != VD4)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void pictureBoxVV1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxVV6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentColor = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentColor = 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentColor = 3;
        }

        private void pbV2_Click(object sender, EventArgs e)
        {

        }

        private void pbV1_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pbV1R.Visible = true;
                VF1 = 1;
            }
            else if (currentColor == 2)
            {
                pbV1A.Visible = true;
                VF1 = 2;
            }
            else if (currentColor == 3)
            {
                pbV1V.Visible = true;
                VF1 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pbV2_Click_1(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pbV2R.Visible = true;
                VF2 = 1;
            }
            else if (currentColor == 2)
            {
                pbV2A.Visible = true;
                VF2 = 2;
            }
            else if (currentColor == 3)
            {
                pbV2V.Visible = true;
                VF2 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pbV1V_Click(object sender, EventArgs e)
        {


        }

        private void pbV4_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pbV4R.Visible = true;
                VF3 = 1;
            }
            else if (currentColor == 2)
            {
                pbV4A.Visible = true;
                VF3 = 2;
            }
            else if (currentColor == 3)
            {
                pbV4V.Visible = true;
                VF3 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pbV3_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pbV3R.Visible = true;
                VF4 = 1;
            }
            else if (currentColor == 2)
            {
                pbV3A.Visible = true;
                VF4 = 2;
            }
            else if (currentColor == 3)
            {
                pbV3V.Visible = true;
                VF4 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pbV5_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pbV5R.Visible = true;
                VF5 = 1;
            }
            else if (currentColor == 2)
            {
                pbV5A.Visible = true;
                VF5 = 2;
            }
            else if (currentColor == 3)
            {
                pbV5V.Visible = true;
                VF5 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void pbV6_Click(object sender, EventArgs e)
        {
            if (currentColor == 1)
            {
                pbV6R.Visible = true;
                VF6 = 1;
            }
            else if (currentColor == 2)
            {
                pbV6A.Visible = true;
                VF6 = 2;
            }
            else if (currentColor == 3)
            {
                pbV6V.Visible = true;
                VF6 = 3;
            }
            else
            {
                MessageBox.Show("Selecciona un color");
            }
            currentColor = 0;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

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
            if (VD4 != 0 && (VD4 == VD5 || VD4 == VD3 || VD4 == VD9))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se gana
            if (VD3 == 0 && VD3 != VD2 && VD3 != VD4 && VD3 != VD8 && VD2 != VD4 && VD2 != VD8 && VD4 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se gana
            if (VD5 == 0 && VD1 != VD5 && VD1 != VD10 && VD5 != VD10 && VD1 != VD4 && VD5 != VD4 && VD10 != VD4)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD9 == 0 && VD9 != VD6 && VD9 != VD7 && VD9 != VD4 && VD6 != VD7 && VD6 != VD4 && VD7 != VD4)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            //se pierde
            if (VD3 != 0 && (VD3 == VD2 || VD4 == VD3 || VD3 == VD8))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se gana
            if (VD8 == 0 && VD8 != VD3 && VD8 != VD6 && VD8 != VD10 && VD6 != VD3 && VD6 != VD10 && VD3 != VD10)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD4 == 0 && VD4 != VD3 && VD4 != VD5 && VD4 != VD9 && VD3 != VD9 && VD3 != VD5 && VD5 != VD9)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD2 == 0 && VD2 != VD1 && VD2 != VD7 && VD2 != VD3 && VD1 != VD3 && VD1 != VD7 && VD3 != VD7)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            //se comprueba se se perdió 2
            if (VD2 != 0 && (VD2 == VD1 || VD2 == VD3 || VD2 == VD7))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //ganó
            if (VD1 == 0 && VD2 != VD5 && VD2 != VD6 && VD5 != VD6 && VD2 != VD1 && VD5 != VD1 && VD6 != VD1)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se gana
            if (VD3 == 0 && VD3 != VD2 && VD3 != VD4 && VD3 != VD8 && VD2 != VD4 && VD2 != VD8 && VD4 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            if (VD7 == 0 && VD7 != VD2 && VD7 != VD9 && VD7 != VD10 && VD2 != VD9 && VD2 != VD10 && VD10 != VD9)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            //se comprueba se se perdió 2
            if (VD1 != 0 && (VD5 == VD1 || VD1 == VD6 || VD1 == VD2))
            {
                //mensaje de derrota
                MessageBox.Show("Perdiste .__________________.");
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //ganó
            if (VD6 == 0 && VD6 != VD1 && VD6 != VD8 && VD6 != VD9 && VD1 != VD8 && VD1 != VD9 && VD9 != VD8)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            if (VD5 == 0 && VD1 != VD5 && VD1 != VD10 && VD5 != VD10 && VD1 != VD4 && VD5 != VD4 && VD10 != VD4)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //victoria
            if (VD2 == 0 && VD2 != VD1 && VD2 != VD7 && VD2 != VD3 && VD1 != VD3 && VD1 != VD7 && VD3 != VD7)
            {
                //mensaje de victoria
                MessageBox.Show("Ha ganado, felicidades " + usuario1);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
            //se comprueba se perdió
            if (VD1 != 0 && VD2 != 0 && VD3 != 0 && VD4 != 0 && VD5 != 0 && VD6 != 0 && VD7 != 0 && VD8 != 0 && VD9 != 0 && VD10 != 0)
            {
                //mensaje de derrota
                MessageBox.Show("Ha ganado " + usuario2);
                //se reinician los valores
                VD1 = 0;
                VD2 = 0;
                VD3 = 0;
                VD4 = 0;
                VD5 = 0;
                VD6 = 0;
                VD7 = 0;
                VD8 = 0;
                VD9 = 0;
                VD10 = 0;
                //se va a la página anterior
                tabControl1.SelectedIndex = 0;
                //se quitan las picture boxes
                pictureBoxVR1.Visible = false;
                pictureBoxVA1.Visible = false;
                pictureBoxVV1.Visible = false;
                pictureBoxVR2.Visible = false;
                pictureBoxVA2.Visible = false;
                pictureBoxVV2.Visible = false;
                pictureBoxVR3.Visible = false;
                pictureBoxVA3.Visible = false;
                pictureBoxVV3.Visible = false;
                pictureBoxVR4.Visible = false;
                pictureBoxVA4.Visible = false;
                pictureBoxVV4.Visible = false;
                pictureBoxVR5.Visible = false;
                pictureBoxVA5.Visible = false;
                pictureBoxVV5.Visible = false;
                pictureBoxVR6.Visible = false;
                pictureBoxVA6.Visible = false;
                pictureBoxVV6.Visible = false;
                pictureBoxVR7.Visible = false;
                pictureBoxVA7.Visible = false;
                pictureBoxVV7.Visible = false;
                pictureBoxVR8.Visible = false;
                pictureBoxVA8.Visible = false;
                pictureBoxVV8.Visible = false;
                pictureBoxVR9.Visible = false;
                pictureBoxVA9.Visible = false;
                pictureBoxVV9.Visible = false;
                pictureBoxVR10.Visible = false;
                pictureBoxVA10.Visible = false;
                pictureBoxVV10.Visible = false;
                //se deshabilitan los botones
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                //se habilitan nuevamente los botones 
                button8.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxApellido.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBox1.Enabled = true;
            }
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
            button9.Enabled = true;
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
