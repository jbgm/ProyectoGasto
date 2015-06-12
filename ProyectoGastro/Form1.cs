using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProyectoGastro
{
    public partial class Form1 : Form
    {
        dbgastroclinicaEntities entidades = new dbgastroclinicaEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Productos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Productos();
        }

        private IEnumerable<producto> Productos()
        {
            return (from p in entidades.productoes where p.Nombre.StartsWith(textBox1.Text) select p).ToList();
        }
    }
}
