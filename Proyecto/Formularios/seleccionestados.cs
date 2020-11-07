using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios
{
    public partial class seleccionestados : Form
    {
        public seleccionestados()
        {
            InitializeComponent();
            dataGridView2.Rows.Add("Estado 1");
            dataGridView2.Rows.Add("Estado 2");
            dataGridView2.Rows.Add("Estado 3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtenemos el DataTable del DGV1
            DataTable datos = (DataTable)dataGridView1.DataSource;

            //Creamos un nuevo DT con el filtro.
            DataTable seleccionados = datos.Select("condicion = 'aceptado'").CopyToDataTable();

            //Asignamos al DGV2 el resultado
            dataGridView2.DataSource = seleccionados;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
