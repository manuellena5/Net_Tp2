using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Util;
using Data.Database;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Formulario
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string estado;
        protected void Page_Load(object sender, EventArgs e)
        
        {
            this.txtusuario.Focus();
        }
        UsuarioLogic _perso = new UsuarioLogic();

        public UsuarioLogic Perso
        {
            get { return _perso; }
            set { _perso = value; }
        }
        public enum gestion
        {
            Administrador = 1,
            Profesor,
            Alumno
        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                List<Usuario> listadoPersonas = new List<Usuario>();
                Validaciones encrip = new Validaciones();
                listadoPersonas = Perso.GetAll();
                //string usuario, password;
                bool usuarioencontrado = false;
                int i = 0;
                
                while (!usuarioencontrado && i < listadoPersonas.Count())
                {
                    if (this.txtusuario.Text.ToLower() == listadoPersonas[i].Nombre_Usuario.ToLower())
                    {
                        if (encrip.EncryptKey(this.Txtcontrasena.Text) == listadoPersonas[i].Clave)
                        {
                            usuarioencontrado = true;
                            Session["codigo"] = listadoPersonas[i].Id_Usuario;
                            Session["Usuario"] = listadoPersonas[i].Nombre_Usuario;
                            Session["Nombre"] = listadoPersonas[i].Nombre;
                            Session["Apellido"] = listadoPersonas[i].Apellido;
                            estado=listadoPersonas[i].Tipo;
                            if (estado==Convert.ToString(gestion.Administrador))
                            {
                                Session["Tipo"] = 1; 
                            }
                            else if (estado == Convert.ToString(gestion.Profesor))
                            {
                                Session["Tipo"] = 2; 
                            }
                            else
                            {
                                Session["Tipo"] = 3;     
                            }
                            Session["CodPersona"] = listadoPersonas[i].Id_persona;
                            Session["IdUsuario"] = listadoPersonas[i].Id_Usuario;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
                if (!usuarioencontrado)
                {
                    msglabel.Visible = true;
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }
            catch (Exception)
            {
                ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('Error al tratar de ingresar')", true);
            }
        }

    }
}