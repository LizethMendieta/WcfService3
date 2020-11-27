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
            ServiceReference1.Service1Client alumno = new ServiceReference1.Service1Client();
            var producto = alumno.GetIdProducto(Convert.ToInt32(textBox1.Text)).ToString());
            listView1.Items.Add(producto.p)
        }
    }
}
