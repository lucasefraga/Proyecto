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
            dgvEstadosD.Rows.Add(false, "Estado 1");
            dgvEstadosD.Rows.Add(false, "Estado 2");
            dgvEstadosD.Rows.Add(false, "Estado 3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            // Se define una lista temporal de registro seleccionados
            //
            List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();

            //
            // Se recorre ca registro de la grilla de origen
            //
            foreach (DataGridViewRow row in dgvEstadosD.Rows)
            {
                //
                // Se recupera el campo que representa el checkbox, y se valida la seleccion
                // agregandola a la lista temporal
                //
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    rowSelected.Add(row);
                }
            }

            //
            // Se agrega el item seleccionado a la grilla de destino
            // eliminando la fila de la grilla original
            //
            foreach (DataGridViewRow row in rowSelected)
            {
                dgvEstadosS.Rows.Add(new object[] {false,
                                            row.Cells["Estado"].Value });

                dgvEstadosD.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEstadosD.Rows)
            {

                row.Cells["Seleccion"].Value = true;

            }
            button1.PerformClick();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            // Se define una lista temporal de registro seleccionados
            //
            List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();

            //
            // Se recorre ca registro de la grilla de origen
            //
            foreach (DataGridViewRow row in dgvEstadosS.Rows)
            {
                //
                // Se recupera el campo que representa el checkbox, y se valida la seleccion
                // agregandola a la lista temporal
                //
                DataGridViewCheckBoxCell cellSelecion = row.Cells["SeleccionSel"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    rowSelected.Add(row);
                }
            }

            //
            // Se agrega el item seleccionado a la grilla de destino
            // eliminando la fila de la grilla original
            //
            foreach (DataGridViewRow row in rowSelected)
            {
                dgvEstadosD.Rows.Add(new object[] {false,
                                            row.Cells["EstadoSel"].Value });

                dgvEstadosS.Rows.Remove(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEstadosS.Rows)
            {

                row.Cells["SeleccionSel"].Value = true;

            }
            button2.PerformClick();
        }
    }
}
