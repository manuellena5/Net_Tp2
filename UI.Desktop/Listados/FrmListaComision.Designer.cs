namespace UI.Desktop
{
    partial class FrmListaComision
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
            this.tlpListaComision = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.IdComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpListaComision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpListaComision
            // 
            this.tlpListaComision.ColumnCount = 3;
            this.tlpListaComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.70073F));
            this.tlpListaComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.29927F));
            this.tlpListaComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tlpListaComision.Controls.Add(this.label1, 0, 1);
            this.tlpListaComision.Controls.Add(this.txtBuscar, 1, 1);
            this.tlpListaComision.Controls.Add(this.btnBuscar, 2, 1);
            this.tlpListaComision.Controls.Add(this.dataListado, 0, 2);
            this.tlpListaComision.Controls.Add(this.btnSalir, 2, 3);
            this.tlpListaComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListaComision.Location = new System.Drawing.Point(0, 0);
            this.tlpListaComision.Name = "tlpListaComision";
            this.tlpListaComision.RowCount = 4;
            this.tlpListaComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListaComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListaComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tlpListaComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpListaComision.Size = new System.Drawing.Size(409, 386);
            this.tlpListaComision.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero de comision";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(119, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(128, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(275, 38);
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
            this.IdComision,
            this.DescComision,
            this.AnioEspecialidad,
            this.Plan});
            this.tlpListaComision.SetColumnSpan(this.dataListado, 3);
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(3, 73);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(403, 276);
            this.dataListado.TabIndex = 3;
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(275, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // IdComision
            // 
            this.IdComision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdComision.DataPropertyName = "IdComision";
            this.IdComision.HeaderText = "Id Comision";
            this.IdComision.Name = "IdComision";
            this.IdComision.ReadOnly = true;
            // 
            // DescComision
            // 
            this.DescComision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescComision.DataPropertyName = "DescComision";
            this.DescComision.HeaderText = "Descripcion Comision";
            this.DescComision.Name = "DescComision";
            this.DescComision.ReadOnly = true;
            // 
            // AnioEspecialidad
            // 
            this.AnioEspecialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnioEspecialidad.DataPropertyName = "AnioEspecialidad";
            this.AnioEspecialidad.HeaderText = "Nivel";
            this.AnioEspecialidad.Name = "AnioEspecialidad";
            this.AnioEspecialidad.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plan.DataPropertyName = "Plan";
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // FrmListaComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 386);
            this.Controls.Add(this.tlpListaComision);
            this.Name = "FrmListaComision";
            this.Text = "Listado de comisiones";
            this.Load += new System.EventHandler(this.FrmListaComision_Load);
            this.tlpListaComision.ResumeLayout(false);
            this.tlpListaComision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpListaComision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;

    }
}