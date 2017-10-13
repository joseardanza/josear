using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int? numDia, numMes, numAnio, numNota;
        Boolean marcar=false;
        String Materia = null;

        public Form1()
        {
            InitializeComponent();

            //Impido que se pueda escribir en el combobox y lo cargo para que se puedan ver las materias
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Add("Diseño de sistemas");
            comboBox1.Items.Add("Taller de computación VI");
            comboBox1.Items.Add("Seminario de sistemas");
            comboBox1.Items.Add("Calidad de software");
            comboBox1.Items.Add("Computacion avanzada");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox7.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox2.Text == "" || textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Alguno de los campos están vacios, verificar.", "",
                MessageBoxButtons.OK);
            }
            else
            {
                numDia = Convert.ToInt32(textBox3.Text);
                numDia = int.Parse(textBox3.Text);

                numMes = Convert.ToInt32(textBox2.Text);
                numMes = int.Parse(textBox2.Text);

                numAnio = Convert.ToInt32(textBox1.Text);
                numAnio = int.Parse(textBox1.Text);

                numNota = Convert.ToInt32(textBox4.Text);
                numNota = int.Parse(textBox4.Text);
            }

            if (numDia > 31 || numDia<1 || numMes>12 || numMes<1 || numAnio>2017 || numAnio<1990)
            {
                MessageBox.Show("La fecha ingresada es incorrecta, verificar.", "",
                MessageBoxButtons.OK);
            }

            if (numNota<1 ||numNota>10)
            {
                MessageBox.Show("La nota ingresada es incorrecta, verificar.", "",
                MessageBoxButtons.OK);
            }

            Materia = comboBox1.Text;

            if (numDia >= 1 && numDia <= 31){
                if (numMes >= 1 && numMes <= 12){
                    if(numAnio >= 1990 && numAnio <= 2017){
                        if(numNota >= 1 && numNota <= 10){
                            if (Materia != "")
                            {
                            if (marcar)
                            {
                                listBox1.Items.Add("----------------------------------");
                            }

                            marcar = true;

                listBox1.Items.Add("DATOS DEL ALUMNO");
                listBox1.Items.Add(textBox6.Text + ", " + textBox7.Text + " - Legajo: " + textBox5.Text);
                listBox1.Items.Add("DATOS DE LA MATERIA");
                listBox1.Items.Add("Nombre de la materia: "+comboBox1.Text);
                listBox1.Items.Add("Año de la materia cursada: "+textBox1.Text);
                listBox1.Items.Add("Nota obtenida: " + textBox4.Text);

                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Compruebo si se apreto el boton de limpiar campos y estaban previamente sin valores
            if (textBox7.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" &&  textBox2.Text == "" && textBox1.Text == "" && comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos estan vacios.", "",
                MessageBoxButtons.OK);
            }

            //Limpio todos los campos textbox y el comboBox
            if (textBox7.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox2.Text != "" || textBox1.Text != "" || comboBox1.SelectedIndex > 0 || comboBox1.SelectedIndex < 4)
            {
                textBox7.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                comboBox1.SelectedIndex = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Verifico si el listbox esta vacio
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("El listbox esta vacio.", "",
                MessageBoxButtons.OK);
            }

            //Limpio el listbox
            else
            {
                listBox1.Items.Clear();
            }
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Validar_TextBox.validar.SoloNumeros(e);
            int Result = 0;
            if (!int.TryParse(textBox4.Text, out Result))
                textBox4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_TextBox.Validar.SoloNumeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar_TextBox.Validar.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_TextBox.Validar.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_TextBox.Validar.SoloNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_TextBox.Validar.SoloLetras(e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_TextBox.Validar.SoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_TextBox.Validar.SoloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_TextBox.Validar.SoloNumeros(e);

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}