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
    public partial class InscripcionesAdmin : Form
    {
       

         #region CONSTRUCTOR

         public InscripcionesAdmin()
        {
            InitializeComponent();
             this.dataListado.AutoGenerateColumns = false;
        }
        
        #endregion

        #region METODOS
         private void InscripcionesAdmin_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            Alumnos_InscripcionesLogic alil = new Alumnos_InscripcionesLogic();
            this.dataListado.DataSource = alil.GetAll();
            this.btnBuscar.Text = "Buscar";
        }

        public void Buscar()
        {
            Alumnos_InscripcionesLogic alil = new Alumnos_InscripcionesLogic();
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar algunos datos, seran remarcados");

            }
            else
            {
                this.dataListado.DataSource = alil.GetByAlumnoInscripto(this.txtBuscar.Text);
                this.btnBuscar.Text = "Listar";
                

            }
            

        }

        #endregion


        #region EVENTOS
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (this.btnBuscar.Text == "Buscar")
            {
                this.Buscar();
            }
            else
            {
                this.Listar();
            }
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmABMinscripcionAdmin frm = new frmABMinscripcionAdmin(ApplicationForm.ModoForm.Alta);
            frm.ShowDialog();
            this.Listar();
        }


        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((AlumnoInscripciones)this.dataListado.SelectedRows[0].DataBoundItem).IdInscripcion;
            frmABMinscripcionAdmin frm = new frmABMinscripcionAdmin(ID, ApplicationForm.ModoForm.Modificacion);         
            frm.ShowDialog();
            this.Listar();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((AlumnoInscripciones)this.dataListado.SelectedRows[0].DataBoundItem).IdInscripcion;
            frmABMinscripcionAdmin frm = new frmABMinscripcionAdmin(ID, ApplicationForm.ModoForm.Baja);
            frm.DesacCampos(true);
            frm.ShowDialog();
            this.Listar();
        }


        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            
            int ID = ((AlumnoInscripciones)this.dataListado.SelectedRows[0].DataBoundItem).IdInscripcion;
            frmABMinscripcionAdmin frm = new frmABMinscripcionAdmin(ID, ApplicationForm.ModoForm.Modificacion);
            frm.ModoEditar(true);
            frm.ShowDialog();
            this.Listar();
        }


        #endregion

       

        
    }
}
