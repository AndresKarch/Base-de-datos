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
    public partial class Torneos : Form
    {
        Datos datos = new Datos();
        public Torneos()
        {
            InitializeComponent();
        }

        private void Torneos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tP_BaseDatosDataSet7.Deportista' Puede moverla o quitarla según sea necesario.
            this.deportistaTableAdapter1.Fill(this.tP_BaseDatosDataSet7.Deportista);
            // TODO: esta línea de código carga datos en la tabla 'tP_BaseDatosDataSet4.Deportista' Puede moverla o quitarla según sea necesario.
            this.deportistaTableAdapter.Fill(this.tP_BaseDatosDataSet4.Deportista);
            // TODO: esta línea de código carga datos en la tabla 'tP_BaseDatosDataSet3.Participacion' Puede moverla o quitarla según sea necesario.
            this.participacionTableAdapter.Fill(this.tP_BaseDatosDataSet3.Participacion);
            // TODO: esta línea de código carga datos en la tabla 'tP_BaseDatosDataSet2.Torneo' Puede moverla o quitarla según sea necesario.
            this.torneoTableAdapter.Fill(this.tP_BaseDatosDataSet2.Torneo);
            dataGridView1.DataSource = datos.consulta("exec dbo.MejorDeportistaXTorneo 0");
        }

        private void Btn_entrenamientos_Click(object sender, EventArgs e)
        {
            Entrenamientos entren = new Entrenamientos();
            this.Close();
            entren.Show();
        }

        private void Btn_deportistas_Click(object sender, EventArgs e)
        {
            Deportistas dep = new Deportistas();
            this.Close();
            dep.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
                dataGridView1.DataSource = datos.consulta("exec dbo.MejorDeportistaXTorneo " + comboBox1.SelectedValue);
        }

        private void Dgv_torneo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.main_menu.Show();
        }
    }
}
