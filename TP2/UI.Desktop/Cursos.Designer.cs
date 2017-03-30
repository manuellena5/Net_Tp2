namespace UI.Desktop
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.tscCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlpCursos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.Desc_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_calendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscCursos.ContentPanel.SuspendLayout();
            this.tscCursos.TopToolStripPanel.SuspendLayout();
            this.tscCursos.SuspendLayout();
            this.tlpCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.tsCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscCursos
            // 
            // 
            // tscCursos.ContentPanel
            // 
            this.tscCursos.ContentPanel.Controls.Add(this.tlpCursos);
            this.tscCursos.ContentPanel.Size = new System.Drawing.Size(593, 449);
            this.tscCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscCursos.Location = new System.Drawing.Point(0, 0);
            this.tscCursos.Name = "tscCursos";
            this.tscCursos.Size = new System.Drawing.Size(593, 474);
            this.tscCursos.TabIndex = 0;
            this.tscCursos.Text = "toolStripContainer1";
            // 
            // tscCursos.TopToolStripPanel
            // 
            this.tscCursos.TopToolStripPanel.Controls.Add(this.tsCursos);
            // 
            // tlpCursos
            // 
            this.tlpCursos.ColumnCount = 2;
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCursos.Controls.Add(this.dgvCursos, 0, 0);
            this.tlpCursos.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpCursos.Controls.Add(this.btnSalir, 1, 1);
            this.tlpCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCursos.Location = new System.Drawing.Point(0, 0);
            this.tlpCursos.Name = "tlpCursos";
            this.tlpCursos.RowCount = 2;
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCursos.Size = new System.Drawing.Size(593, 449);
            this.tlpCursos.TabIndex = 0;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desc_comision,
            this.Desc_materia,
            this.anio_calendario,
            this.cupo,
            this.id_curso,
            this.id_materia,
            this.id_comision});
            this.tlpCursos.SetColumnSpan(this.dgvCursos, 2);
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(587, 414);
            this.dgvCursos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(434, 423);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(515, 423);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsCursos
            // 
            this.tsCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsCursos.Location = new System.Drawing.Point(3, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(81, 25);
            this.tsCursos.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // Desc_comision
            // 
            this.Desc_comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc_comision.DataPropertyName = "Desc_comision";
            this.Desc_comision.HeaderText = "Desc_comision";
            this.Desc_comision.Name = "Desc_comision";
            this.Desc_comision.ReadOnly = true;
            // 
            // Desc_materia
            // 
            this.Desc_materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc_materia.DataPropertyName = "Desc_materia";
            this.Desc_materia.HeaderText = "Desc_materia";
            this.Desc_materia.Name = "Desc_materia";
            this.Desc_materia.ReadOnly = true;
            // 
            // anio_calendario
            // 
            this.anio_calendario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anio_calendario.DataPropertyName = "AnioCalendario";
            this.anio_calendario.HeaderText = "año";
            this.anio_calendario.Name = "anio_calendario";
            this.anio_calendario.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cupo.DataPropertyName = "Cupo";
            this.cupo.HeaderText = "cupo";
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // id_curso
            // 
            this.id_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_curso.DataPropertyName = "IdCurso";
            this.id_curso.HeaderText = "id_curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            // 
            // id_materia
            // 
            this.id_materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_materia.DataPropertyName = "IdMateria";
            this.id_materia.HeaderText = "id_materia";
            this.id_materia.Name = "id_materia";
            this.id_materia.ReadOnly = true;
            // 
            // id_comision
            // 
            this.id_comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_comision.DataPropertyName = "IdComision";
            this.id_comision.HeaderText = "id_comision";
            this.id_comision.Name = "id_comision";
            this.id_comision.ReadOnly = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 474);
            this.Controls.Add(this.tscCursos);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.tscCursos.ContentPanel.ResumeLayout(false);
            this.tscCursos.TopToolStripPanel.ResumeLayout(false);
            this.tscCursos.TopToolStripPanel.PerformLayout();
            this.tscCursos.ResumeLayout(false);
            this.tscCursos.PerformLayout();
            this.tlpCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscCursos;
        private System.Windows.Forms.TableLayoutPanel tlpCursos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_calendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comision;
    }
}