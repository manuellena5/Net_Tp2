namespace UI.Desktop
{
    partial class Comisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comisiones));
            this.tscComisiones = new System.Windows.Forms.ToolStripContainer();
            this.tlpComisiones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.id_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsComisiones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscComisiones.ContentPanel.SuspendLayout();
            this.tscComisiones.TopToolStripPanel.SuspendLayout();
            this.tscComisiones.SuspendLayout();
            this.tlpComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.tsComisiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscComisiones
            // 
            // 
            // tscComisiones.ContentPanel
            // 
            this.tscComisiones.ContentPanel.Controls.Add(this.tlpComisiones);
            this.tscComisiones.ContentPanel.Size = new System.Drawing.Size(645, 450);
            this.tscComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscComisiones.Location = new System.Drawing.Point(0, 0);
            this.tscComisiones.Name = "tscComisiones";
            this.tscComisiones.Size = new System.Drawing.Size(645, 475);
            this.tscComisiones.TabIndex = 0;
            this.tscComisiones.Text = "toolStripContainer1";
            // 
            // tscComisiones.TopToolStripPanel
            // 
            this.tscComisiones.TopToolStripPanel.Controls.Add(this.tsComisiones);
            // 
            // tlpComisiones
            // 
            this.tlpComisiones.ColumnCount = 2;
            this.tlpComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpComisiones.Controls.Add(this.dgvComisiones, 0, 0);
            this.tlpComisiones.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpComisiones.Controls.Add(this.btnSalir, 1, 1);
            this.tlpComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComisiones.Location = new System.Drawing.Point(0, 0);
            this.tlpComisiones.Name = "tlpComisiones";
            this.tlpComisiones.RowCount = 2;
            this.tlpComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComisiones.Size = new System.Drawing.Size(645, 450);
            this.tlpComisiones.TabIndex = 0;
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_comision,
            this.desc_comision,
            this.anio_especialidad});
            this.tlpComisiones.SetColumnSpan(this.dgvComisiones, 2);
            this.dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisiones.Location = new System.Drawing.Point(3, 3);
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(639, 415);
            this.dgvComisiones.TabIndex = 0;
            // 
            // id_comision
            // 
            this.id_comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_comision.DataPropertyName = "IdComision";
            this.id_comision.HeaderText = "Id";
            this.id_comision.Name = "id_comision";
            this.id_comision.ReadOnly = true;
            // 
            // desc_comision
            // 
            this.desc_comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc_comision.DataPropertyName = "DescComision";
            this.desc_comision.HeaderText = "nro_comision";
            this.desc_comision.Name = "desc_comision";
            this.desc_comision.ReadOnly = true;
            // 
            // anio_especialidad
            // 
            this.anio_especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anio_especialidad.DataPropertyName = "AnioEspecialidad";
            this.anio_especialidad.HeaderText = "año_especialidad";
            this.anio_especialidad.Name = "anio_especialidad";
            this.anio_especialidad.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(486, 424);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(567, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsComisiones
            // 
            this.tsComisiones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsComisiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsComisiones.Location = new System.Drawing.Point(4, 0);
            this.tsComisiones.Name = "tsComisiones";
            this.tsComisiones.Size = new System.Drawing.Size(81, 25);
            this.tsComisiones.TabIndex = 0;
            this.tsComisiones.Text = "toolStrip1";
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
            // Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 475);
            this.Controls.Add(this.tscComisiones);
            this.Name = "Comisiones";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_Load);
            this.tscComisiones.ContentPanel.ResumeLayout(false);
            this.tscComisiones.TopToolStripPanel.ResumeLayout(false);
            this.tscComisiones.TopToolStripPanel.PerformLayout();
            this.tscComisiones.ResumeLayout(false);
            this.tscComisiones.PerformLayout();
            this.tlpComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.tsComisiones.ResumeLayout(false);
            this.tsComisiones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscComisiones;
        private System.Windows.Forms.TableLayoutPanel tlpComisiones;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsComisiones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_especialidad;
    }
}