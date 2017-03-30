using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class frmIncripcionAcursado : ApplicationForm
    {

        #region VARIABLES
        
        string nombre,apellido,comision,materia;
        int idpersona,idusuario;
        Alumnos_InscripcionesLogic _aiL = new Alumnos_InscripcionesLogic();
        
        #endregion

        #region PROPIEDADES

        public Alumnos_InscripcionesLogic AiL
        {
            get { return _aiL; }
            set { _aiL = value; }
        }

        #endregion


        #region CONSTRUCTOR

        public frmIncripcionAcursado()
        {
            InitializeComponent();
        }

        public frmIncripcionAcursado(string IdPer,string IdUsu,string Nom,string Ape)
        {
            InitializeComponent();
            this.nombre = Nom;
            this.apellido = Ape;
            this.idpersona = Convert.ToInt32(IdPer);
            this.idusuario = Convert.ToInt32(IdUsu);

        }

        #endregion

        #region METODOS

        public void Cursos(string CodCurso, string DescCom, string CodMat, string DescMat)
        {
            

            this.txtComision.Text = DescCom;
            this.txtMateria.Text = DescMat;
            this.txtIdCurso.Text = CodCurso;
            this.comision = DescCom;
            this.materia = DescMat;

            

        }

        public void estado()
        {
            this.labelAlumno.Text = nombre + " " + apellido;
        }


        public void informe()
        {
            MessageBox.Show("Alumno: " + nombre + " " + apellido + "\n" + "Inscripto en la materia: " + materia + "\n" + "En la comision: " + comision + "\n" + "Fecha: " + DateTime.Now);

        }

       new public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        // para unificar el mecanismo de avisos al usuario
       new public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        public void limpiar ()
       {
           this.txtComision.Text = string.Empty;
           this.txtMateria.Text = string.Empty;
       }

        #endregion


        #region EVENTOS

        private void frmIncripcionAcursado_Load(object sender, EventArgs e)
        {
            this.estado();
            this.btnCancelar.Visible = false;
        }

        private void linkBuscaCurso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmListaCursos form = new FrmListaCursos();
            form.ShowDialog();
            Cursos(form.par1, form.par2, form.par3, form.par4);
            this.btnCancelar.Visible = true;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtMateria.Text == string.Empty)
                {
                    this.Notificar("Falta completar algun campo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    AlumnoInscripciones alu = new AlumnoInscripciones();
                    alu.IdCurso = Convert.ToInt32(this.txtIdCurso.Text);
                    alu.IdAlumnos = idpersona;
                    alu.Condicion = "Cursando";
                    alu.Nota = 0;
                    alu.Estado = BusinessEntity.Estados.Nuevo;
                    AiL.Insertar(alu);
                    this.informe();
                    this.btnCancelar.Visible = false;
                    this.limpiar();


                }

            }

            catch (Exception exp)
            {
                this.Notificar(exp.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }


        #endregion






        #region NO IMPLEMENTADOS

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

       


    }
}
