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
    public partial class frmListaMateriasRegulares : Form
    {


        #region VARIABLES
        
        public string nombre, apellido,par1,par2,par3,par4;
        public int idusuario, idalumno,idcurso;
        #endregion

        #region CONSTRUCTOR



        public frmListaMateriasRegulares(string idper)
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;
            //this.nombre = nom;
            //this.apellido = ape;
            //this.idusuario = Convert.ToInt32(idusu);
            this.idalumno = Convert.ToInt32(idper);

        }

          

        #endregion

        #region METODOS 
        
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Academico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void Listar()
        {
            Alumnos_InscripcionesLogic alogic = new Alumnos_InscripcionesLogic();
            this.dataListado.DataSource = alogic.MatRegularesDeAlumno(idalumno);
            //lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);
        }

        public void estado()
        { 
            
            this.labelAlumno.Text = nombre + "" + apellido;
        
        }

        

        #endregion
        
        
        #region EVENTOS



        private void Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void FrmListaAlumnos_Load(object sender, EventArgs e)
        {
            Listar();
            estado();
        }


        
        
        #endregion

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            CursoLogic cur = new CursoLogic();
            Business.Entities.Cursos cursoactual = new Business.Entities.Cursos();
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_materia"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_comision"].Value);
            cursoactual = cur.TraerCurso(par1, par2);

            idcurso = cursoactual.IdCurso;
            this.Hide();
        }

    }
}
