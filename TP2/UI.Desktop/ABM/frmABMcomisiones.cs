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
    public partial class frmABMcomisiones : ApplicationForm
    {
        

          #region VARIABLES

        private Business.Entities.Comisiones _ComisionActual;
        
        #endregion
       
        #region PROPIEDADES

        public Business.Entities.Comisiones ComisionActual
        {
            get { return _ComisionActual; }
            set { _ComisionActual = value; }
        }
        
        #endregion
        
        #region CONSTRUCTOR

        public frmABMcomisiones()
        {
            InitializeComponent();
        }

        
        public frmABMcomisiones(ModoForm modo):this()
        {
            Modo = modo;
        }

        public frmABMcomisiones(int ID, ModoForm modo)
            : this() 
        {
            ComisionLogic cl = new ComisionLogic();
            Modo = modo;
            ComisionActual = cl.TraerUno(ID);
            MapearDeDatos();

        }
        #endregion
        
        
        #region METODOS



        public override void MapearDeDatos()
        {
            //Validaciones val = new Validaciones();
            this.txtIdComision.Text = Convert.ToString(ComisionActual.IdComision);
            this.txtDescComision.Text = ComisionActual.DescComision;
            this.txtAnioEspecialidad.Text = Convert.ToString(ComisionActual.AnioEspecialidad);
            this.txtIdPlan.Text = Convert.ToString(ComisionActual.IdPlan);
            this.txtDescPlan.Text = ComisionActual.Plan;


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
                    Business.Entities.Comisiones com = new Business.Entities.Comisiones();
                    ComisionActual = com;

                    //PlanActual.Codigo = Convert.ToInt32(this.txtIdPlan.Text);
                    ComisionActual.DescComision = this.txtDescComision.Text;
                    ComisionActual.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text);
                    ComisionActual.IdPlan = Convert.ToInt32(this.txtIdPlan.Text);
                    ComisionActual.Plan = this.txtDescPlan.Text;
                    ComisionActual.Estado = BusinessEntity.Estados.Nuevo;

                    break;

                case ModoForm.Baja:
                    ComisionActual.Estado = BusinessEntity.Estados.Eliminar;
                    break;

                case ModoForm.Modificacion:
                    ComisionActual.DescComision = this.txtDescComision.Text;
                    ComisionActual.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text);
                    ComisionActual.IdPlan = Convert.ToInt32(this.txtIdPlan.Text);
                    ComisionActual.Plan = this.txtDescPlan.Text;
                    ComisionActual.Estado = BusinessEntity.Estados.Modificar;
                    break;

                case ModoForm.Consulta:
                    ComisionActual.Estado = BusinessEntity.Estados.No_Modificar;

                    break;

                default:
                    break;
            }


        }
        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic cl = new ComisionLogic();
            cl.Save(ComisionActual);

        }

        public override bool Validar()
        {
            if (this.txtDescComision.Text != string.Empty && this.txtAnioEspecialidad.Text != string.Empty && this.txtIdPlan.Text != string.Empty)
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
            this.txtIdComision.ReadOnly = valor;
            this.txtDescComision.ReadOnly = valor;
            this.txtAnioEspecialidad.ReadOnly = valor;
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
