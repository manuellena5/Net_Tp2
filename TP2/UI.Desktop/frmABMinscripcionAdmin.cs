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
    public partial class frmABMinscripcionAdmin :  ApplicationForm
    {
        

        
        #region VARIABLES

        private AlumnoInscripciones _InscripcionActual;
        
        #endregion
       
        #region PROPIEDADES

        public AlumnoInscripciones InscripcionActual
        {
            get { return _InscripcionActual; }
            set { _InscripcionActual = value; }
        }
        
        #endregion
        
        #region CONSTRUCTOR


        public frmABMinscripcionAdmin()
        {
            InitializeComponent();
        }


        public frmABMinscripcionAdmin(ModoForm modo)
            : this()
        {
            Modo = modo;
        }

        public frmABMinscripcionAdmin(int ID, ModoForm modo)
            : this()
        {
            Alumnos_InscripcionesLogic al = new Alumnos_InscripcionesLogic();
            Modo = modo;
            InscripcionActual = al.TraerUnaInscripcion(ID);
            MapearDeDatos();

        }
        #endregion
        
        
        #region METODOS



        public override void MapearDeDatos()
        {
            //Validaciones val = new Validaciones();
            this.txtIdInscripcion.Text = Convert.ToString(InscripcionActual.IdInscripcion);
            this.txtDesMateria.Text = InscripcionActual.Desc_Materia;
            this.txtNombre.Text = InscripcionActual.Nombre;
            this.txtApellido.Text = InscripcionActual.Apellido;
            this.txtIdAlumno.Text = Convert.ToString(InscripcionActual.IdAlumnos);
            this.txtIdCurso.Text = Convert.ToString(InscripcionActual.IdCurso);
            this.txtNota.Text = Convert.ToString(InscripcionActual.Nota);
            this.txtDescComision.Text = InscripcionActual.Desc_Comision;
            this.txtLegajo.Text = Convert.ToString(InscripcionActual.Legajo);
            this.cbCondicion.Text = InscripcionActual.Desc_Comision;

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
                    AlumnoInscripciones ali = new AlumnoInscripciones();
                    InscripcionActual = ali;

                    //this.txtIdInscripcion.Text = Convert.ToString(InscripcionActual.IdInscripcion);
                     InscripcionActual.Desc_Materia = this.txtDesMateria.Text;
                   InscripcionActual.IdAlumnos =  Convert.ToInt32(this.txtIdAlumno.Text);
                   InscripcionActual.IdCurso = Convert.ToInt32(this.txtIdCurso.Text);
                     InscripcionActual.Nota = Convert.ToInt32(this.txtNota.Text);
                      InscripcionActual.Desc_Comision = this.txtDescComision.Text;
                      InscripcionActual.Legajo= Convert.ToInt32(this.txtLegajo.Text);
                    InscripcionActual.Apellido=  this.txtApellido.Text;
                     InscripcionActual.Nombre=this.txtNombre.Text ;
                     InscripcionActual.Condicion = Convert.ToString(this.cbCondicion.SelectedItem);
                    InscripcionActual.Estado = BusinessEntity.Estados.Nuevo;

                    break;

                case ModoForm.Baja:
                    InscripcionActual.Estado = BusinessEntity.Estados.Eliminar;
                    break;

                case ModoForm.Modificacion:
                    InscripcionActual.Desc_Materia = this.txtDesMateria.Text;
                   InscripcionActual.IdAlumnos =  Convert.ToInt32(this.txtIdAlumno.Text);
                   InscripcionActual.IdCurso = Convert.ToInt32(this.txtIdCurso.Text);
                     InscripcionActual.Nota = Convert.ToInt32(this.txtNota.Text);
                      InscripcionActual.Desc_Comision = this.txtDescComision.Text;
                      InscripcionActual.Legajo= Convert.ToInt32(this.txtLegajo.Text);
                    InscripcionActual.Apellido=  this.txtApellido.Text;
                     InscripcionActual.Nombre=this.txtNombre.Text ;
                     InscripcionActual.Condicion = Convert.ToString(this.cbCondicion.SelectedItem);
                    InscripcionActual.Estado = BusinessEntity.Estados.Modificar;
                    break;

                case ModoForm.Consulta:
                    InscripcionActual.Estado = BusinessEntity.Estados.No_Modificar;

                    break;

                default:
                    break;
            }


        }

        public override void GuardarCambios()
        {
            MapearADatos();
            Alumnos_InscripcionesLogic alil = new Alumnos_InscripcionesLogic();
            alil.Save(InscripcionActual);

        }

        public override bool Validar()
        {
            if (this.txtDescComision.Text != string.Empty && this.txtDesMateria.Text != string.Empty && this.txtNota.Text != string.Empty && this.cbCondicion.Text != string.Empty)
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

        public void Alumnos(string Codigo, string nombre,string apellido,string legajo)
        {
            this.txtIdAlumno.Text = Codigo;
            this.txtNombre.Text = nombre;
            this.txtApellido.Text = apellido;
            this.txtLegajo.Text = legajo;
        }

        public void Cursos(string Codigo, string descMateria, string descComision)
        {
            this.txtIdCurso.Text = Codigo;
            this.txtDesMateria.Text = descMateria;
            this.txtDescComision.Text = descComision;

        }

       public void MateriaInscripto(string idcurso,string descmateria,string desccomision)
       {
           this.txtIdCurso.Text = idcurso;
            this.txtDesMateria.Text = descmateria;
            this.txtDescComision.Text = desccomision;
       }


        public void DesacCampos (bool valor)
        {
            this.txtDesMateria.ReadOnly = valor;
            this.txtNota.ReadOnly = valor;
            this.txtDescComision.ReadOnly = valor;
            this.txtLegajo.ReadOnly = valor;
            this.cbCondicion.Enabled = !valor;
            
        }

        public void ModoEditar (bool valor)
        {
            this.btnBuscarAlumno.Visible = !valor;
            this.txtApellido.ReadOnly = valor;
            this.txtNombre.ReadOnly = valor;
            this.txtLegajo.ReadOnly = valor;
            this.btnBuscarCurso.Text = "Buscar Materias";
        }

        public void Limpiar ()
        {
            this.txtDesMateria.Text = string.Empty;
            this.txtIdAlumno.Text = string.Empty;
            this.txtIdCurso.Text = string.Empty;
            this.txtNota.Text = string.Empty;
            this.txtDescComision.Text = string.Empty;
            this.txtLegajo.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.cbCondicion.Text = string.Empty;
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            FrmListaAlumnos frm = new FrmListaAlumnos();
            frm.ShowDialog();
            this.Alumnos(frm.par1, frm.par2,frm.par3,frm.par4);
        }


        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            if (btnBuscarCurso.Text == "Buscar Curso")
            {
                FrmListaCursos frm = new FrmListaCursos();
                frm.ShowDialog();
                this.Cursos(frm.par1, frm.par4, frm.par2);  
                            /* par1= idcurso , par2 = desccomision, par3 = Idmateria, par4 = descmateria */
            }
            else
            {
                ListaDeMateriasInscripto frm = new ListaDeMateriasInscripto(this.txtIdAlumno.Text);
                frm.ShowDialog();
                this.MateriaInscripto(frm.idcurso, frm.descmateria, frm.desccomision);

            }
            
                          
        }

        


        #endregion

        
    }
}
