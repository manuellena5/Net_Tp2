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
    public partial class ListaDeMateriasInscripto : Form
    {


        #region VARIABLES
        
        public  string nombre, apellido, descmateria,desccomision,idcurso;
        public int idusuario, idalumno;
        #endregion

        #region CONSTRUCTOR



        public ListaDeMateriasInscripto(string idper, string idusu, string nom, string ape)
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;
            this.nombre = nom;
            this.apellido = ape;
            this.idusuario = Convert.ToInt32(idusu);
            this.idalumno = Convert.ToInt32(idper);

        }

        public ListaDeMateriasInscripto(string idper)
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;
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
            this.dataListado.DataSource = alogic.MatInscriptasDeAlumno(idalumno);
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

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            idcurso = Convert.ToString(this.dataListado.CurrentRow.Cells["IdCurso"].Value);
            descmateria = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_materia"].Value);
            desccomision = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_comision"].Value);
            
        }

        
        
        #endregion

       
    }
}
