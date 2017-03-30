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
    public partial class FrmListaComision : Form
    {
     

         #region VARIABLES

        public string par1, par2;
       

        #endregion
       
        #region PROPIEDADES
        #endregion
      
        #region CONSTRUCTOR

        public FrmListaComision()
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
            ComisionLogic ComL = new ComisionLogic();
            this.dataListado.DataSource = ComL.GetAll();
            //lblTotal.Text = "Total de registros;" + Convert.ToString(dataListado.Rows.Count);
            this.btnBuscar.Text = "Buscar";
        }
        public void Buscar()
        {
            ComisionLogic ComL = new ComisionLogic();
            if (txtBuscar.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");

            }
            else
            {
                this.dataListado.DataSource = ComL.GetByComision(this.txtBuscar.Text); /* Busca por Desc_Comision */
                this.btnBuscar.Text = "Listar";
                //lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);

            }
        }
        
      
        #endregion

        #region EVENTOS

        private void FrmListaComision_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Listar();
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


        private void dataListado_DoubleClick(object sender, EventArgs e)
        {


            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["IdComision"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["DescComision"].Value);


            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

       

       
    }
}
