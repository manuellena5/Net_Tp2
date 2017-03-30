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
    public partial class FrmListaMaterias : Form
    {

       

 

         #region VARIABLES

        public string par1, par2;
       

        #endregion
       
        #region PROPIEDADES
        #endregion
      
        #region CONSTRUCTOR

        public FrmListaMaterias()
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
            MateriaLogic MatL = new MateriaLogic();
            this.dataListado.DataSource = MatL.GetAll();
            //lblTotal.Text = "Total de registros;" + Convert.ToString(dataListado.Rows.Count);
            this.btnBuscar.Text = "Buscar";
        }
        public void Buscar()
        {
            MateriaLogic MatL = new MateriaLogic();
            if (txtBuscar.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");
            }
            else
            {
                this.dataListado.DataSource = MatL.GetByMateria(this.txtBuscar.Text);
                this.btnBuscar.Text = "Listar";
                //lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);
                
            }
        }

        
        #endregion

        #region EVENTOS

        private void FrmListaMaterias_Load(object sender, EventArgs e)
        {
            Listar();
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
            

            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Id_Materia"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_Materia"].Value);          

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        
        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        


    }
}
