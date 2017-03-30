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
    public partial class Cursos : Form
    {
       
         #region CONSTRUCTOR

         public Cursos()
        {
            InitializeComponent();
             this.dgvCursos.AutoGenerateColumns = false;
        }

        #endregion

        #region METODOS
        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            CursoLogic cl = new CursoLogic();
            this.dgvCursos.DataSource = cl.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region EVENTOS
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmABMcursos frm = new frmABMcursos(ApplicationForm.ModoForm.Alta);
            frm.ShowDialog();
            this.Listar();
        }


        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Cursos)this.dgvCursos.SelectedRows[0].DataBoundItem).IdCurso;
            frmABMcursos frm = new frmABMcursos(ID, ApplicationForm.ModoForm.Modificacion);
            frm.ShowDialog();
            this.Listar();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Cursos)this.dgvCursos.SelectedRows[0].DataBoundItem).IdCurso;
            frmABMcursos frm = new frmABMcursos(ID, ApplicationForm.ModoForm.Baja);
            frm.DesacCampos(true);
            frm.ShowDialog();
            this.Listar();
        }

        #endregion
    }
}
