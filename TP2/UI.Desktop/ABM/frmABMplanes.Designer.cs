namespace UI.Desktop
{
    partial class frmABMplanes
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
            this.tlpABMplanes = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPlan = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lnkBuscarEspecialidad = new System.Windows.Forms.LinkLabel();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescEspecialidad = new System.Windows.Forms.TextBox();
            this.tlpABMplanes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpABMplanes
            // 
            this.tlpABMplanes.ColumnCount = 3;
            this.tlpABMplanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.84671F));
            this.tlpABMplanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.15328F));
            this.tlpABMplanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tlpABMplanes.Controls.Add(this.label1, 0, 1);
            this.tlpABMplanes.Controls.Add(this.label2, 0, 2);
            this.tlpABMplanes.Controls.Add(this.label3, 0, 3);
            this.tlpABMplanes.Controls.Add(this.txtIdPlan, 1, 1);
            this.tlpABMplanes.Controls.Add(this.txtDescripcion, 1, 2);
            this.tlpABMplanes.Controls.Add(this.lnkBuscarEspecialidad, 2, 3);
            this.tlpABMplanes.Controls.Add(this.txtIdEspecialidad, 1, 3);
            this.tlpABMplanes.Controls.Add(this.btnAceptar, 1, 6);
            this.tlpABMplanes.Controls.Add(this.btnSalir, 2, 6);
            this.tlpABMplanes.Controls.Add(this.label4, 0, 4);
            this.tlpABMplanes.Controls.Add(this.txtDescEspecialidad, 1, 4);
            this.tlpABMplanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpABMplanes.Location = new System.Drawing.Point(0, 0);
            this.tlpABMplanes.Name = "tlpABMplanes";
            this.tlpABMplanes.RowCount = 7;
            this.tlpABMplanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.83334F));
            this.tlpABMplanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.16667F));
            this.tlpABMplanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpABMplanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpABMplanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpABMplanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tlpABMplanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpABMplanes.Size = new System.Drawing.Size(441, 422);
            this.tlpABMplanes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Plan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Especialidad";
            // 
            // txtIdPlan
            // 
            this.txtIdPlan.Location = new System.Drawing.Point(90, 47);
            this.txtIdPlan.Name = "txtIdPlan";
            this.txtIdPlan.ReadOnly = true;
            this.txtIdPlan.Size = new System.Drawing.Size(51, 20);
            this.txtIdPlan.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(90, 69);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(173, 46);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lnkBuscarEspecialidad
            // 
            this.lnkBuscarEspecialidad.AutoSize = true;
            this.lnkBuscarEspecialidad.Location = new System.Drawing.Point(269, 118);
            this.lnkBuscarEspecialidad.Name = "lnkBuscarEspecialidad";
            this.lnkBuscarEspecialidad.Size = new System.Drawing.Size(103, 13);
            this.lnkBuscarEspecialidad.TabIndex = 6;
            this.lnkBuscarEspecialidad.TabStop = true;
            this.lnkBuscarEspecialidad.Text = "Buscar Especialidad";
            this.lnkBuscarEspecialidad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Location = new System.Drawing.Point(90, 121);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.ReadOnly = true;
            this.txtIdEspecialidad.Size = new System.Drawing.Size(135, 20);
            this.txtIdEspecialidad.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(188, 390);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(363, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Especialidad";
            // 
            // txtDescEspecialidad
            // 
            this.txtDescEspecialidad.Location = new System.Drawing.Point(90, 152);
            this.txtDescEspecialidad.Name = "txtDescEspecialidad";
            this.txtDescEspecialidad.ReadOnly = true;
            this.txtDescEspecialidad.Size = new System.Drawing.Size(135, 20);
            this.txtDescEspecialidad.TabIndex = 10;
            // 
            // frmABMplanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 422);
            this.Controls.Add(this.tlpABMplanes);
            this.Name = "frmABMplanes";
            this.Text = "ABMplanes";
            this.tlpABMplanes.ResumeLayout(false);
            this.tlpABMplanes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpABMplanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdPlan;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.LinkLabel lnkBuscarEspecialidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescEspecialidad;
    }
}