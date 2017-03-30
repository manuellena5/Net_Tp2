namespace UI.Desktop
{
    partial class FrmListaEspecialidades
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
            this.txtListaEspecialidades = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvListaEspecialidades = new System.Windows.Forms.DataGridView();
            this.Idespecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.96403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.03597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtListaEspecialidades, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvListaEspecialidades, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.1134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.8866F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar especialidad:";
            // 
            // txtListaEspecialidades
            // 
            this.txtListaEspecialidades.Location = new System.Drawing.Point(127, 3);
            this.txtListaEspecialidades.Name = "txtListaEspecialidades";
            this.txtListaEspecialidades.Size = new System.Drawing.Size(100, 20);
            this.txtListaEspecialidades.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(278, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListaEspecialidades
            // 
            this.dgvListaEspecialidades.AllowUserToAddRows = false;
            this.dgvListaEspecialidades.AllowUserToDeleteRows = false;
            this.dgvListaEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idespecialidad,
            this.DescEspecialidad});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvListaEspecialidades, 3);
            this.dgvListaEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaEspecialidades.Location = new System.Drawing.Point(3, 47);
            this.dgvListaEspecialidades.Name = "dgvListaEspecialidades";
            this.dgvListaEspecialidades.ReadOnly = true;
            this.dgvListaEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEspecialidades.Size = new System.Drawing.Size(418, 314);
            this.dgvListaEspecialidades.TabIndex = 4;
            this.dgvListaEspecialidades.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Idespecialidad
            // 
            this.Idespecialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Idespecialidad.DataPropertyName = "Idespecialidad";
            this.Idespecialidad.HeaderText = "ID";
            this.Idespecialidad.Name = "Idespecialidad";
            this.Idespecialidad.ReadOnly = true;
            // 
            // DescEspecialidad
            // 
            this.DescEspecialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescEspecialidad.DataPropertyName = "DescEspecialidad";
            this.DescEspecialidad.HeaderText = "Descripcion";
            this.DescEspecialidad.Name = "DescEspecialidad";
            this.DescEspecialidad.ReadOnly = true;
            // 
            // FrmListaEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListaEspecialidades";
            this.Text = "ListaEspecialidades";
            this.Load += new System.EventHandler(this.FrmListaEspecialidades_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEspecialidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListaEspecialidades;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvListaEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idespecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescEspecialidad;

    }
}