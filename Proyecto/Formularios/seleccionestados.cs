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
            foreach (DataGridViewRow row in dataGridView2.SelectedRows )
            {
                dataGridView1.Rows.Add(dataGridView2);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
