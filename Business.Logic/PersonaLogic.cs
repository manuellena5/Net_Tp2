using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using System.Data;

namespace Business.Logic
{
    public class PersonaLogic
    {
        private Data.Database.Personas _PersonaData;

        public Data.Database.Personas PersonaData
        {
            get { return _PersonaData; }
            set { _PersonaData = value; }
        }

        public PersonaLogic()
        {
            PersonaData = new Data.Database.Personas();
        }

        public _Personas TraerUno(int ID)
        {
            return PersonaData.TraerUno(ID); 
        }

        public void Save(_Personas per)
        {
            PersonaData.Save(per);
        }


        public List<_Personas> GetAll()
        {
            return PersonaData.GetAll();
        }
        public List<_Personas> GetAllAdministrador()
        {
            return PersonaData.GetAllAdministrador();
        }

        public _Personas GetByAgregarRegularidadporAdministrador( string nombre)
        {
            return PersonaData.GetByAgregarRegularidadporAdministrador(nombre);
        }

        public List<_Personas> GetAllProfesor()
        {
            return PersonaData.GetAllProfesor();
        }
        public List<_Personas> GetAllAlumno()
        {
            return PersonaData.GetAllAlumno();
        }
        public List<_Personas> GetByPersona(string apellido)
        {
            return PersonaData.GetByPersona(apellido);
        }

        public List<_Personas> GetByAlumno(string apellido)
        {
            return PersonaData.GetByPersona(apellido);
        }

        public void Delete(_Personas id)
        {
            PersonaData.Save(id);
        }
        public void Insertar(_Personas persona)
        {
            PersonaData.Save(persona);
        }
        public void Update(_Personas persona)
        {
            PersonaData.Save(persona);
        }
    }
}

