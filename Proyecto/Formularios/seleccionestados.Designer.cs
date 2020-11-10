namespace Proyecto.Formularios
{
    partial class seleccionestados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvEstadosD = new System.Windows.Forms.DataGridView();
            this.dgvEstadosS = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EstadoSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadosD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadosS)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "AGREGAR TODO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "ELIMINAR TODO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dgvEstadosD
            // 
            this.dgvEstadosD.AllowUserToAddRows = false;
            this.dgvEstadosD.AllowUserToDeleteRows = false;
            this.dgvEstadosD.AllowUserToResizeColumns = false;
            this.dgvEstadosD.AllowUserToResizeRows = false;
            this.dgvEstadosD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadosD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadosD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.Estado});
            this.dgvEstadosD.Location = new System.Drawing.Point(63, 194);
            this.dgvEstadosD.Name = "dgvEstadosD";
            this.dgvEstadosD.RowHeadersVisible = false;
            this.dgvEstadosD.Size = new System.Drawing.Size(254, 177);
            this.dgvEstadosD.TabIndex = 6;
            // 
            // dgvEstadosS
            // 
            this.dgvEstadosS.AllowUserToAddRows = false;
            this.dgvEstadosS.AllowUserToDeleteRows = false;
            this.dgvEstadosS.AllowUserToResizeColumns = false;
            this.dgvEstadosS.AllowUserToResizeRows = false;
            this.dgvEstadosS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadosS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadosS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionSel,
            this.EstadoSel});
            this.dgvEstadosS.Location = new System.Drawing.Point(519, 194);
            this.dgvEstadosS.Name = "dgvEstadosS";
            this.dgvEstadosS.RowHeadersVisible = false;
            this.dgvEstadosS.Size = new System.Drawing.Size(254, 177);
            this.dgvEstadosS.TabIndex = 7;
            // 
            // Seleccion
            // 
            this.Seleccion.FillWeight = 40F;
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.Name = "Seleccion";
            // 
            // Estado
            // 
            this.Estado.FillWeight = 128.934F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // SeleccionSel
            // 
            this.SeleccionSel.FillWeight = 40F;
            this.SeleccionSel.HeaderText = "Seleccion";
            this.SeleccionSel.Name = "SeleccionSel";
            // 
            // EstadoSel
            // 
            this.EstadoSel.FillWeight = 128.934F;
            this.EstadoSel.HeaderText = "Estado";
            this.EstadoSel.Name = "EstadoSel";
            // 
            // seleccionestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEstadosS);
            this.Controls.Add(this.dgvEstadosD);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "seleccionestados";
            this.Text = "seleccionestados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadosD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadosS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvEstadosD;
        private System.Windows.Forms.DataGridView dgvEstadosS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSel;
    }
}