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
    public partial class Usuarios : Form
    {
       
        
        #region VARIABLES
       
        int idpersona;
        
        #endregion
       
        
        #region PROPIEDADES
        #endregion
        
        
        #region CONSTRUCTOR

        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;

        }

        public Usuarios(string idp)
        {            
            idpersona = Convert.ToInt32(idp);


        }

        #endregion
        
        
        #region EVENTOS

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmABMusuarios usuDesk = new FrmABMusuarios(ApplicationForm.ModoForm.Alta);
            usuDesk.ShowDialog();
            this.Listar();

        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).Id_Usuario;
            FrmABMusuarios usuDesk = new FrmABMusuarios(ID, ApplicationForm.ModoForm.Modificacion);
            usuDesk.ShowDialog();
            this.Listar();

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).Id_Usuario;
            FrmABMusuarios usuDesk = new FrmABMusuarios(ID, ApplicationForm.ModoForm.Baja);
            usuDesk.DesacCampos(true);
            usuDesk.ShowDialog();
            this.Listar();
        }

        #endregion

        #region METODOS

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.DataSource = ul.GetAll();
        }

        #endregion


    }
}
