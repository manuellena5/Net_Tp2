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
    public partial class FrmListaCursos : Form
    {
        

         #region VARIABLES

        public string par1, par2,par3,par4;
       

        #endregion
       
        #region PROPIEDADES
        #endregion
      
        #region CONSTRUCTOR

        public FrmListaCursos()
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
            CursoLogic curL = new CursoLogic();
            this.dataListado.DataSource = curL.GetAll();
            this.btnBuscar.Text = "Buscar";
           // lblTotal.Text = "Total de registros;" + Convert.ToString(dataListado.Rows.Count);
        }
       
        public void Buscar()
        {
            CursoLogic curL = new CursoLogic();
            if (txtBuscar.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");
            }
            else
            {
                this.dataListado.DataSource = curL.GetByCurso(this.txtBuscar.Text); /*Busca por desc_materia */

                //lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);
                this.btnBuscar.Text = "Listar";
            }
        }
       
        
        #endregion

        #region EVENTOS

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void FrmListaCursos_Load(object sender, EventArgs e)
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


            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["IdCurso"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_comision"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["IdMateria"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_materia"].Value);


            this.Hide();
        }



        #endregion

      
        
        
    }
}
