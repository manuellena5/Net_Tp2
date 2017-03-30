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
    public partial class frmABMplanes : ApplicationForm
    {
        

        #region VARIABLES

        private Business.Entities.Planes _PlanActual;
        
        #endregion
       
        #region PROPIEDADES

        public Business.Entities.Planes PlanActual
        {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }
        
        #endregion
        
        #region CONSTRUCTOR

        public frmABMplanes()
        {
            InitializeComponent();
        }

       
        public frmABMplanes(ModoForm modo):this()
        {
            Modo = modo;
        }

        public frmABMplanes(int ID, ModoForm modo):this() 
        {
            PlanLogic pl = new PlanLogic();
            Modo = modo;
            PlanActual = pl.TraerUno(ID);
            MapearDeDatos();

        }
        #endregion
        
        
        #region METODOS

        public void DesacCampos (bool valor)
        {
            this.txtDescripcion.ReadOnly = valor;
            this.lnkBuscarEspecialidad.Visible = !valor;
        }


        public override void MapearDeDatos()
        {
            //Validaciones val = new Validaciones();
            this.txtIdPlan.Text = Convert.ToString(PlanActual.Codigo);
            this.txtDescripcion.Text = PlanActual.Plan;
            this.txtIdEspecialidad.Text = Convert.ToString(PlanActual.Id_Especialidad);
            this.txtDescEspecialidad.Text = PlanActual.Especialidad;

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
                    Business.Entities.Planes plan = new Business.Entities.Planes();
                    PlanActual = plan;

                    //PlanActual.Codigo = Convert.ToInt32(this.txtIdPlan.Text);
                    PlanActual.Plan = this.txtDescripcion.Text;
                    PlanActual.Id_Especialidad = Convert.ToInt32(this.txtIdEspecialidad.Text);
                    PlanActual.Especialidad = this.txtDescEspecialidad.Text;
                    PlanActual.Estado = BusinessEntity.Estados.Nuevo;

                    break;

                case ModoForm.Baja:
                    PlanActual.Estado = BusinessEntity.Estados.Eliminar;
                    break;

                case ModoForm.Modificacion:
                     PlanActual.Plan = this.txtDescripcion.Text;
                    PlanActual.Id_Especialidad = Convert.ToInt32(this.txtIdEspecialidad.Text);
                    PlanActual.Especialidad = this.txtDescEspecialidad.Text;
                    PlanActual.Estado = BusinessEntity.Estados.Modificar;
                    break;

                case ModoForm.Consulta:
                    PlanActual.Estado = BusinessEntity.Estados.No_Modificar;

                    break;

                default:
                    break;
            }


        }
        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic pl = new PlanLogic();
            pl.Save(PlanActual);

        }

        public override bool Validar()
        {
            if (this.txtDescripcion.Text != string.Empty && this.txtIdEspecialidad.Text != string.Empty)
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

        public void Especialidad(string Codigo, string nombre)
        {
            this.txtIdEspecialidad.Text = Codigo;
            this.txtDescEspecialidad.Text = nombre;
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
            FrmListaEspecialidades frm = new FrmListaEspecialidades();
            frm.ShowDialog();
            this.Especialidad(frm.par1, frm.par2);
        }
        #endregion
    }
}
