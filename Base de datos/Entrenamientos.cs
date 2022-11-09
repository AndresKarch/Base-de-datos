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
    public partial class Entrenamientos : Form
    {
        Datos datos = new Datos();
        public Entrenamientos()
        {
            InitializeComponent();
        }

        private void Entrenamientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tP_BaseDatosDataSet1.Entrenamientos' Puede moverla o quitarla según sea necesario.
            this.entrenamientosTableAdapter.Fill(this.tP_BaseDatosDataSet1.Entrenamientos);
            Dgv_entrenamientos.DataSource = datos.consulta("select * from Entrenamientos");
        }

        private void Btn_deportistas_Click(object sender, EventArgs e)
        {
            Deportistas dep = new Deportistas();
            this.Close();
            dep.Show();
        }

        private void Btn_torneos_Click(object sender, EventArgs e)
        {
            Torneos torn = new Torneos();
            this.Close();
            torn.Show();
        }

        private void Dgv_entrenamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.main_menu.Show();
        }
    }
}
