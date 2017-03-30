using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Principal());
            //Application.Run(new FrmCursos());
            //Application.Run(new FrmListaComision());
           //Application.Run(new FrmListaMaterias());
            //Application.Run(new FrmListaPersona());
            //Application.Run(new FrmLista_Plan());
            //Application.Run(new FrmListaCursos());
            Application.Run(new FrmLogin());
            //Application.Run(new FrmListaAlumnos());
            //Application.Run(new FrmAlumno_Inscripcion());
            //Application.Run(new UsuarioDesktop());
            //Application.Run(new Personas());
            //Application.Run(new FrmMaterias());
            //Application.Run(new FrmComisiones());
            //Application.Run(new FrmListadoAlumInscriptos());
            //Application.Run(new frmUsuDktp());
           //Application.Run(new Usuarios());
            //Application.Run(new FrmInscripcionAMateriaAlumno());
            //Application.Run(new Especialidad());
            //Application.Run(new Planes());

        }
    }
}
