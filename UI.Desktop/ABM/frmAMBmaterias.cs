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
    public partial class frmAMBmaterias : ApplicationForm
    {
        

        
        #region VARIABLES

        private Business.Entities.Materias _MateriaActual;
        
        #endregion
       
        #region PROPIEDADES

        public Business.Entities.Materias MateriaActual
        {
            get { return _MateriaActual; }
            set { _MateriaActual = value; }
        }
        
        #endregion
        
        #region CONSTRUCTOR


        public frmAMBmaterias()
        {
            InitializeComponent();
        }

       
        public frmAMBmaterias(ModoForm modo):this()
        {
            Modo = modo;
        }

        public frmAMBmaterias(int ID, ModoForm modo)
            : this() 
        {
            MateriaLogic ml = new MateriaLogic();
            Modo = modo;
            MateriaActual = ml.TraerUno(ID);
            MapearDeDatos();

        }
        #endregion
        
        
        #region METODOS



        public override void MapearDeDatos()
        {
            //Validaciones val = new Validaciones();
            this.txtIdMateria.Text = Convert.ToString(MateriaActual.Id_Materia);
            this.txtDescMateria.Text = MateriaActual.Desc_Materia;
            this.txtHsSemanal.Text = Convert.ToString(MateriaActual.Hs_Semanales);
            this.txtHsTotal.Text = Convert.ToString(MateriaActual.Hs_Totales);
            this.txtIdPlan.Text = Convert.ToString(MateriaActual.Id_Plan);
            this.txtDescPlan.Text = MateriaActual.Plan;

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    //this.linkLabel1.Visible = false;
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    //this.linkLabel1.Visible = false;
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
           
            
        }
       
        public override void MapearADatos()
        {
            //Validaciones val = new Validaciones();
            switch (this.Modo)
            {

                case ModoForm.Alta:
                    Business.Entities.Materias mat = new Business.Entities.Materias();
                    MateriaActual = mat;

                    //PlanActual.Codigo = Convert.ToInt32(this.txtIdPlan.Text);
                    MateriaActual.Desc_Materia = this.txtDescMateria.Text;
                    MateriaActual.Hs_Semanales = Convert.ToInt32(this.txtHsSemanal.Text);
                    MateriaActual.Hs_Totales = Convert.ToInt32(this.txtHsTotal.Text);
                    MateriaActual.Id_Plan = Convert.ToInt32(this.txtIdPlan.Text);
                    MateriaActual.Plan = this.txtDescPlan.Text;
                    MateriaActual.Estado = BusinessEntity.Estados.Nuevo;

                    break;

                case ModoForm.Baja:
                    MateriaActual.Estado = BusinessEntity.Estados.Eliminar;
                    break;

                case ModoForm.Modificacion:
                    MateriaActual.Desc_Materia = this.txtDescMateria.Text;
                    MateriaActual.Hs_Semanales = Convert.ToInt32(this.txtHsSemanal.Text);
                    MateriaActual.Hs_Totales = Convert.ToInt32(this.txtHsTotal.Text);
                    MateriaActual.Id_Plan = Convert.ToInt32(this.txtIdPlan.Text);
                    MateriaActual.Plan = this.txtDescPlan.Text;
                    MateriaActual.Estado = BusinessEntity.Estados.Modificar;
                    break;

                case ModoForm.Consulta:
                    MateriaActual.Estado = BusinessEntity.Estados.No_Modificar;

                    break;

                default:
                    break;
            }


        }
        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic ml = new MateriaLogic();
            ml.Save(MateriaActual);

        }

        public override bool Validar()
        {
            if (this.txtDescMateria.Text != string.Empty && this.txtHsSemanal.Text != string.Empty && this.txtHsTotal.Text != string.Empty && this.txtIdPlan.Text != string.Empty)
            {
                return true;
            }
            else
            {
                Notificar("Faltan ingresar datos o ingresó datos incorrectos", "Revise la informacion ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        new public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        new public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        public void Planes(string Codigo, string nombre)
        {
            this.txtIdPlan.Text = Codigo;
            this.txtDescPlan.Text = nombre;

        }

        public void DesacCampos (bool valor)
        {
            this.txtIdMateria.ReadOnly = valor;
            this.txtDescMateria.ReadOnly = valor;
            this.txtHsSemanal.ReadOnly = valor;
            this.txtHsTotal.ReadOnly = valor;
            this.txtIdPlan.ReadOnly = valor;
            this.txtDescPlan.ReadOnly = valor;
            this.linkLabel1.Visible = !valor;
        }

        #endregion

        #region EVENTOS

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLista_Plan frm = new FrmLista_Plan();
            frm.ShowDialog();
            this.Planes(frm.par1, frm.par2);
        }
        #endregion
    }
}
