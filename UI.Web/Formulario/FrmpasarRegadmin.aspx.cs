using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web.Formulario
{
    public partial class FrmpasarRegadmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            Object objeto = txtnombre.Text;
            PersonaLogic per = new PersonaLogic();
            //objeto.DataBind();
            int obj;
            _Personas alu = new _Personas();
            alu = per.GetByAgregarRegularidadporAdministrador(Convert.ToString(objeto));
            obj = alu.Codigo;
           
            if (obj!=0)
            {
                Session.Add("IdPeroXAd", obj);
                Response.Redirect("FrmpasarRegularidadPorAdninistrador.aspx");
            }
            else
            {
                Response.Redirect("frmErrorRegularidadAdm.aspx");
            }
        }
    }
}