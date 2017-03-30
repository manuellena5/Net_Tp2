namespace UI.Desktop
{
    partial class FrmLista_Plan
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
            this.tlpListaPlan = new System.Windows.Forms.TableLayoutPanel();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpListaPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpListaPlan
            // 
            this.tlpListaPlan.ColumnCount = 3;
            this.tlpListaPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.07744F));
            this.tlpListaPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.92256F));
            this.tlpListaPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tlpListaPlan.Controls.Add(this.dataListado, 0, 2);
            this.tlpListaPlan.Controls.Add(this.txtBuscar, 1, 1);
            this.tlpListaPlan.Controls.Add(this.btnBuscar, 2, 1);
            this.tlpListaPlan.Controls.Add(this.btnSalir, 2, 3);
            this.tlpListaPlan.Controls.Add(this.label1, 0, 1);
            this.tlpListaPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListaPlan.Location = new System.Drawing.Point(0, 0);
            this.tlpListaPlan.Name = "tlpListaPlan";
            this.tlpListaPlan.RowCount = 4;
            this.tlpListaPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.96429F));
            this.tlpListaPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.03571F));
            this.tlpListaPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tlpListaPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpListaPlan.Size = new System.Drawing.Size(415, 448);
            this.tlpListaPlan.TabIndex = 0;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plan,
            this.Especialidad});
            this.tlpListaPlan.SetColumnSpan(this.dataListado, 3);
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(3, 78);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(409, 324);
            this.dataListado.TabIndex = 9;
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(122, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(137, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(293, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Plan";
            // 
            // Plan
            // 
            this.Plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plan.DataPropertyName = "Plan";
            this.Plan.HeaderText = "Descripcion Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Especialidad.DataPropertyName = "Especialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // FrmLista_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 448);
            this.Controls.Add(this.tlpListaPlan);
            this.Name = "FrmLista_Plan";
            this.Text = "Lista Planes";
            this.Load += new System.EventHandler(this.Lista_Persona_Load);
            this.tlpListaPlan.ResumeLayout(false);
            this.tlpListaPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpListaPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;

    }
}