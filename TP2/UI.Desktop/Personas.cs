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
    public partial class Personas : Form
    {
        #region VARIABLES
        #endregion

        #region PROPIEDADES
        #endregion

        #region CONSTRUCTOR

        public Personas()
        {
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns = false;
        } 
        
        #endregion

        #region METODOS
        
        public void listar ()
        {
            PersonaLogic perl = new PersonaLogic();

            this.dgvPersonas.DataSource = perl.GetAll();

        }
        
        #endregion

        

        #region EVENTOS

        private void Personas_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmABMpersonas frmper = new frmABMpersonas(ApplicationForm.ModoForm.Alta);
            frmper.ShowDialog();
            this.listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities._Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).Codigo;
            frmABMpersonas frmper = new frmABMpersonas(ID, ApplicationForm.ModoForm.Modificacion);
            frmper.ShowDialog();
            this.listar();
        }


        #endregion

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities._Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).Codigo;
            frmABMpersonas frmper = new frmABMpersonas(ID, ApplicationForm.ModoForm.Baja);
            frmper.DesacCampos(true);
            frmper.ShowDialog();
            this.listar();
        }

        

        

                    

        

       
    }
}
