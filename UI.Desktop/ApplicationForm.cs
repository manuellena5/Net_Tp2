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
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }


        private ModoForm _Modo;

        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }

        public virtual void MapearDeDatos() { }  // para copiar la información de las entidades a los controles del formulario para mostrar la infromación de cada entidad
        public virtual void MapearADatos() { } // para pasar la información de los controles a una entidad para luego enviarla a las capas inferiores 
        public virtual void GuardarCambios() { } //se encargará de invocar al método correspondiente de la capa de negocio según sea el ModoForm en que se encuentre el formulario 

        public virtual bool Validar() { return false; } // método que devuelva si los datos son válidos para poder registrar los cambios realizados.


        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        // para unificar el mecanismo de avisos al usuario
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }
    }
}

