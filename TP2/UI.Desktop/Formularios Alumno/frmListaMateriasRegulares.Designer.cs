namespace UI.Desktop
{
    partial class frmListaMateriasRegulares
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAlumno = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Desc_Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_calendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAlumno
            // 
            this.labelAlumno.AutoSize = true;
            this.labelAlumno.Location = new System.Drawing.Point(3, 0);
            this.labelAlumno.Name = "labelAlumno";
            this.labelAlumno.Size = new System.Drawing.Size(42, 13);
            this.labelAlumno.TabIndex = 0;
            this.labelAlumno.Text = "Alumno";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(359, 411);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desc_Comision,
            this.Desc_Materia,
            this.Condicion,
            this.Anio_especialidad,
            this.Plan,
            this.anio_calendario});
            this.tableLayoutPanel1.SetColumnSpan(this.dataListado, 3);
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(3, 43);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(511, 362);
            this.dataListado.TabIndex = 1;
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.89944F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.10056F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.dataListado, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAlumno, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.19608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Desc_Comision
            // 
            this.Desc_Comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc_Comision.DataPropertyName = "Desc_Comision";
            this.Desc_Comision.HeaderText = "Comision";
            this.Desc_Comision.Name = "Desc_Comision";
            this.Desc_Comision.ReadOnly = true;
            // 
            // Desc_Materia
            // 
            this.Desc_Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc_Materia.DataPropertyName = "Desc_Materia";
            this.Desc_Materia.HeaderText = "Materia";
            this.Desc_Materia.Name = "Desc_Materia";
            this.Desc_Materia.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Condicion.DataPropertyName = "Condicion";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Anio_especialidad
            // 
            this.Anio_especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Anio_especialidad.DataPropertyName = "Anio_especialidad";
            this.Anio_especialidad.HeaderText = "Nivel";
            this.Anio_especialidad.Name = "Anio_especialidad";
            this.Anio_especialidad.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plan.DataPropertyName = "Plan";
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // anio_calendario
            // 
            this.anio_calendario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anio_calendario.DataPropertyName = "anio_calendario";
            this.anio_calendario.HeaderText = "Año";
            this.anio_calendario.Name = "anio_calendario";
            this.anio_calendario.ReadOnly = true;
            // 
            // frmListaMateriasRegulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListaMateriasRegulares";
            this.Text = "Lista Materias Regulares";
            this.Load += new System.EventHandler(this.FrmListaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAlumno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_calendario;

    }
}