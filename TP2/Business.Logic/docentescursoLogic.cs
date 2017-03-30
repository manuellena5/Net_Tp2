using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
   public class docentescursoLogic
    {
       private Data.Database.DocentesCursosD _DocCursos;

       public Data.Database.DocentesCursosD DocCursos
        {
            get { return _DocCursos; }
            set { _DocCursos = value; }
        }
        public docentescursoLogic()
        {
            DocCursos = new Data.Database.DocentesCursosD();
        }
        public List<DocentesCursos> GetAll()
        {
            return DocCursos.GetAll();
        }
        public List<DocentesCursos> GetAll(int idpersona)
        {
            return DocCursos.GetAll(idpersona);
        }
        public void Insertar(DocentesCursos doccurs)
        {
            DocCursos.Save(doccurs);
        }
        public void Editar(DocentesCursos doccurs)
        {
            DocCursos.Save(doccurs);
        }
        public void Delete(DocentesCursos doccurs)
        {
            DocCursos.Save(doccurs);
        }
    }
}
