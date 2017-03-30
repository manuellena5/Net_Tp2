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
    public partial class Comisiones : Form
    {
       

        #region CONSTRUCTOR


        public Comisiones()
        {
            InitializeComponent();
             this.dgvComisiones.AutoGenerateColumns = false;
        }
        
        #endregion

        #region METODOS
        private void Comisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            ComisionLogic cl = new ComisionLogic();
            this.dgvComisiones.DataSource = cl.GetAll();
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
            frmABMcomisiones frm = new frmABMcomisiones(ApplicationForm.ModoForm.Alta);
            frm.ShowDialog();
            this.Listar();
        }


        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Comisiones)this.dgvComisiones.SelectedRows[0].DataBoundItem).IdComision;
            frmABMcomisiones frm = new frmABMcomisiones(ID, ApplicationForm.ModoForm.Modificacion);
            frm.ShowDialog();
            this.Listar();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Comisiones)this.dgvComisiones.SelectedRows[0].DataBoundItem).IdComision;
            frmABMcomisiones frm = new frmABMcomisiones(ID, ApplicationForm.ModoForm.Baja);
            frm.DesacCampos(true);
            frm.ShowDialog();
            this.Listar();
        }

        #endregion
    }
}
