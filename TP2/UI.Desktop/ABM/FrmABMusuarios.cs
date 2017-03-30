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
using Util;

namespace UI.Desktop
{
    public partial class FrmABMusuarios : ApplicationForm
    {
        #region VARIABLES

        private Usuario _UsuarioActual;
        
        #endregion
       
        #region PROPIEDADES

        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
            set { _UsuarioActual = value; }
        }
        
        #endregion
        
        #region CONSTRUCTOR

        public FrmABMusuarios()
        {
            InitializeComponent();
        }

        public FrmABMusuarios(ModoForm modo):this()
        {
            Modo = modo;
        }

        public FrmABMusuarios(int ID, ModoForm modo):this() 
        {
            UsuarioLogic usu = new UsuarioLogic();
            Modo = modo;
            UsuarioActual = usu.TraerUno(ID);
            MapearDeDatos();

        }
        #endregion
        
        
        #region METODOS



        public override void MapearDeDatos()
        {
            Validaciones val = new Validaciones();
            this.txtIdPersona.Text = Convert.ToString(UsuarioActual.Id_persona);
            this.txtNombre.Text = UsuarioActual.Nombre;
            this.txtApellido.Text = UsuarioActual.Apellido;
            this.txtEmail.Text = UsuarioActual.Email;
            this.txtUsuario.Text = UsuarioActual.Nombre_Usuario;
            this.txtClave.Text = val.DecryptKey(UsuarioActual.Clave);
            this.txtConfirmarClave.Text = val.DecryptKey(UsuarioActual.Clave);
            this.txtIdUsuario.Text = Convert.ToString(UsuarioActual.Id_Usuario);
            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.linkLabel1.Visible = false;
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.linkLabel1.Visible = false;
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
        
        {   Validaciones val = new Validaciones();
            switch (this.Modo)
            {
                    
                case ModoForm.Alta:
                    Usuario usu = new Usuario();
                UsuarioActual = usu;
                
                UsuarioActual.Id_persona = Convert.ToInt32(this.txtIdPersona.Text);
                UsuarioActual.Nombre = this.txtNombre.Text;
                UsuarioActual.Apellido = this.txtApellido.Text;
                UsuarioActual.Email = this.txtEmail.Text;
                UsuarioActual.Nombre_Usuario = this.txtUsuario.Text;
                UsuarioActual.Clave = val.EncryptKey(this.txtClave.Text);
                UsuarioActual.Estado = BusinessEntity.Estados.Nuevo;

                    break;
               
                case ModoForm.Baja:
                    UsuarioActual.Estado = BusinessEntity.Estados.Eliminar;
                    break;
               
                case ModoForm.Modificacion:
                UsuarioActual.Id_persona = Convert.ToInt32(this.txtIdPersona.Text);
                UsuarioActual.Nombre = this.txtNombre.Text;
                UsuarioActual.Apellido = this.txtApellido.Text;
                UsuarioActual.Email = this.txtEmail.Text;
                UsuarioActual.Nombre_Usuario = this.txtUsuario.Text;
                UsuarioActual.Clave = val.EncryptKey(this.txtClave.Text);
                UsuarioActual.Estado = BusinessEntity.Estados.Modificar;
                    break;
               
                case ModoForm.Consulta:
                    UsuarioActual.Estado = BusinessEntity.Estados.No_Modificar;

                    break;
                
                default:
                    break;
            }
            
        
        }
        public override void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic usu = new UsuarioLogic();
            usu.Save(UsuarioActual);

        }

        public override  bool Validar() {
            if (this.txtApellido.Text != string.Empty && this.txtNombre.Text != string.Empty && this.txtUsuario.Text != string.Empty && this.txtClave.Text != string.Empty && this.txtConfirmarClave.Text != string.Empty && this.txtEmail.Text != string.Empty && Validaciones.esPasswordValida(this.txtClave.Text) && this.txtClave.Text == this.txtConfirmarClave.Text && Validaciones.esEmailValido(this.txtEmail.Text) )
            {
                return true;
            }
            else
            {
                Notificar("Faltan ingresar datos o ingresó datos incorrectos","Revise la informacion ingresada",MessageBoxButtons.OK,MessageBoxIcon.Error); 
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

        public void personas(string Codigo, string nombre, string apellido, string email)
        {
            this.txtIdPersona.Text = Codigo;
            this.txtNombre.Text = nombre;
            this.txtApellido.Text = apellido;
            this.txtEmail.Text = email;
        }


        public void DesacCampos (bool valor)
        {
            this.txtIdPersona.ReadOnly = valor;
            this.txtNombre.ReadOnly = valor;
            this.txtApellido.ReadOnly = valor;
            this.txtEmail.ReadOnly = valor;
            this.txtUsuario.ReadOnly = valor;
            this.txtClave.ReadOnly = valor;
            this.txtConfirmarClave.Enabled = !valor;
            this.txtIdUsuario.ReadOnly = valor;
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
            FrmListaPersona frm = new FrmListaPersona();
            frm.ShowDialog();
            personas(frm.par1, frm.par2, frm.par3, frm.par4);
        }
        #endregion

        

        private void frmUsuDktp_Load(object sender, EventArgs e)
        {

        }

        
        
    }
}
