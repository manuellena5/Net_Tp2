using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web.Formulario
{
    public partial class frmpasarregularidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                this.LoadGrid();
            }
        }
        MateriaLogic _logic = new MateriaLogic();

        public MateriaLogic Logic
        {
            get { return _logic; }
            set { _logic = value; }
        }
        private void LoadGrid()
        {
            int id = (int)(Session["CodPersona"]);
            MateriaLogic al = new MateriaLogic();

            Alumnos_InscripcionesLogic cur = new Alumnos_InscripcionesLogic();
            if (Convert.ToInt32(Session["Tipo"]) == 1)
            {
                Response.Redirect("FrmpasarRegadmin.aspx");

            }
            else if (Convert.ToInt32(Session["Tipo"]) == 2)
            {
                this.gridview.DataSource = Logic.GetAllMateriaAsignada(id);
                this.gridview.DataBind();
            }


        }

        protected void gridview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codmat = Convert.ToInt32((Convert.ToString(this.gridview.SelectedRow.Cells[0].Text)).ToString());
            Session.Add("CodMat",codmat);
            Response.Redirect("frmregularidad.aspx");
        }    
    }
}