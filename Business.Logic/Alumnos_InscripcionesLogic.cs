using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class Alumnos_InscripcionesLogic
    {
         private Data.Database.Alumnos_InscripcionesD _Alumno;

         public Data.Database.Alumnos_InscripcionesD Alumno
        {
            get { return _Alumno; }
            set { _Alumno = value; }
        }
        public Alumnos_InscripcionesLogic()
        {
            Alumno = new Data.Database.Alumnos_InscripcionesD();
        }
       public List<AlumnoInscripciones> GetAll()
       {
           return Alumno.GetAll();
       }

       public List<AlumnoInscripciones> TraerTodosLosInscriptos()
       {
           return Alumno.TraerTodosLosInscriptos();
       }

       public List<AlumnoInscripciones> GetAllCursando()
       {
           return Alumno.GetAllCursando();
       }
        
       public List<AlumnoInscripciones> GetAllInscriptonCursado()
       {
           return Alumno.GetAllInscriptonCursado();
       }
       public List<AlumnoInscripciones> GetByPasarRegularidad(int materia)
       {
           return Alumno.GetByPasarRegularidad(materia);
       }
       public List<AlumnoInscripciones> GetByPasarNotaFinal(int docente)
       {
           return Alumno.GetByPasarNotaFinal(docente);
       }
       //GetByPasarRegularidad
       public List<AlumnoInscripciones> GetByInscripto(int tipo)
       {
           return Alumno.GetByInscripto(tipo);
       }

       public AlumnoInscripciones TraerUnaInscripcion(int ID)
       {
           return Alumno.TraerUnaInscripcion(ID);
       }

       public List<AlumnoInscripciones> GetByAlumnoInscripto(string apellido)
       {
           return Alumno.GetByAlumnoInscripto(apellido);
       }

       public List<AlumnoInscripciones> MatInscriptasDeAlumno(int idalumno)
       {
           return Alumno.MatInscriptasDeAlumno(idalumno);
       }

       public List<AlumnoInscripciones> MatRegularesDeAlumno(int idalumno)
       {
           return Alumno.MatRegularesDeAlumno(idalumno);
       } 

       public static AlumnoInscripciones GetByInscribirporAdministrador(string nombre)
       {
           AlumnoInscripciones alupro = new AlumnoInscripciones();
           Data.Database.Alumnos_InscripcionesD aluda = new Data.Database.Alumnos_InscripcionesD();
           alupro = aluda.GetByInscribirporAdministrador(nombre);
           return alupro;
       }
       public List<AlumnoInscripciones> GetByGetByDevolverEstadoMateria(int tipo)
       {
           return Alumno.GetByDevolverEstadoMateria(tipo);
       }
       public List<AlumnoInscripciones> GetByMateriasAprobada()
       {
           return Alumno.GetByMateriasAprobada();
       }

       public List<Cursos> GetoneCupo(string desc_Com)
       {
           return Alumno.GetoneCupo(desc_Com);
       }
       public void Insertar(Business.Entities.AlumnoInscripciones alum)
       {
           Alumno.Save(alum);
       }
       public void Editar(AlumnoInscripciones alum)
       {
           Alumno.Save(alum);
       }
       public void Delete(Business.Entities.AlumnoInscripciones alum)
       {
           Alumno.Save(alum);
       }

       public void Save(AlumnoInscripciones alum)
       {
           Alumno.Save(alum);
       }
    }
}
