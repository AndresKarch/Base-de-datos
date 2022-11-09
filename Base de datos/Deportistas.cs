using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_datos
{
    public partial class Deportistas : Form
    {
        Datos datos = new Datos();
        public Deportistas()
        {
            InitializeComponent();
        }

        private void Dgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tP_BaseDatosDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.tP_BaseDatosDataSet.Categoria);
            Dgvdatos.DataSource = datos.consulta("select * from Deportista");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null) 
                Dgvdatos.DataSource = datos.consulta("select * from Deportista where Cod_cat = " + comboBox1.SelectedValue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrenamientos entren = new Entrenamientos();
            this.Close();
            entren.Show();
        }

        private void Btn_torneos_Click(object sender, EventArgs e)
        {
            Torneos torn = new Torneos();
            this.Hide();
            torn.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Program.main_menu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
