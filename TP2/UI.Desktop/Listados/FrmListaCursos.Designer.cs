namespace UI.Desktop
{
    partial class FrmListaCursos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Desc_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.78273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.21727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataListado, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.44828F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.55172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la materia:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(231, 36);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(141, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(549, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desc_comision,
            this.Desc_materia,
            this.AnioCalendario,
            this.Cupo,
            this.IdCurso,
            this.IdMateria});
            this.tableLayoutPanel1.SetColumnSpan(this.dataListado, 3);
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(3, 65);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(711, 304);
            this.dataListado.TabIndex = 3;
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(549, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Desc_comision
            // 
            this.Desc_comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc_comision.DataPropertyName = "Desc_comision";
            this.Desc_comision.HeaderText = "Descripcion comision";
            this.Desc_comision.Name = "Desc_comision";
            this.Desc_comision.ReadOnly = true;
            // 
            // Desc_materia
            // 
            this.Desc_materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc_materia.DataPropertyName = "Desc_materia";
            this.Desc_materia.HeaderText = "Descripcion materia";
            this.Desc_materia.Name = "Desc_materia";
            this.Desc_materia.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnioCalendario.DataPropertyName = "AnioCalendario";
            this.AnioCalendario.HeaderText = "Año Calendario";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            // 
            // Cupo
            // 
            this.Cupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cupo.DataPropertyName = "Cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // IdCurso
            // 
            this.IdCurso.DataPropertyName = "IdCurso";
            this.IdCurso.HeaderText = "IdCurso";
            this.IdCurso.Name = "IdCurso";
            this.IdCurso.ReadOnly = true;
            this.IdCurso.Visible = false;
            // 
            // IdMateria
            // 
            this.IdMateria.DataPropertyName = "IdMateria";
            this.IdMateria.HeaderText = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            this.IdMateria.Visible = false;
            // 
            // FrmListaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListaCursos";
            this.Text = "Listado de cursos";
            this.Load += new System.EventHandler(this.FrmListaCursos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;

    }
}