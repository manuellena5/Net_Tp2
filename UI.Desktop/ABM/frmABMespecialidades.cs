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
    public partial class frmABMespecialidades : ApplicationForm
    {
        


        #region variables

        private _Especialidades _especialidadactual;

        #endregion

        #region PROPIEDADES

        public _Especialidades EspecialidadActual
        {
            get { return _especialidadactual; }
            set { _especialidadactual = value; }
        }
        
        #endregion
        
        #region CONSTRUCTOR

        public frmABMespecialidades()
        {
            InitializeComponent();
        }


       
        public frmABMespecialidades(ModoForm modo):this()
        {
            Modo = modo;
        }

        public frmABMespecialidades(int ID, ModoForm modo)
            : this() 
        {
            EspecialidadLogic el = new EspecialidadLogic();
            Modo = modo;
            EspecialidadActual = el.TraerUno(ID);
            MapearDeDatos();

        }
        #endregion
        
        
        #region METODOS



        public override void MapearDeDatos()
        {
            //Validaciones val = new Validaciones();
            this.txtIdEspecialidad.Text = Convert.ToString(EspecialidadActual.Idespecialidad);
            this.txtDescEspecialidad.Text = EspecialidadActual.DescEspecialidad;

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
                    _Especialidades espe = new _Especialidades();
                    EspecialidadActual = espe;
                    EspecialidadActual.DescEspecialidad = this.txtDescEspecialidad.Text;
                    EspecialidadActual.Estado = BusinessEntity.Estados.Nuevo;

                    break;

                case ModoForm.Baja:
                    EspecialidadActual.Estado = BusinessEntity.Estados.Eliminar;
                    break;

                case ModoForm.Modificacion:
                    EspecialidadActual.DescEspecialidad = this.txtDescEspecialidad.Text;
                    EspecialidadActual.Estado = BusinessEntity.Estados.Modificar;
                    break;

                case ModoForm.Consulta:
                    EspecialidadActual.Estado = BusinessEntity.Estados.No_Modificar;

                    break;

                default:
                    break;
            }


        }



        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic el = new EspecialidadLogic();
            el.Save(EspecialidadActual);

        }

        public override bool Validar()
        {
            if (this.txtDescEspecialidad.Text != string.Empty)
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

        public void DesacCampos (bool valor)
        {
            this.txtDescEspecialidad.ReadOnly = valor;
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

       
        #endregion






    }
}
