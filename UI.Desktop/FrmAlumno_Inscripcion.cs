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
    public partial class FrmAlumno_Inscripcion : Form
    {
       
        #region VARIABLES
        private bool Isnuevo = false;
        private bool IsEditar = false;
        Alumnos_InscripcionesLogic _aiL = new Alumnos_InscripcionesLogic();

        #endregion

        #region PROPIEDADES
        public Alumnos_InscripcionesLogic AiL
        {
            get { return _aiL; }
            set { _aiL = value; }
        }


        #endregion

        #region CONSTRUCTOR
        public FrmAlumno_Inscripcion()
        {
            InitializeComponent();
        }
        #endregion

        #region METODOS

        private void Ocultarcolumna()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[4].Visible = false;
            this.dataListado.Columns[5].Visible = false;
            this.dataListado.Columns[6].Visible = false;
            this.dataListado.Columns[7].Visible = false;
            this.dataListado.Columns[9].Visible = false;
            this.dataListado.Columns[14].Visible = false;
            this.dataListado.Columns[13].Visible = false;

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Academico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Listar()
        {
            Alumnos_InscripcionesLogic aiL = new Alumnos_InscripcionesLogic();
            this.dataListado.DataSource = aiL.TraerTodosLosInscriptos();
            lblTotal.Text = "Total de registro;" + Convert.ToString(dataListado.Rows.Count);
            this.btnListar.Visible = false;
        }

        public void Buscar()
        {
            if (txtBuscar.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, seran remarcados");
                errorIcono.SetError(txtBuscar, "Ingresa el curso a Buscar");
            }
            else
            {
                this.dataListado.DataSource = AiL.GetByInscripto(Convert.ToInt32(this.txtBuscar.Text));
                lblTotal.Text = "Total de registros;" + Convert.ToString(dataListado.Rows.Count);
                this.btnListar.Visible = true;
            }

        }

        private void Habilitar(bool valor)
        {
            this.cbCondicion.Enabled = valor;
            this.txtNota.Enabled = valor;
        }

        private void Limpiar()
        {
            this.txtAlumno.Text = string.Empty;
            this.txtCurso.Text = string.Empty;
            this.txtIdAlumno.Text = string.Empty;
            this.txtIdInscripcion.Text = string.Empty;
            this.txtNota.Text = string.Empty;
            this.cbCondicion.Text = string.Empty;
            this.txtIdCurso.Text = string.Empty;

        }
        private void Botones()
        {
            if (this.Isnuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnBuscaAlum.Enabled = true;
                this.btnBuscaCurso.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnBuscaAlum.Enabled = false;
                this.btnBuscaCurso.Enabled = false;
            }
        }

        public void Cursos(string CodCurso, string DescCom,string IdMat, string DescMat)
        {
            this.txtIdCurso.Text = CodCurso;
            this.txtCurso.Text = DescCom;
        }

        public void Alumno(string Codigo, string Apellido)
        {
            this.txtIdAlumno.Text = Codigo;
            this.txtAlumno.Text = Apellido;
        }

        #endregion

        #region EVENTOS


        private void FrmAlumno_Inscripcion_Load(object sender, EventArgs e)
        {
            Listar();
            Ocultarcolumna();
            this.Habilitar(false);
            this.Botones();
            this.btnEliminar.Enabled = false;
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Isnuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdInscripcion.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);

            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a modificar");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);

        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {

            this.txtIdCurso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["IdCurso"].Value);
            this.txtIdInscripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["IdInscripcion"].Value);
            this.txtCurso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Desc_comision"].Value);
            this.txtIdAlumno.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["IdAlumnos"].Value);
            this.txtAlumno.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Apellido"].Value);
            this.txtNota.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Nota"].Value);
            this.cbCondicion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Condicion"].Value);
            this.btnNuevo.Enabled = false;
            this.tabControl1.SelectedIndex = 1;

        }

        private void btnBuscaAlumno_Click(object sender, EventArgs e)
        {
            FrmListaAlumnos Lista = new FrmListaAlumnos();
            Lista.ShowDialog();
            Alumno(Lista.par1, Lista.par2);

        }

        private void btnBuscaCurso_Click(object sender, EventArgs e)
        {
            FrmListaCursos lista = new FrmListaCursos();
            lista.ShowDialog();
            Cursos(lista.par1, lista.par2, lista.par3, lista.par4);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtNota.Text == string.Empty || this.txtIdAlumno.Text == string.Empty || this.txtIdCurso.Text == string.Empty || this.cbCondicion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(txtNota, "Ingrese un valor");
                    errorIcono.SetError(txtIdAlumno, "Ingrese un valor");
                    errorIcono.SetError(txtIdCurso, "Ingrese un valor");
                    errorIcono.SetError(cbCondicion, "Ingrese un valor");
                }
                else
                {
                    if (this.txtIdInscripcion.Text == string.Empty)
                    {
                        AlumnoInscripciones alu = new AlumnoInscripciones();

                        alu.Condicion =  Convert.ToString(this.cbCondicion.SelectedText);
                        alu.Desc_Comision = this.txtCurso.Text;
                        alu.Apellido = this.txtAlumno.Text;
                        alu.IdCurso = Convert.ToInt32(this.txtIdCurso.Text);
                        alu.IdAlumnos = Convert.ToInt32(this.txtIdAlumno.Text);
                        alu.Nota = Convert.ToInt32(this.txtNota.Text);
                        alu.Estado = BusinessEntity.Estados.Nuevo;
                        AiL.Insertar(alu);

                    }
                    else
                    {
                        AlumnoInscripciones alu = new AlumnoInscripciones();

                        alu.IdInscripcion = Convert.ToInt32(this.txtIdInscripcion.Text);
                        alu.Condicion = Convert.ToString(this.cbCondicion.SelectedItem);
                        alu.Desc_Comision = this.txtCurso.Text;
                        alu.Apellido = this.txtAlumno.Text;
                        alu.IdCurso = Convert.ToInt32(this.txtIdCurso.Text);
                        alu.IdAlumnos = Convert.ToInt32(this.txtIdAlumno.Text);
                        alu.Nota = Convert.ToInt32(this.txtNota.Text);

                        alu.Estado = BusinessEntity.Estados.Modificar;
                        AiL.Editar(alu);

                        //alumno.IdInscripcion = (int)dr["id_inscripcion"];
                        //alumno.Apellido = (string)dr["apellido"];
                        //alumno.Nombre = (string)dr["nombre"];
                        //alumno.Desc_Materia = (string)dr["desc_materia"];
                        //alumno.Plan = (string)dr["desc_plan"];
                        //alumno.Desc_Comision = (string)dr["desc_comision"];
                        //alumno.Anio_especialidad = (int)dr["anio_calendario"];
                        //alumno.IdCurso = (int)dr["id_curso"];
                        //alumno.IdAlumnos = (int)dr["id_persona"];

                    }
                }
            }
            catch (Exception exp)
            {
                this.MensajeError(exp.Message);
                throw;
            }

            this.Isnuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtIdInscripcion.Text == String.Empty)
                {
                    this.MensajeError("Debe seleccionar el registro a eliminar");

                }
                else
                {
                    AlumnoInscripciones ai = new AlumnoInscripciones();
                    ai.IdInscripcion = Convert.ToInt32(this.txtIdInscripcion.Text);
                    ai.Estado = BusinessEntity.Estados.Eliminar;
                    AiL.Delete(ai);
                    this.Listar();
                }

            }

            catch (Exception exp)
            {
                MensajeError(exp.Message);
                throw;
            }
        }


        private void dataListado_Click(object sender, EventArgs e)
        {
            this.txtIdInscripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["IdInscripcion"].Value);
            this.btnEliminar.Enabled = true;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        

        

        
    }
}
