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

namespace UI.Desktop
{
    public partial class frmABMcursos : ApplicationForm
    {
       

         
        #region VARIABLES

        private Business.Entities.Cursos _CursoActual;
        
        #endregion
       
        #region PROPIEDADES

        public Business.Entities.Cursos CursoActual
        {
            get { return _CursoActual; }
            set { _CursoActual = value; }
        }
        
        #endregion
        
        #region CONSTRUCTOR

         public frmABMcursos()
        {
            InitializeComponent();
        }

       
        public frmABMcursos(ModoForm modo):this()
        {
            Modo = modo;
        }

        public frmABMcursos(int ID, ModoForm modo)
            : this() 
        {
            CursoLogic cl = new CursoLogic();
            Modo = modo;
            CursoActual = cl.TraerUno(ID);
            MapearDeDatos();

        }
        #endregion
        
        
        #region METODOS



        public override void MapearDeDatos()
        {
            //Validaciones val = new Validaciones();
            this.txtIdCurso.Text = Convert.ToString(CursoActual.IdCurso);
            this.txtAnioCalendario.Text = Convert.ToString(CursoActual.AnioCalendario);
            this.txtCupo.Text = Convert.ToString(CursoActual.Cupo);
            this.txtIdMateria.Text = Convert.ToString(CursoActual.IdMateria);
            this.txtDescMateria.Text = CursoActual.Desc_materia;
            this.txtIdComision.Text = Convert.ToString(CursoActual.IdComision);
            this.txtDescComision.Text = CursoActual.Desc_comision;
            

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
                    Business.Entities.Cursos cur = new Business.Entities.Cursos();
                    CursoActual = cur;

                    //PlanActual.Codigo = Convert.ToInt32(this.txtIdPlan.Text);
                    CursoActual.AnioCalendario = Convert.ToInt32(this.txtAnioCalendario.Text);
                    CursoActual.Cupo = Convert.ToInt32(this.txtCupo.Text);
                    CursoActual.IdMateria = Convert.ToInt32(this.txtIdMateria.Text);
                    CursoActual.Desc_materia = this.txtDescMateria.Text;
                    CursoActual.IdComision = Convert.ToInt32(this.txtIdComision.Text);
                    CursoActual.Desc_comision = this.txtDescComision.Text;
                    CursoActual.Estado = BusinessEntity.Estados.Nuevo;

                    break;

                case ModoForm.Baja:
                    CursoActual.Estado = BusinessEntity.Estados.Eliminar;
                    break;

                case ModoForm.Modificacion:
                    CursoActual.AnioCalendario = Convert.ToInt32(this.txtAnioCalendario.Text);
                    CursoActual.Cupo = Convert.ToInt32(this.txtCupo.Text);
                    CursoActual.IdMateria = Convert.ToInt32(this.txtIdMateria.Text);
                    CursoActual.Desc_materia = this.txtDescMateria.Text;
                    CursoActual.IdComision = Convert.ToInt32(this.txtIdComision.Text);
                    CursoActual.Desc_comision = this.txtDescComision.Text;
                    CursoActual.Estado = BusinessEntity.Estados.Modificar;
                    break;

                case ModoForm.Consulta:
                    CursoActual.Estado = BusinessEntity.Estados.No_Modificar;

                    break;

                default:
                    break;
            }


        }
        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic cl = new CursoLogic();
            cl.Save(CursoActual);

        }

        public override bool Validar()
        {
            if (this.txtAnioCalendario.Text != string.Empty && this.txtCupo.Text != string.Empty && this.txtIdComision.Text != string.Empty && this.txtIdMateria.Text != string.Empty)
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

        public void Materias(string Codigo, string nombre)
        {
            this.txtIdMateria.Text = Codigo;
            this.txtDescMateria.Text = nombre;

        }

        public void Comisiones(string Codigo, string nombre)
        {
            this.txtIdComision.Text = Codigo;
            this.txtDescComision.Text = nombre;

        }

        public void DesacCampos (bool valor)
        {
            this.txtIdCurso.ReadOnly = valor;
            this.txtAnioCalendario.ReadOnly = valor;
            this.txtCupo.ReadOnly = valor;
            this.txtIdMateria.ReadOnly = valor;
            this.txtDescMateria.ReadOnly = valor;
            this.txtIdComision.ReadOnly = valor;
            this.txtDescComision.ReadOnly = valor;
            this.linkLabel1.Visible = !valor;
            this.linkLabel2.Visible = !valor;

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

        private void linkLabelMat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmListaMaterias frm = new FrmListaMaterias();
            frm.ShowDialog();
            this.Materias(frm.par1, frm.par2);
        }

        private void linkLabelCom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmListaComision frm = new FrmListaComision();
            frm.ShowDialog();
            this.Comisiones(frm.par1, frm.par2);
        }
        #endregion
    }
}
