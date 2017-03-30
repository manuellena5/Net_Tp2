namespace UI.Desktop
{
    partial class FrmListadoAlumInscriptos
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
            this.frmListaInscrip = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.frmListaInscrip.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // frmListaInscrip
            // 
            this.frmListaInscrip.Controls.Add(this.tabPage1);
            this.frmListaInscrip.Location = new System.Drawing.Point(12, 12);
            this.frmListaInscrip.Name = "frmListaInscrip";
            this.frmListaInscrip.SelectedIndex = 0;
            this.frmListaInscrip.Size = new System.Drawing.Size(464, 375);
            this.frmListaInscrip.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnListar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(264, 330);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "label2";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(73, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(146, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(358, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(300, 24);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(225, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Location = new System.Drawing.Point(6, 64);
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.Size = new System.Drawing.Size(444, 234);
            this.dataListado.TabIndex = 0;
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmListadoAlumInscriptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 412);
            this.Controls.Add(this.frmListaInscrip);
            this.Name = "FrmListadoAlumInscriptos";
            this.Text = "Listado alumnos inscriptos";
            this.Load += new System.EventHandler(this.FrmListadoAlumInscriptos_Load);
            this.frmListaInscrip.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl frmListaInscrip;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}