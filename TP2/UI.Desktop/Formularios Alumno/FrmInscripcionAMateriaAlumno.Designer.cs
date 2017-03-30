namespace UI.Desktop
{
    partial class FrmInscripcionAMateriaAlumno
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
            this.TcInsAlMat = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescComision = new System.Windows.Forms.TextBox();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.lblListaCursos = new System.Windows.Forms.LinkLabel();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.TcInsAlMat.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TcInsAlMat
            // 
            this.TcInsAlMat.Controls.Add(this.tabPage1);
            this.TcInsAlMat.Location = new System.Drawing.Point(12, 12);
            this.TcInsAlMat.Name = "TcInsAlMat";
            this.TcInsAlMat.SelectedIndex = 0;
            this.TcInsAlMat.Size = new System.Drawing.Size(564, 431);
            this.TcInsAlMat.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDescComision);
            this.tabPage1.Controls.Add(this.txtIdCurso);
            this.tabPage1.Controls.Add(this.lblListaCursos);
            this.tabPage1.Controls.Add(this.btnInscribir);
            this.tabPage1.Controls.Add(this.lblAlumno);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMateria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Comision";
            // 
            // txtDescComision
            // 
            this.txtDescComision.Location = new System.Drawing.Point(90, 111);
            this.txtDescComision.Name = "txtDescComision";
            this.txtDescComision.ReadOnly = true;
            this.txtDescComision.Size = new System.Drawing.Size(100, 20);
            this.txtDescComision.TabIndex = 7;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(355, 75);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(28, 20);
            this.txtIdCurso.TabIndex = 6;
            this.txtIdCurso.Visible = false;
            // 
            // lblListaCursos
            // 
            this.lblListaCursos.AutoSize = true;
            this.lblListaCursos.Location = new System.Drawing.Point(212, 78);
            this.lblListaCursos.Name = "lblListaCursos";
            this.lblListaCursos.Size = new System.Drawing.Size(118, 13);
            this.lblListaCursos.TabIndex = 5;
            this.lblListaCursos.TabStop = true;
            this.lblListaCursos.Text = "Seleccione una materia";
            this.lblListaCursos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblListaCurso_LinkClicked);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(115, 152);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(75, 23);
            this.btnInscribir.TabIndex = 4;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(42, 377);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblAlumno.TabIndex = 3;
            this.lblAlumno.Text = "Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Materia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(90, 75);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(497, 445);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(371, 445);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmInscripcionAMateriaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 476);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.TcInsAlMat);
            this.Name = "FrmInscripcionAMateriaAlumno";
            this.Text = "Inscripcion a examen";
            this.Load += new System.EventHandler(this.FrmInscripcionAMateriaAlumno_Load);
            this.TcInsAlMat.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TcInsAlMat;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel lblListaCursos;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescComision;
        private System.Windows.Forms.Button btnCancelar;
    }
}