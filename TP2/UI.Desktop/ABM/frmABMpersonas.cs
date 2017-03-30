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
using Util;

namespace UI.Desktop
{
    public partial class frmABMpersonas : ApplicationForm
    {

        #region variables
        private _Personas personaactual;

        #endregion


        #region propiedades

        public _Personas Personaactual
        {
            get { return personaactual; }
            set { personaactual = value; }
        }

        #endregion


        #region CONSTRUCTOR

        public frmABMpersonas()
        {
            InitializeComponent();
        }

        public frmABMpersonas(ModoForm modo):this()
        {
            Modo = modo;
        }

        public frmABMpersonas(int ID, ModoForm modo):this() 
        {
            PersonaLogic per = new PersonaLogic();
            Modo = modo;
            personaactual = per.TraerUno(ID);
            MapearDeDatos();

        }


        #endregion

        #region metodos

        public override void MapearDeDatos() 
        {

                this.txtIdPersona.Text = Convert.ToString(Personaactual.Codigo);
                this.txtNombre.Text = Personaactual.Nombre;
                this.txtApellido.Text = Personaactual.Apellido;
                this.txtEmail.Text = Personaactual.Email;
                this.txtDireccion.Text = Personaactual.Direccion;
                this.txtLegajo.Text = Convert.ToString(Personaactual.Legajo);
                this.txtTelefono.Text = Convert.ToString(Personaactual.Telefono);
                this.dtpFechaNac.Value = Convert.ToDateTime(Personaactual.Fecha_Nac);
                this.cbSexo.Text = Convert.ToString(Personaactual.Sexo);
                this.cbTipoAcceso.Text = Personaactual.Tipo_Persona;
                this.txtIdPlan.Text = Convert.ToString(Personaactual.Id_Plan);
                this.txtDescPlan.Text = Convert.ToString(Personaactual.Plan);
                switch (Modo)
                {
                    case ModoForm.Alta:
                        btnAceptar.Text = "Guardar";
                        break;

                    case ModoForm.Baja:
                        btnAceptar.Text = "Eliminar";
                        break;

                    case ModoForm.Modificacion:
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
                switch (this.Modo)
                {

                    case ModoForm.Alta:
                        _Personas usu = new _Personas();
                    Personaactual = usu;

                    //personaactual.Codigo = Convert.ToInt32(this.txtIdPersona.Text);
                    Personaactual.Nombre = this.txtNombre.Text;
                    Personaactual.Apellido = this.txtApellido.Text;
                    Personaactual.Direccion = this.txtDireccion.Text;
                    Personaactual.Email = this.txtEmail.Text;
                    Personaactual.Telefono = this.txtTelefono.Text;
                    Personaactual.Fecha_Nac = this.dtpFechaNac.Value;
                    Personaactual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
                    Personaactual.Tipo_Persona = Convert.ToString(this.cbTipoAcceso.SelectedItem);
                    Personaactual.Id_Plan = Convert.ToInt32(this.txtIdPlan.Text);
                    Personaactual.Plan = this.txtDescPlan.Text;
                    Personaactual.Sexo = Convert.ToString(this.cbSexo.SelectedItem);
                    Personaactual.Estado = BusinessEntity.Estados.Nuevo;

                        break;

                    case ModoForm.Baja:
                        Personaactual.Estado = BusinessEntity.Estados.Eliminar;
                        break;

                    case ModoForm.Modificacion:
                        Personaactual.Codigo = Convert.ToInt32(this.txtIdPersona.Text);
                        Personaactual.Nombre = this.txtNombre.Text;
                        Personaactual.Apellido = this.txtApellido.Text;
                        Personaactual.Direccion = this.txtDireccion.Text;
                        Personaactual.Email = this.txtEmail.Text;
                        Personaactual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
                        Personaactual.Fecha_Nac = this.dtpFechaNac.Value;
                        Personaactual.Telefono = this.txtTelefono.Text;
                        Personaactual.Sexo = Convert.ToString(this.cbSexo.SelectedItem);
                        Personaactual.Tipo_Persona = Convert.ToString(this.cbTipoAcceso.SelectedItem);
                        Personaactual.Id_Plan = Convert.ToInt32(this.txtIdPlan.Text);
                        Personaactual.Plan = this.txtDescPlan.Text;
                        Personaactual.Estado = BusinessEntity.Estados.Modificar;
                        break;

                    case ModoForm.Consulta:
                        Personaactual.Estado = BusinessEntity.Estados.No_Modificar;

                        break;

                    default:
                        break;
                }
        
        
        } 
        public override void GuardarCambios() 
        {
            MapearADatos();
            PersonaLogic per = new PersonaLogic();
            per.Save(Personaactual);
        
        } 


        public override bool Validar() 
        {
            if (this.txtApellido.Text != string.Empty && this.txtNombre.Text != string.Empty && this.txtTelefono.Text != string.Empty && this.txtIdPlan.Text != string.Empty && this.txtDireccion.Text != string.Empty && this.txtLegajo.Text != string.Empty && this.cbSexo.Text != string.Empty && this.txtEmail.Text != string.Empty && this.cbTipoAcceso.Text != string.Empty && this.dtpFechaNac.Text != string.Empty && this.txtDescPlan.Text != string.Empty && Validaciones.esEmailValido(this.txtEmail.Text))
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
        // para unificar el mecanismo de avisos al usuario
       new public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        public void planes(string Codigo, string descripcion)
        {
            this.txtIdPlan.Text = Codigo;
            this.txtDescPlan.Text = descripcion;
            
        }


        public void DesacCampos (bool valor)
        {
           
            this.txtIdPersona.ReadOnly = valor;
            this.txtNombre.ReadOnly = valor;
            this.txtApellido.ReadOnly = valor;
            this.txtEmail.ReadOnly = valor;
            this.txtDireccion.ReadOnly = valor;
            this.txtLegajo.ReadOnly = valor;
            this.txtTelefono.ReadOnly = valor;
            this.dtpFechaNac.Enabled = !valor;
            this.cbSexo.Enabled = !valor;
            this.cbTipoAcceso.Enabled = !valor;
            this.txtIdPlan.ReadOnly = valor;
            this.txtDescPlan.ReadOnly = valor;
            this.linkBuscPlan.Visible = !valor;

        }
        #endregion

       

        

        #region eventos

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
            this.Close();
        }

        private void linkBuscPlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmLista_Plan frm = new FrmLista_Plan();
            frm.ShowDialog();
            planes(frm.par1, frm.par2);

        }


        #endregion

       
        private void frmABMpersonas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
