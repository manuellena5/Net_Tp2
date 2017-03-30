using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web.Formulario
{
    public partial class frminscribirporAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        Alumnos_InscripcionesLogic _logic = new Alumnos_InscripcionesLogic();

        public Alumnos_InscripcionesLogic Logic
        {
            get { return _logic; }
            set { _logic = value; }
        }

        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            Object objeto = txtnombre.Text;
            //objeto.DataBind();
           int obj,tipo;
            AlumnoInscripciones alu = new AlumnoInscripciones();
            alu = Alumnos_InscripcionesLogic.GetByInscribirporAdministrador(Convert.ToString(objeto));
            obj = alu.IdAlumnos;
            tipo=Convert.ToInt32(alu.Tipo);
            if (tipo==3)
            {
                Session.Add("IdPero", obj);
                Response.Redirect("frmelegircomision.aspx");
            }
            else
            {
                Response.Redirect("frmerrorIncripto.aspx");
            }
           
        }
    }
}