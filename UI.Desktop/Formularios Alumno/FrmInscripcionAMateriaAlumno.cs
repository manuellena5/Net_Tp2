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
    public partial class FrmInscripcionAMateriaAlumno : Form
    {
       
        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

      

        #region VARIABLES
        //private bool Isnuevo = false;
        //private bool IsEditar = false;
        Alumnos_InscripcionesLogic _aiL = new Alumnos_InscripcionesLogic();
        public int idpersona, idusuario,idcurso,idcomision;
        public string nombre, apellido,comision,materia;
        
                

        #endregion

        #region PROPIEDADES
        public Alumnos_InscripcionesLogic AiL
        {
            get { return _aiL; }
            set { _aiL = value; }
        }


        #endregion

        #region CONSTRUCTOR

        public FrmInscripcionAMateriaAlumno()
        {
            InitializeComponent();
            
        }

        public FrmInscripcionAMateriaAlumno(string idp,string idu,string nom,string ap)
        {
            InitializeComponent();
            idpersona = Convert.ToInt32(idp);
            idusuario = Convert.ToInt32(idu);
            nombre = nom;
            apellido = ap;
        
        
        }

        #endregion


        #region METODOS

       
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Academico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        

        private void Limpiar()
        {
            this.txtMateria.Text = string.Empty;
            this.txtDescComision.Text = string.Empty;

            this.btnCancelar.Visible = true;

        }




        public void MateriasRegulares(string CodCurso, string DescMat,string DescCom)
        {
            this.txtIdCurso.Text = CodCurso;
            this.txtMateria.Text = DescMat;
            this.txtDescComision.Text = DescCom;
            idcurso = Convert.ToInt32(CodCurso);
            comision = DescCom;
            materia = DescMat;

        }

        public void estado()
        {           
            this.lblAlumno.Text = nombre + " " + apellido;
        }

        public void informe ()
        {
            MessageBox.Show("Alumno: " + nombre + " " + apellido + "\n" + "Inscripto en la materia: " + materia + "\n" + "En la comision: " + comision + "\n" + "Fecha: " + DateTime.Now );

        }


        #endregion

        #region EVENTOS

        private void FrmInscripcionAMateriaAlumno_Load(object sender, EventArgs e)
        {
            estado();
           
        }


        private void lblListaCurso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListaMateriasRegulares form = new frmListaMateriasRegulares(Convert.ToString(idpersona));
            form.ShowDialog();
            MateriasRegulares(Convert.ToString(form.idcurso),form.par1, form.par2); /*par1 descMateria par2 descComision */ 
            
        }
        
  
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtMateria.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(txtMateria, "Ingrese una materia");
                   
                }
                else
                {      
                        AlumnoInscripciones alu = new AlumnoInscripciones();
                        alu.IdCurso = Convert.ToInt32(this.txtIdCurso.Text);
                        alu.IdAlumnos = idpersona;
                        alu.Condicion = "Examen";
                        alu.Nota = 0;
                        alu.Estado = BusinessEntity.Estados.Nuevo;
                        AiL.Insertar(alu);
                        informe();


                    }
                    
                }
            
            catch (Exception exp)
            {
                this.MensajeError(exp.Message);
                throw;
            }

            this.Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
       
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        
    }
}
