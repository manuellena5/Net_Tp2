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
    public partial class FrmListaAlumnos : Form
    {
        #region VARIABLES

        public string par1, par2, par3,par4;
        
        #endregion

        #region CONSTRUCTOR
        
        public FrmListaAlumnos()
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
            PersonaLogic per = new PersonaLogic();
            this.dataListado.DataSource = per.GetAllAlumno();
            //lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);
            this.btnBuscar.Text = "Buscar";
        }

        public void Buscar()
        {
            PersonaLogic per = new PersonaLogic();
            if (txtBuscar.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");
      
            }
            else
            {
                this.dataListado.DataSource = per.GetByAlumno(this.txtBuscar.Text); /* Por apellido */
                this.btnBuscar.Text = "Listar";
                //lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);

            }
        }

        

        #endregion
        
        
        #region EVENTOS

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.btnBuscar.Text =="Buscar")
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

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void FrmListaAlumnos_Load(object sender, EventArgs e)
        {
            Listar();
        }


        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Codigo"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["Apellido"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Legajo"].Value);
            this.Hide();
        }
        
        #endregion

       
      
    }
}
