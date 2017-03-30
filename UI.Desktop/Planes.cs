using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class Planes : Form
    {
       

        #region CONSTRUCTOR

         public Planes()
        {
            InitializeComponent();
             this.dgvPlanes.AutoGenerateColumns = false;
        }

        #endregion

        #region METODOS
        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            PlanLogic pl = new PlanLogic();
            this.dgvPlanes.DataSource = pl.GetAll();
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
            frmABMplanes frmpl = new frmABMplanes(ApplicationForm.ModoForm.Alta);
            frmpl.ShowDialog();
            this.Listar();
        }
        

        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Planes)this.dgvPlanes.SelectedRows[0].DataBoundItem).Codigo;
            frmABMplanes frmpl = new frmABMplanes(ID, ApplicationForm.ModoForm.Modificacion);
            frmpl.ShowDialog();
            this.Listar();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Planes)this.dgvPlanes.SelectedRows[0].DataBoundItem).Codigo;
            frmABMplanes frmpl = new frmABMplanes(ID, ApplicationForm.ModoForm.Baja);
            frmpl.DesacCampos(true);
            frmpl.ShowDialog();
            
            this.Listar();
        }

        #endregion
    }
}
