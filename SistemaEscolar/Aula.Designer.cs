namespace SistemaEscolar
{
    partial class Aula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aula));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aaula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtCmaxima = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.Eliminar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(773, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 24);
            this.btnAgregar.Text = "Agregar";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 24);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(87, 24);
            this.Eliminar.Text = "Eliminar";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 24);
            this.btnSalir.Text = "Salir";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.edificio,
            this.Aaula,
            this.piso,
            this.CapacidadMaxima});
            this.dataGridView1.Location = new System.Drawing.Point(25, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 227);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // edificio
            // 
            this.edificio.HeaderText = "Edificio";
            this.edificio.MinimumWidth = 6;
            this.edificio.Name = "edificio";
            this.edificio.Width = 125;
            // 
            // Aaula
            // 
            this.Aaula.HeaderText = "Aula";
            this.Aaula.MinimumWidth = 6;
            this.Aaula.Name = "Aaula";
            this.Aaula.Width = 125;
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.MinimumWidth = 6;
            this.piso.Name = "piso";
            this.piso.Width = 125;
            // 
            // CapacidadMaxima
            // 
            this.CapacidadMaxima.HeaderText = "Capacidad Máxima";
            this.CapacidadMaxima.MinimumWidth = 6;
            this.CapacidadMaxima.Name = "CapacidadMaxima";
            this.CapacidadMaxima.Width = 125;
            // 
            // txtEdificio
            // 
            this.txtEdificio.Location = new System.Drawing.Point(125, 327);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(100, 22);
            this.txtEdificio.TabIndex = 2;
            this.txtEdificio.Text = "Edificio";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(125, 390);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 22);
            this.txtAula.TabIndex = 3;
            this.txtAula.Text = "Aula";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(464, 327);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 22);
            this.txtPiso.TabIndex = 4;
            this.txtPiso.Text = "Piso";
            // 
            // txtCmaxima
            // 
            this.txtCmaxima.Location = new System.Drawing.Point(464, 390);
            this.txtCmaxima.Name = "txtCmaxima";
            this.txtCmaxima.Size = new System.Drawing.Size(128, 22);
            this.txtCmaxima.TabIndex = 5;
            this.txtCmaxima.Text = "Capacidad Máxima";
            // 
            // Aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.txtCmaxima);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtEdificio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Aula";
            this.Text = "Aula";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aaula;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadMaxima;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtCmaxima;
    }
}