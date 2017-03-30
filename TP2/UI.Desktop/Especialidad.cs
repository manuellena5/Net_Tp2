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
    public partial class Especialidad : Form
    {
        #region CONSTRUCTOR
        public Especialidad()
        {
            InitializeComponent();
            this.dgvEspecialidad.AutoGenerateColumns = false;
        }

   

        #endregion

        #region METODOS
        private void Especialidad_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            this.dgvEspecialidad.DataSource = el.GetAll();
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
            frmABMespecialidades frm = new frmABMespecialidades(ApplicationForm.ModoForm.Alta);
            frm.ShowDialog();
            this.Listar();
        }


        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities._Especialidades)this.dgvEspecialidad.SelectedRows[0].DataBoundItem).Idespecialidad;
            frmABMespecialidades frm = new frmABMespecialidades(ID, ApplicationForm.ModoForm.Modificacion);
            frm.ShowDialog();
            this.Listar();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities._Especialidades)this.dgvEspecialidad.SelectedRows[0].DataBoundItem).Idespecialidad;
            frmABMespecialidades frm = new frmABMespecialidades(ID, ApplicationForm.ModoForm.Baja);
            frm.DesacCampos(true);
            frm.ShowDialog();
            this.Listar();
        }

        #endregion

        private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
       
    }
}
