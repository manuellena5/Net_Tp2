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
    public partial class frmregularidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.LoadGrid();
            }
        }
        Alumnos_InscripcionesLogic _logic = new Alumnos_InscripcionesLogic();

        public Alumnos_InscripcionesLogic Logic
        {
            get { return _logic; }
            set { _logic = value; }
        }
        private void LoadGrid()
        {
            //string materia = (string)(Session["materia"]);
            int id = (int)(Session["CodMat"]);
            //int anio = (int)(Session["año"]);
            //int tipo = (int)(Session["Tipo"]);
            //MateriaLogic al = new MateriaLogic();

            //Alumnos_InscripcionesLogic cur = new Alumnos_InscripcionesLogic();
            //if (tipo == 1)
            //{
            //    Response.Redirect("frminscribirporAdministrador.aspx");

            //}
            //else if (tipo == 3)
            //{
            this.gridview.DataSource = Logic.GetByPasarRegularidad(id);
            this.gridview.DataBind();
            //}


        }

        protected void gridview_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtidIscripto.Text = (Convert.ToString(this.gridview.SelectedRow.Cells[0].Text));
            this.txtidAlumno.Text =(Convert.ToString(this.gridview.SelectedRow.Cells[6].Text));
            this.txtidCurso.Text = (Convert.ToString(this.gridview.SelectedRow.Cells[5].Text));
            this.Buton(true);
            this.btnNuevo.Visible = false;
            this.btnaceptar.Visible = false;
        }
        private void Buton(bool valor)
        {
            this.btnEditar.Visible = Visible;
            this.btncancelar.Visible = valor;
            this.btnNuevo.Visible = valor;
            this.btnaceptar.Visible = valor;
            this.btnEliminar.Visible = valor;
        } 
        protected void cargarRegularidad()
        {
            try
            {
                AlumnoInscripciones alu_Ins = new AlumnoInscripciones();
               
                    if (cblregular.SelectedItem.Text == "Seleccionar Condicion")
                    {
                        msgError.Text = "Debe seleccionar una Condicion";
                    }
                    else
                    {
                        alu_Ins.IdInscripcion = Convert.ToInt32(this.txtidIscripto.Text);
                        alu_Ins.IdAlumnos = (Convert.ToInt32(this.txtidAlumno.Text));
                        alu_Ins.IdCurso = (Convert.ToInt32(this.txtidCurso.Text));
                        alu_Ins.Condicion = (Convert.ToString(this.cblregular.SelectedValue));
                        alu_Ins.Estado = BusinessEntity.Estados.Nuevo;
                        Logic.Editar(alu_Ins);
                        this.Limpiar();
                        //gridview.EditIndex = -1;
                        //this.LoadGrid();
                    }              
            }
            catch (Exception ex)
            {
                msgError.Text = ex.Message;
            }
        }
        private void Limpiar()
        {
            this.txtidIscripto.Text = string.Empty;
            this.txtidAlumno.Text = string.Empty;
            this.txtidCurso.Text = string.Empty;
            this.cblregular.Text = "Seleccionar Condicion";

        }
        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            this.cargarRegularidad();
        }
        protected void Editar()
        {
                this.Habilitar(true);
        }
        private void Habilitar(bool valor)
        {
            this.txtidIscripto.Enabled = valor;
            this.txtidAlumno.Enabled = valor;
            this.txtidCurso.Enabled = valor;
            //cbldPlan.SelectedItem.Text = "Seleccione un Plan";
            cblregular.Enabled = valor;
            this.btnEditar.Visible = false;
            this.btnaceptar.Visible = valor;
            this.btnNuevo.Enabled = !valor;
            this.btncancelar.Visible = valor;
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            this.Editar();
        }

    }
}