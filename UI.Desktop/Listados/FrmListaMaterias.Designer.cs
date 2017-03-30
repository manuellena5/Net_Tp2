namespace UI.Desktop
{
    partial class FrmListaMaterias
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
            this.components = new System.ComponentModel.Container();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpListaMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hs_Semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hs_Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tlpListaMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // tlpListaMaterias
            // 
            this.tlpListaMaterias.ColumnCount = 3;
            this.tlpListaMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.38462F));
            this.tlpListaMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.61538F));
            this.tlpListaMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tlpListaMaterias.Controls.Add(this.label1, 0, 1);
            this.tlpListaMaterias.Controls.Add(this.txtBuscar, 1, 1);
            this.tlpListaMaterias.Controls.Add(this.btnBuscar, 2, 1);
            this.tlpListaMaterias.Controls.Add(this.dataListado, 0, 2);
            this.tlpListaMaterias.Controls.Add(this.btnSalir, 2, 3);
            this.tlpListaMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListaMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlpListaMaterias.Name = "tlpListaMaterias";
            this.tlpListaMaterias.RowCount = 4;
            this.tlpListaMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListaMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListaMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.tlpListaMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpListaMaterias.Size = new System.Drawing.Size(582, 428);
            this.tlpListaMaterias.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre de materia";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(189, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(161, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(432, 34);
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
            this.Id_Materia,
            this.Desc_Materia,
            this.Hs_Semanales,
            this.Hs_Totales,
            this.Plan});
            this.tlpListaMaterias.SetColumnSpan(this.dataListado, 3);
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListado.Location = new System.Drawing.Point(3, 65);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(576, 311);
            this.dataListado.TabIndex = 3;
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(432, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Id_Materia
            // 
            this.Id_Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_Materia.DataPropertyName = "Id_Materia";
            this.Id_Materia.HeaderText = "Id Materia";
            this.Id_Materia.Name = "Id_Materia";
            this.Id_Materia.ReadOnly = true;
            // 
            // Desc_Materia
            // 
            this.Desc_Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc_Materia.DataPropertyName = "Desc_Materia";
            this.Desc_Materia.HeaderText = "Desc Materia";
            this.Desc_Materia.Name = "Desc_Materia";
            this.Desc_Materia.ReadOnly = true;
            // 
            // Hs_Semanales
            // 
            this.Hs_Semanales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hs_Semanales.DataPropertyName = "Hs_Semanales";
            this.Hs_Semanales.HeaderText = "Hs Semanales";
            this.Hs_Semanales.Name = "Hs_Semanales";
            this.Hs_Semanales.ReadOnly = true;
            // 
            // Hs_Totales
            // 
            this.Hs_Totales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hs_Totales.DataPropertyName = "Hs_Totales";
            this.Hs_Totales.HeaderText = "Hs Totales";
            this.Hs_Totales.Name = "Hs_Totales";
            this.Hs_Totales.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plan.DataPropertyName = "Plan";
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // FrmListaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 428);
            this.Controls.Add(this.tlpListaMaterias);
            this.Name = "FrmListaMaterias";
            this.Text = "Listado de materias";
            this.Load += new System.EventHandler(this.FrmListaMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tlpListaMaterias.ResumeLayout(false);
            this.tlpListaMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TableLayoutPanel tlpListaMaterias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hs_Semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hs_Totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;

    }
}