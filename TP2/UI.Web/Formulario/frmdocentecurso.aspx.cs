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
    public partial class frmdocentecurso : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(Session["CodPersona"]);
            if (code != 0)
            {
                if (!IsPostBack)
                {
                    this.LoadGrid();
                    this.llenarcomboDocente();
                    this.llenarcomboCurso();
                    
                }
            }
        }

        docentescursoLogic _logic = new docentescursoLogic();

        public docentescursoLogic Logic
        {
            get { return _logic; }
            set { _logic = value; }
        }
        private void LoadGrid()
        {
            int id = (int)(Session["CodPersona"]);
            int tipo = (int)(Session["Tipo"]);
            if (tipo == 1)
            {
                this.gridview.DataSource = Logic.GetAll();
                this.gridview.DataBind();
            }
            else if (tipo==2)
            {
                this.gridview.DataSource = Logic.GetAll(id);
                this.gridview.DataBind();
            }
            
        }
        protected void CargarDocenteCurso()
        {
            List<DocentesCursos> listadoPersona = new List<DocentesCursos>();
            docentescursoLogic docCurs = new docentescursoLogic();
            bool bandera = true;
            listadoPersona = docCurs.GetAll();
            int val=Convert.ToInt16(this.cblCurso.SelectedValue.ToString());
            for (int i = 0; i < listadoPersona.Count; i++)
            {
                if (listadoPersona[i].IdCurso == val)
                {
                    bandera = false;
                }
            }
            if (bandera)
            {             
                DocentesCursos  dcurs = new DocentesCursos();

                dcurs.IdCurso = Convert.ToInt16(this.cblCurso.SelectedValue);
                dcurs.IdDocente = Convert.ToInt16(this.cblDocente.SelectedValue);
                dcurs.Cargo = Convert.ToString(this.cblCargo.SelectedValue);

                dcurs.Estado = BusinessEntity.Estados.Nuevo;
                Logic.Insertar(dcurs);
            }
            else
            {
                Response.Redirect("frmErrorDocCurso.aspx");
            }
        }
        protected void ModificarDocenteCursos()
        {
            DocentesCursos dcurs = new DocentesCursos();

            dcurs.IdDictado = Convert.ToInt16(this.cblDictado.SelectedValue);
            dcurs.IdCurso = Convert.ToInt16(this.cblCurso.SelectedValue);
            dcurs.IdDocente = Convert.ToInt16(this.cblDocente.SelectedValue);
            dcurs.Cargo = Convert.ToString(this.cblCargo.SelectedValue);

            dcurs.Estado = BusinessEntity.Estados.Modificar;
            Logic.Editar(dcurs);
        }
        private void llenarcomboDocente()
        {
            Data.Database.Personas especia = new Data.Database.Personas();
            cblDocente.DataSource = especia.GetAllProfesor();
            cblDocente.DataValueField = "Codigo";
            cblDocente.DataTextField = "Nombre";
            cblDocente.DataBind();
            //cblDocente.Items.Insert(0, new ListItem("Seleccione un Docente", "0"));
        }
        private void llenarcomboCurso()
        {
            Data.Database.CursoD especia = new Data.Database.CursoD();
            cblCurso.DataSource = especia.GetAll();
            cblCurso.DataValueField = "IdCurso";
            cblCurso.DataTextField = "Desc_materia";
            cblCurso.DataBind();
            //cblDocente.Items.Insert(0, new ListItem("Seleccione un Docente", "0"));
        }
        private void llenarcomboCargo()
        {
            //Data.Database.Personas especia = new Data.Database.Personas();
            //cblDocente.DataSource = especia.GetAllProfesor();
            cblCargo.DataValueField = "Codigo";
            cblCargo.DataTextField = "Nombre";
            cblCargo.DataBind();
            //cblDocente.Items.Insert(0, new ListItem("Seleccione un Docente", "0"));
        }       
        protected void gridview_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cblDictado.SelectedItem.Text = (Convert.ToString(this.gridview.SelectedRow.Cells[0].Text)).ToString();
            this.cblDocente.SelectedItem.Text = (Convert.ToString(this.gridview.SelectedRow.Cells[4].Text)).ToString();
            this.cblCurso.SelectedItem.Text = (Convert.ToString(this.gridview.SelectedRow.Cells[6].Text)).ToString();
            this.cblCargo.SelectedItem.Text = (Convert.ToString(this.gridview.SelectedRow.Cells[3].Text)).ToString();
           

            this.Buton(true);
            this.btnNuevo.Visible = false;
            this.btnaceptar.Visible = false;
            this.Habilitar(false);
            this.btncancelar.Visible = true;
            this.btnEditar.Visible = true;
        }
        private void Buton(bool valor)
        {
            this.btnEditar.Visible = Visible;
            this.btncancelar.Visible = valor;
            this.btnNuevo.Visible = valor;
            this.btnaceptar.Visible = valor;
            this.btnEliminar.Visible = valor;
        }
        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            if (this.cblDictado.SelectedItem.Value == "Cod Dictado")
            {
                this.CargarDocenteCurso();
                this.LoadGrid();
            }
            else
            {
                this.ModificarDocenteCursos();
                this.LoadGrid();
            }
           
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Habilitar(true);
            this.btnNuevo.Visible = false;
        }
        private void Habilitar(bool valor)
        {
            this.cblDocente.Enabled = valor;
            this.cblCurso.Enabled = valor;
            this.cblCargo.Enabled = valor;
            this.btnEditar.Visible = false;
            this.btnaceptar.Visible = valor;
            this.btnNuevo.Enabled = !valor;
            this.btncancelar.Visible = valor;
        }
        private void DesHabilitar(bool valor)
        {
            this.btnaceptar.Visible = valor;
            this.btnNuevo.Enabled = !valor;
            this.btncancelar.Visible = valor;
            this.btnEliminar.Visible = valor;
            this.btnEditar.Visible = valor;

        }
        protected void Eliminar()
        {
            try
            {
                DocentesCursos doc = new DocentesCursos();
                doc.IdDictado = Convert.ToInt32(this.cblDictado.SelectedItem.Text);
                doc.Estado = BusinessEntity.Estados.Eliminar;
                Logic.Delete(doc);
            }
            catch (Exception ex)
            {
                msgError.Text = ex.Message;
            }

        }
        protected void Editar()
        {
            this.Habilitar(true);
            this.btnEliminar.Visible = false;
        }
        protected void btncancelar_Click(object sender, EventArgs e)
        {
            this.DesHabilitar(false);
            this.Habilitar(false);
            this.btnNuevo.Visible = true;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
            this.LoadGrid();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            this.Editar();
            this.btnaceptar.Text = "Modificar";
        }
    }
}