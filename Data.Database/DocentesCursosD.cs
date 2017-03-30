using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class DocentesCursosD:Adapter
    {
        public enum rol
        {
            Titular = 1,
            Auxiliar,
            JTP
        }
        public List<DocentesCursos> GetAll()
        {
            List<DocentesCursos> lista = new List<DocentesCursos>();
            try
            {
                this.OpenConnection();
                int estado;
                SqlCommand cmdplan = new SqlCommand("select dc.id_dictado,cr.id_curso,per.id_persona,dc.cargo,per.nombre,per.apellido,mat.desc_materia,com.desc_comision from docentes_cursos dc inner join cursos cr on dc.id_curso=cr.id_curso inner join personas per on per.id_persona=dc.id_docente inner join materias mat on mat.id_materia=cr.id_materia inner join comisiones com on com.id_comision=cr.id_comision", SqlConn);
                SqlDataReader drmateria = cmdplan.ExecuteReader();
                while (drmateria.Read())
                {
                    DocentesCursos docCurs = new DocentesCursos();
                    //_Especialidades esp = new _Especialidades();
                    docCurs.IdDictado = (int)drmateria["id_dictado"];
                    docCurs.IdCurso = (int)drmateria["id_curso"];
                    docCurs.IdDocente = (int)drmateria["id_persona"];
                    estado = (int)drmateria["cargo"];
                    if (estado==1)
                    {
                        docCurs.Cargo = Convert.ToString(rol.Titular);
                    }
                    else if (estado==2)
                    {
                         docCurs.Cargo = Convert.ToString(rol.Auxiliar);
                    }
                    else
                    {
                        docCurs.Cargo = Convert.ToString(rol.JTP);
                    }
                    
                    docCurs.Nombre = (string)drmateria["nombre"];
                    docCurs.Apellido = (string)drmateria["apellido"];
                    docCurs.Desc_Materia = (string)drmateria["desc_materia"];
                    docCurs.Desc_Comision = (string)drmateria["desc_comision"];
                    lista.Add(docCurs);
                }
            }

            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Ecuentra la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }

        public  List<DocentesCursos> GetAll(int idpersona)
        {
            List<DocentesCursos> lista = new List<DocentesCursos>();
            try
            {
                this.OpenConnection();
                int estado;
                SqlCommand cmddocentescursos = new SqlCommand("select dc.id_dictado,cr.id_curso,per.id_persona,dc.cargo,per.nombre,per.apellido,mat.desc_materia"+
                                                              "com.desc_comision from docentes_cursos dc inner join cursos cr on dc.id_curso=cr.id_curso inner join"+
                                                              " personas per on per.id_persona=dc.id_docente inner join materias mat on mat.id_materia=cr.id_materia"+
                                                              " inner join comisiones com on com.id_comision=cr.id_comision where per.id_persona=@id_persona", SqlConn);
                cmddocentescursos.Parameters.Add("@id_persona", SqlDbType.Int).Value = idpersona;
                SqlDataReader drmateria = cmddocentescursos.ExecuteReader();
                while (drmateria.Read())
                {
                    DocentesCursos docCurs = new DocentesCursos();
                    //_Especialidades esp = new _Especialidades();
                    docCurs.IdDictado = (int)drmateria["id_dictado"];
                    docCurs.IdCurso = (int)drmateria["id_curso"];
                    docCurs.IdDocente = (int)drmateria["id_persona"];
                   estado = (int)drmateria["cargo"];
                    if (estado==1)
                    {
                        docCurs.Cargo = Convert.ToString(rol.Titular);
                    }
                    else if (estado==2)
                    {
                         docCurs.Cargo = Convert.ToString(rol.Auxiliar);
                    }
                    else
                    {
                        docCurs.Cargo = Convert.ToString(rol.JTP);
                    }
                    ;
                    docCurs.Nombre = (string)drmateria["nombre"];
                    docCurs.Apellido = (string)drmateria["apellido"];
                    docCurs.Desc_Comision = (string)drmateria["desc_comision"];
                    lista.Add(docCurs);
                }
            }

            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Ecuentra la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }

       
        protected void Insertar(DocentesCursos DocCurs)
        {
            try
            {
                this.OpenConnection();
                string estado;
                SqlCommand cmdMateria = new SqlCommand("insert into docentes_cursos (id_docente, id_curso, cargo) values (@id_docente, @id_curso, @cargo)", SqlConn);

                cmdMateria.Parameters.Add("@id_docente", SqlDbType.VarChar, 50).Value = DocCurs.IdDocente;
                cmdMateria.Parameters.Add("@id_curso", SqlDbType.Int).Value = DocCurs.IdCurso;
                estado = DocCurs.Cargo;
                if (estado==Convert.ToString(rol.Titular))
                {
                    cmdMateria.Parameters.Add("@cargo", SqlDbType.Int).Value = 1;
                }
                else if (estado==Convert.ToString(rol.Auxiliar))
                {
                    cmdMateria.Parameters.Add("@cargo", SqlDbType.Int).Value = 2;
                }
                else
                {
                    cmdMateria.Parameters.Add("@cargo", SqlDbType.Int).Value = 3;
                }

                cmdMateria.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear docente Curso", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {

                this.CloseConnection();
            }
        }

        protected void Delete(DocentesCursos DocCurs)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdelete = new SqlCommand("delete docentes_cursos where id_dictado=@id_dictado", SqlConn);
                cmdelete.Parameters.Add("@id_dictado", SqlDbType.Int).Value = DocCurs.IdDictado;
                Convert.ToInt32(cmdelete.ExecuteNonQuery());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al elimanar docente Curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open)
                    this.CloseConnection();
            }
        }
        protected void Update(DocentesCursos DocCurs)
        {
            try
            {
                this.OpenConnection();
                string estado;
                SqlCommand cmdMateria = new SqlCommand("update docentes_cursos set  cargo=@cargo,id_docente=@idDocente, id_curso=@idCurso  where id_dictado=@idDictado", SqlConn);
                              
                estado = DocCurs.Cargo;
                if (estado == Convert.ToString(rol.Titular))
                {
                    cmdMateria.Parameters.Add("@cargo", SqlDbType.Int).Value = 1;
                }
                else if (estado == Convert.ToString(rol.Auxiliar))
                {
                    cmdMateria.Parameters.Add("@cargo", SqlDbType.Int).Value = 2;
                }
                else
                {
                    cmdMateria.Parameters.Add("@cargo", SqlDbType.Int).Value = 3;
                }
                cmdMateria.Parameters.Add("@idDocente", SqlDbType.Int).Value = DocCurs.IdDocente;
                cmdMateria.Parameters.Add("@idCurso", SqlDbType.Int).Value = DocCurs.IdCurso;
                cmdMateria.Parameters.Add("@idDictado", SqlDbType.Int).Value = DocCurs.IdDictado;
                Convert.ToInt32(cmdMateria.ExecuteNonQuery());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al midificar datos de la materia", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open)
                    this.CloseConnection();
            }
        }
        public void Save(DocentesCursos DocCurs)
        {
            if (DocCurs.Estado == BusinessEntity.Estados.Eliminar)
            {
                this.Delete(DocCurs);
            }
            else if (DocCurs.Estado == BusinessEntity.Estados.Nuevo)
            {
                this.Insertar(DocCurs);
            }

            else if (DocCurs.Estado == BusinessEntity.Estados.Modificar)
            {
                this.Update(DocCurs);
            }
            DocCurs.Estado = BusinessEntity.Estados.No_Modificar;
        }
    }
}
