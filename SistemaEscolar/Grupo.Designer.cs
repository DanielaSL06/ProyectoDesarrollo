namespace SistemaEscolar
{
    partial class Grupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAlumnoGrupo = new System.Windows.Forms.TextBox();
            this.txtMaestroGrupo = new System.Windows.Forms.TextBox();
            this.txtAulaGrupo = new System.Windows.Forms.TextBox();
            this.txtHorarioGrupo = new System.Windows.Forms.TextBox();
            this.txtCarreraGrupo = new System.Windows.Forms.TextBox();
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
            this.btnEliminar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(896, 27);
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 24);
            this.btnEliminar.Text = "Eliminar";
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.alumno,
            this.maestro,
            this.aula,
            this.horario,
            this.carrera});
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // alumno
            // 
            this.alumno.HeaderText = "Alumno";
            this.alumno.MinimumWidth = 6;
            this.alumno.Name = "alumno";
            this.alumno.Width = 125;
            // 
            // maestro
            // 
            this.maestro.HeaderText = "Maestro";
            this.maestro.MinimumWidth = 6;
            this.maestro.Name = "maestro";
            this.maestro.Width = 125;
            // 
            // aula
            // 
            this.aula.HeaderText = "Aula";
            this.aula.MinimumWidth = 6;
            this.aula.Name = "aula";
            this.aula.Width = 125;
            // 
            // horario
            // 
            this.horario.HeaderText = "Horario";
            this.horario.MinimumWidth = 6;
            this.horario.Name = "horario";
            this.horario.Width = 125;
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Carrera";
            this.carrera.MinimumWidth = 6;
            this.carrera.Name = "carrera";
            this.carrera.Width = 125;
            // 
            // txtAlumnoGrupo
            // 
            this.txtAlumnoGrupo.Location = new System.Drawing.Point(62, 310);
            this.txtAlumnoGrupo.Name = "txtAlumnoGrupo";
            this.txtAlumnoGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtAlumnoGrupo.TabIndex = 2;
            this.txtAlumnoGrupo.Text = "Alumno";
            // 
            // txtMaestroGrupo
            // 
            this.txtMaestroGrupo.Location = new System.Drawing.Point(62, 393);
            this.txtMaestroGrupo.Name = "txtMaestroGrupo";
            this.txtMaestroGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtMaestroGrupo.TabIndex = 3;
            this.txtMaestroGrupo.Text = "Maestro";
            // 
            // txtAulaGrupo
            // 
            this.txtAulaGrupo.Location = new System.Drawing.Point(363, 310);
            this.txtAulaGrupo.Name = "txtAulaGrupo";
            this.txtAulaGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtAulaGrupo.TabIndex = 4;
            this.txtAulaGrupo.Text = "Aula";
            // 
            // txtHorarioGrupo
            // 
            this.txtHorarioGrupo.Location = new System.Drawing.Point(363, 393);
            this.txtHorarioGrupo.Name = "txtHorarioGrupo";
            this.txtHorarioGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtHorarioGrupo.TabIndex = 5;
            this.txtHorarioGrupo.Text = "Horario";
            // 
            // txtCarreraGrupo
            // 
            this.txtCarreraGrupo.Location = new System.Drawing.Point(649, 310);
            this.txtCarreraGrupo.Name = "txtCarreraGrupo";
            this.txtCarreraGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtCarreraGrupo.TabIndex = 6;
            this.txtCarreraGrupo.Text = "Carrera";
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.txtCarreraGrupo);
            this.Controls.Add(this.txtHorarioGrupo);
            this.Controls.Add(this.txtAulaGrupo);
            this.Controls.Add(this.txtMaestroGrupo);
            this.Controls.Add(this.txtAlumnoGrupo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Grupo";
            this.Text = "Grupo";
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
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn maestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.TextBox txtAlumnoGrupo;
        private System.Windows.Forms.TextBox txtMaestroGrupo;
        private System.Windows.Forms.TextBox txtAulaGrupo;
        private System.Windows.Forms.TextBox txtHorarioGrupo;
        private System.Windows.Forms.TextBox txtCarreraGrupo;
    }
}