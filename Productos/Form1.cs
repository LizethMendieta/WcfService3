using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference4.Service1Client alumno = new ServiceReference4.Service1Client();
            var Lista = alumno.CrearLibrosos();
            var list = alumno.GetDatosLibros(Lista);
            textBox1.Text = list.Autor;
            textBox2.Text = list.Titulo;
            textBox3.Text = (Convert.ToInt32(list.Año)).ToString();
            textBox4.Text = (Convert.ToInt32(list.Id)).ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference5.Service1Client client = new ServiceReference5.Service1Client();
            string returnString;

            returnString = client.GetData(textBox5.Text);
            textBox6.Text = returnString;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
