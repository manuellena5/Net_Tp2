using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class FrmListaPersona : Form
    {

        #region VARIABLES
        
        public string par1, par2,par3,par4;

        #endregion


        #region CONSTRUCTOR

        public FrmListaPersona()
        {
            InitializeComponent();
            this.dataListado.AutoGenerateColumns = false;
        }

        #endregion


        #region METODOS

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Academico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      
        public void Listar()
        {
            PersonaLogic ul = new PersonaLogic();
            this.dataListado.DataSource = ul.GetAll();
            //this.Ocultarcolumna();
           // lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);
            this.btnBuscar.Text = "Buscar";
        }

        public void Buscar()
        {
            PersonaLogic pl = new PersonaLogic();
            if (txtBuscar.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");

            }
            else
            {
                this.dataListado.DataSource = pl.GetByPersona(this.txtBuscar.Text);
                this.btnBuscar.Text = "Listar";
                // lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);

            }
        }

        #endregion

        #region EVENTOS

        private void FrmListaUsuario_Load(object sender, EventArgs e)
        {
            Listar();
      
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Codigo"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["Apellido"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Email"].Value);
            this.Hide();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        
    }
}
