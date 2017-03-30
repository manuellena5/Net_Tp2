using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocentesCursos:BusinessEntity
    {
         private int _IdDictado;
        private int _IdCurso;
        private int _IdDocente;
        private string _cargo;
        private string _Nombre;
        private string _Apellido;
        private string _Desc_Comision;
        private string _Desc_Materia;

        public string Desc_Materia
        {
            get { return _Desc_Materia; }
            set { _Desc_Materia = value; }
        }

        public string Desc_Comision
        {
            get { return _Desc_Comision; }
            set { _Desc_Comision = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
                
        public int IdDictado
        {
            get { return _IdDictado; }
            set { _IdDictado = value; }
        }
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }
       public int IdDocente
        {
            get { return _IdDocente; }
            set { _IdDocente = value; }
        }
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
       public DocentesCursos()
        {

        }
       public DocentesCursos(int id_dictado,int id_curso,int id_docente,string cargo,string nombre,string apellido,string desc_comision,string desc_materia)
       {
           this.IdDictado = id_dictado;
           this.IdCurso = IdCurso;
           this.IdDocente = id_docente;
           this.Cargo = cargo;
           this.Nombre = nombre;
           this.Apellido = apellido;
           this.Desc_Comision = desc_comision;
           this.Desc_Materia = desc_materia;
       }
    }
}
