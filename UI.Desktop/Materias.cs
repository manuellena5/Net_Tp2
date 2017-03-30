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
    public partial class Materias : Form
    {
        
         #region CONSTRUCTOR

        
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
        }
        #endregion

        #region METODOS
        private void Materias_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            this.dgvMaterias.DataSource = ml.GetAll();
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
            frmAMBmaterias frmmat = new frmAMBmaterias(ApplicationForm.ModoForm.Alta);
            frmmat.ShowDialog();
            this.Listar();
        }


        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materias)this.dgvMaterias.SelectedRows[0].DataBoundItem).Id_Materia;
            frmAMBmaterias frmmat = new frmAMBmaterias(ID, ApplicationForm.ModoForm.Modificacion);
            frmmat.ShowDialog();
            this.Listar();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materias)this.dgvMaterias.SelectedRows[0].DataBoundItem).Id_Materia;
            frmAMBmaterias frmmat = new frmAMBmaterias(ID, ApplicationForm.ModoForm.Baja);
            frmmat.DesacCampos(true);
            frmmat.ShowDialog();
            this.Listar();
        }

        #endregion
    }
}
