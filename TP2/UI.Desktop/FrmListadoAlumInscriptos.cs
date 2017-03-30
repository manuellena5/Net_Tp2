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
    public partial class FrmListadoAlumInscriptos : Form
    {
        
        
         #region VARIABLES

        public string par1, par2, par3;
       

        #endregion
       

        #region CONSTRUCTOR

        public FrmListadoAlumInscriptos()
        {
            InitializeComponent();
        }

        #endregion


        #region METODOS

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Academico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public void Listar()
        {
            Alumnos_InscripcionesLogic aluL = new Alumnos_InscripcionesLogic();
            this.dataListado.DataSource = aluL.TraerTodosLosInscriptos();
            this.Ocultarcolumna();
            lblTotal.Text = "Total de registros;" + Convert.ToString(dataListado.Rows.Count);
            btnListar.Visible = false;
        }
        public void Buscar()
        {
            Alumnos_InscripcionesLogic aluL = new Alumnos_InscripcionesLogic();
            if (txtBuscar.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");
                errorIcono.SetError(txtBuscar, "Ingrese la materia a buscar");
            }
            else
            {
                this.dataListado.DataSource = aluL.GetByAlumnoInscripto(this.txtBuscar.Text);

                lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);
                this.btnListar.Visible = true;
            }
        }
        private void Ocultarcolumna()
        {
            //this.dataListado.Columns[1].Visible = false;
            //this.dataListado.Columns[3].Visible = false;
            //this.dataListado.Columns[4].Visible = false;
            //this.dataListado.Columns[5].Visible = false;
            //this.dataListado.Columns[8].Visible = false;
            //this.dataListado.Columns[9].Visible = false;
        }
        
        #endregion

        #region EVENTOS

        private void FrmListadoAlumInscriptos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }




        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }


        private void dataListado_DoubleClick(object sender, EventArgs e)
        {


            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["IdInscripcion"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["IdCurso"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["IdAlumnos"].Value);



            this.Hide();
        }



        #endregion

      
        
    }
}
