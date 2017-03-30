namespace UI.Desktop
{
    partial class frmIncripcionAcursado
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkBuscaCurso = new System.Windows.Forms.LinkLabel();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.labelAlumno = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtComision, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMateria, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkBuscaCurso, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIdCurso, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAlumno, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.26437F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.73563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Materia";
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(179, 64);
            this.txtComision.Name = "txtComision";
            this.txtComision.ReadOnly = true;
            this.txtComision.Size = new System.Drawing.Size(139, 20);
            this.txtComision.TabIndex = 2;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(179, 100);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            this.txtMateria.Size = new System.Drawing.Size(139, 20);
            this.txtMateria.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Busque el curso";
            // 
            // linkBuscaCurso
            // 
            this.linkBuscaCurso.AutoSize = true;
            this.linkBuscaCurso.Location = new System.Drawing.Point(179, 44);
            this.linkBuscaCurso.Name = "linkBuscaCurso";
            this.linkBuscaCurso.Size = new System.Drawing.Size(153, 13);
            this.linkBuscaCurso.TabIndex = 1;
            this.linkBuscaCurso.TabStop = true;
            this.linkBuscaCurso.Text = "Haz click para buscar su curso";
            this.linkBuscaCurso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBuscaCurso_LinkClicked);
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(355, 64);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.ReadOnly = true;
            this.txtIdCurso.Size = new System.Drawing.Size(100, 20);
            this.txtIdCurso.TabIndex = 9;
            this.txtIdCurso.Visible = false;
            // 
            // labelAlumno
            // 
            this.labelAlumno.AutoSize = true;
            this.labelAlumno.Location = new System.Drawing.Point(3, 367);
            this.labelAlumno.Name = "labelAlumno";
            this.labelAlumno.Size = new System.Drawing.Size(35, 13);
            this.labelAlumno.TabIndex = 8;
            this.labelAlumno.Text = "label4";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(355, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Esta conectado con el nombre de:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(465, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmIncripcionAcursado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 404);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmIncripcionAcursado";
            this.Text = "Incripcion a cursado";
            this.Load += new System.EventHandler(this.frmIncripcionAcursado_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkBuscaCurso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labelAlumno;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}