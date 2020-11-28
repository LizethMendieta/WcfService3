using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metodo_3
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

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference3.Service1Client producto = new ServiceReference3.Service1Client();
            var Lista = producto.GetIdProducto();
            var list = producto.GetProducto(Lista);
           
            textBox2.Text = list.Nombre;
            textBox3.Text = (Convert.ToInt32(list.Id)).ToString();
            textBox4.Text = (Convert.ToInt32(list.Id)).ToString();

            MessageBox.Show("Producto encontrado");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference3.Service1Client producto = new ServiceReference3.Service1Client();
            string returnString;

            returnString = producto.GetData(textBox1.Text);
            label4.Text = returnString;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su compra");
        }
    }
}
