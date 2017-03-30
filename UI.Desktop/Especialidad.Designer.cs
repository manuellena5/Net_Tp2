namespace UI.Desktop
{
    partial class Especialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especialidad));
            this.tscEspecialidad = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidad = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEspecialidad = new System.Windows.Forms.DataGridView();
            this.id_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsEspecialidad = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscEspecialidad.ContentPanel.SuspendLayout();
            this.tscEspecialidad.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidad.SuspendLayout();
            this.tlpEspecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).BeginInit();
            this.tsEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidad
            // 
            // 
            // tscEspecialidad.ContentPanel
            // 
            this.tscEspecialidad.ContentPanel.Controls.Add(this.tlpEspecialidad);
            this.tscEspecialidad.ContentPanel.Size = new System.Drawing.Size(549, 344);
            this.tscEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidad.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidad.Name = "tscEspecialidad";
            this.tscEspecialidad.Size = new System.Drawing.Size(549, 369);
            this.tscEspecialidad.TabIndex = 0;
            this.tscEspecialidad.Text = "toolStripContainer1";
            // 
            // tscEspecialidad.TopToolStripPanel
            // 
            this.tscEspecialidad.TopToolStripPanel.Controls.Add(this.tsEspecialidad);
            // 
            // tlpEspecialidad
            // 
            this.tlpEspecialidad.ColumnCount = 2;
            this.tlpEspecialidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEspecialidad.Controls.Add(this.dgvEspecialidad, 0, 0);
            this.tlpEspecialidad.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpEspecialidad.Controls.Add(this.btnSalir, 1, 1);
            this.tlpEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidad.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidad.Name = "tlpEspecialidad";
            this.tlpEspecialidad.RowCount = 2;
            this.tlpEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidad.Size = new System.Drawing.Size(549, 344);
            this.tlpEspecialidad.TabIndex = 0;
            // 
            // dgvEspecialidad
            // 
            this.dgvEspecialidad.AllowUserToAddRows = false;
            this.dgvEspecialidad.AllowUserToDeleteRows = false;
            this.dgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_especialidad,
            this.desc_especialidad});
            this.tlpEspecialidad.SetColumnSpan(this.dgvEspecialidad, 2);
            this.dgvEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidad.Location = new System.Drawing.Point(3, 3);
            this.dgvEspecialidad.Name = "dgvEspecialidad";
            this.dgvEspecialidad.ReadOnly = true;
            this.dgvEspecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidad.Size = new System.Drawing.Size(543, 309);
            this.dgvEspecialidad.TabIndex = 0;
            this.dgvEspecialidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidad_CellContentClick);
            // 
            // id_especialidad
            // 
            this.id_especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_especialidad.DataPropertyName = "Idespecialidad";
            this.id_especialidad.HeaderText = "Id";
            this.id_especialidad.Name = "id_especialidad";
            this.id_especialidad.ReadOnly = true;
            // 
            // desc_especialidad
            // 
            this.desc_especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc_especialidad.DataPropertyName = "DescEspecialidad";
            this.desc_especialidad.HeaderText = "Nombre_especialidad";
            this.desc_especialidad.Name = "desc_especialidad";
            this.desc_especialidad.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(390, 318);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(471, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsEspecialidad
            // 
            this.tsEspecialidad.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEspecialidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsEspecialidad.Location = new System.Drawing.Point(3, 0);
            this.tsEspecialidad.Name = "tsEspecialidad";
            this.tsEspecialidad.Size = new System.Drawing.Size(81, 25);
            this.tsEspecialidad.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton2";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 369);
            this.Controls.Add(this.tscEspecialidad);
            this.Name = "Especialidad";
            this.Text = "Epecialidad";
            this.Load += new System.EventHandler(this.Especialidad_Load);
            this.tscEspecialidad.ContentPanel.ResumeLayout(false);
            this.tscEspecialidad.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidad.TopToolStripPanel.PerformLayout();
            this.tscEspecialidad.ResumeLayout(false);
            this.tscEspecialidad.PerformLayout();
            this.tlpEspecialidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).EndInit();
            this.tsEspecialidad.ResumeLayout(false);
            this.tsEspecialidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidad;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidad;
        private System.Windows.Forms.DataGridView dgvEspecialidad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsEspecialidad;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_especialidad;
    }
}