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
    public partial class FrmListaEspecialidades : Form
    {
        

        #region VARIABLES

        public string par1, par2;
       

        #endregion
       
        #region PROPIEDADES
        #endregion
      
        #region CONSTRUCTOR

        public FrmListaEspecialidades()
        {
            InitializeComponent();
            this.dgvListaEspecialidades.AutoGenerateColumns = false;
        }


        #endregion


        #region METODOS

        //private void MensajeError(string mensaje)
        //{
        //    MessageBox.Show(mensaje, "Sistema Academico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        
        public void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            this.dgvListaEspecialidades.DataSource = el.GetAll();
            this.btnBuscar.Text = "Buscar";
        }


        public void Buscar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            //if (txtBuscar.Text == string.Empty)
            //{
            //    MensajeError("Falta ingresar algunos datos, seran remarcados");
            //    errorIcono.SetError(txtBuscar, "Ingrese la materia a buscar");
            //}
            //else
            //{
                this.dgvListaEspecialidades.DataSource = el.GetByEspecialidad(this.txtListaEspecialidades.Text);

                
                this.btnBuscar.Text = "Listar";
            //}
        }
        
        #endregion

        #region EVENTOS

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void FrmListaEspecialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "Buscar")
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


            par1 = Convert.ToString(this.dgvListaEspecialidades.CurrentRow.Cells["Idespecialidad"].Value);
            par2 = Convert.ToString(this.dgvListaEspecialidades.CurrentRow.Cells["DescEspecialidad"].Value);
            //par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["IdMateria"].Value);
            //par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_materia"].Value);


            this.Hide();
        }



        #endregion

    }
}
