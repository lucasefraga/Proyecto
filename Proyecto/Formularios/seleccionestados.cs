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
            foreach (DataGridViewRow rowPrincipal in dataGridView2.SelectedRows)
            {

                // Creamos un array con los valores que vamos a insertar
                // en el segundo control DataGridView.
                //
                object[] values = {
                                          rowPrincipal.Cells["Estados"].Value};

                // Creamos un nuevo objeto DataGridViewRow.
                //
                DataGridViewRow row = new DataGridViewRow();

                // Creamos las celdas y las rellenamos con los valores existentes
                // en el array.
                //
                row.CreateCells(dataGridView1, values);

                // Añadimos la nueva fila al segundo control DataGridView.
                //
                dataGridView2.Rows.Add(row);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
