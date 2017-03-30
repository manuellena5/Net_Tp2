using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Database;

namespace UI.Desktop
{
    public partial class Principal : Form
    {
        //private int childFormNumber = 0;

        public string IdUsuario = "";
        public string Nombre = "";
        public string Apellido = "";
        public string Acceso="";
        public string IdPersona = "";
       
        public Principal()
        {
            InitializeComponent();
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            //childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Database.Adapter ad = new Data.Database.Adapter();
            ad.CloseConnection();
            Application.Exit();
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        
        private void GestionUsuario()
        {
            if (Acceso=="1")
            {
                this.PersonaMenu.Enabled = true;
                this.InscripcionMenu.Enabled = true;
                this.ConsultaMenu.Enabled = true;
                this.HerramientaMenu.Enabled = true;
                this.carreraMenu.Enabled = true;
               
            }
            else if (Acceso=="2")
            {
                this.PersonaMenu.Enabled = true;
                this.InscripcionMenu.Enabled = true;
                this.ConsultaMenu.Enabled = true;
                this.HerramientaMenu.Enabled = false;
                this.altaPersonaMenu.Enabled = false;
                //this.examenMenu.Enabled = false;
                this.cursarMenu.Enabled = false;
                //this.notasMenu.Enabled = false;
                //this.verMateriasAprobadasMenu.Enabled = false;
                this.carreraMenu.Enabled = false;
                //this.historiaAcademicoMenu.Enabled = false;
                //this.UsuarioStripButton.Enabled = false;

            }
            else
            {
                this.PersonaMenu.Enabled = false;
                this.InscripcionMenu.Enabled = true;
                this.ConsultaMenu.Enabled = true;
                this.HerramientaMenu.Enabled = false;
                //this.examenMenu.Enabled = true;
                this.cursarMenu.Enabled = true;
                //this.condicionDeAlumnosInscriptoMenu.Enabled = false;
                //this.notasMenu.Enabled = true;
                //this.historiaAcademicoMenu.Enabled = true;
                //this.verMateriasAprobadasMenu.Enabled = true;
                this.cursarMenu.Enabled = true;
                //this.inscriptoMenu.Enabled = false;
                this.carreraMenu.Enabled = false;
                //this.UsuarioStripButton.Enabled = false;
            }
        }
        private void estado()
        {

            if (Acceso =="1")
            {
                this.Conectado.Text = "Esta Conectado como Administrador con el Nombre : " + Nombre.ToUpper() + " " + Apellido.ToUpper();
                
            }
            else if (Acceso=="2")
            {
                this.Conectado.Text = "Esta Conectado como Docente con el Nombre : " + Nombre.ToUpper() + " " + Apellido.ToUpper();
                
            }
            else
            {
                this.Conectado.Text = "Esta Conectado como Alumno con el Nombre : " + Nombre.ToUpper() + " " + Apellido.ToUpper();
               
            }
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            GestionUsuario();
            estado();
        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios childForm = new Usuarios();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void especialidadesMenu_Click(object sender, EventArgs e)
        {
            Especialidad childForm = new Especialidad();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void planesMenu_Click(object sender, EventArgs e)
        {
            Planes childForm = new Planes();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Realmente Desea Salir del sistema", "Sistema academia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcion == DialogResult.Yes)
            {
                Data.Database.Adapter ad = new Data.Database.Adapter();
                ad.CloseConnection();
                Application.Exit();
            }
            else if (Opcion == DialogResult.No)
            {
                e.Cancel = true;
            }
                
        }

       

        private void altaPersonaMenu_Click(object sender, EventArgs e)
        {
            Personas childForm = new Personas();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void materiasMenu_Click(object sender, EventArgs e)
        {
            Materias childForm = new Materias();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void mnuComisiones_Click(object sender, EventArgs e)
        {
            Comisiones childForm = new Comisiones();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void mnuCursos_Click(object sender, EventArgs e)
        {
            Cursos childForm = new Cursos();
            childForm.MdiParent = this;
            childForm.Show();
        }

       

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaCursos childForm = new FrmListaCursos();
            childForm.MdiParent = this;
            childForm.Show();
        }

        

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaComision childForm = new FrmListaComision();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaAlumnos childForm = new FrmListaAlumnos();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaPersona childForm = new FrmListaPersona();
            childForm.MdiParent = this;
            childForm.Show();
        }

        

        private void condicionDeAlumnosInscriptoMenu_Click(object sender, EventArgs e)
        {
            FrmAlumno_Inscripcion childForm = new FrmAlumno_Inscripcion();
            childForm.MdiParent = this;
            childForm.Show();
        }

        

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaMaterias childForm = new FrmListaMaterias();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLista_Plan childForm = new FrmLista_Plan();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void cursarMenu_Click(object sender, EventArgs e)
        {
            InscripcionesAdmin childForm = new InscripcionesAdmin();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void materiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInscripcionAMateriaAlumno form = new FrmInscripcionAMateriaAlumno(this.IdPersona,this.IdUsuario,this.Nombre,this.Apellido);
            form.ShowDialog();
        }


        #region NO IMPLEMENTADOS

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void PersonaMenu_Click(object sender, EventArgs e)
        {

        }

        private void carreraMenu_Click(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void inscriptoMenu_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void aCursadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncripcionAcursado form = new frmIncripcionAcursado(this.IdPersona, this.IdUsuario, this.Nombre, this.Apellido);
            form.ShowDialog();
        }

        private void miEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeMateriasInscripto form = new ListaDeMateriasInscripto(this.IdPersona, this.IdUsuario, this.Nombre, this.Apellido);
            form.ShowDialog();
        }

        private void aExamenDesdeListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InscripcionAexamenDesdeLista form = new InscripcionAexamenDesdeLista(this.IdPersona, this.IdUsuario, this.Nombre, this.Apellido);
            //form.ShowDialog();
        }
    }
    }

